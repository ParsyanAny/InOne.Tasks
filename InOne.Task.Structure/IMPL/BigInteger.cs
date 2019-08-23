using System;

namespace InOne.Task.Structure.IMPL
{
        public class BigInteger  // : ICalculate, IEnumerable
        {
            private MyLinkedList<int> list;
            public BigInteger(int num)
            {
                list = new MyLinkedList<int>();
                while (num > 0)
                {
                    list.Add(num % 10);
                    num /= 10;
                }
            }
            private BigInteger() { }

            public BigInteger Sum(int num)
            {
                return new BigInteger(num).Sum(this);
                //return this.Sum(new BigInteger(num));
            }
            public BigInteger Sum(BigInteger num)
            {
                var list2 = num.list;
                MyLinkedList<int> sumList = new MyLinkedList<int>();
                int tr = 0;
                int count1 = this.list._Count;
                int count2 = num.list._Count;
                while (!list.IsEmpty() && !num.list.IsEmpty())
                {
                    int sum = list.First() + num.list.First();
                    if (sum < 10)
                    {
                        sumList.AddFirst(sum + tr);
                        tr = 0;
                    }
                    else
                    {
                        sumList.AddFirst(sum % 10 + tr);
                        tr = sum / 10 + tr;
                        if (sum - 10 == 0)
                            tr = 1;
                    }
                    list.RemoveFirst();
                    num.list.RemoveFirst();
                }
                if (count1 != count2)
                {
                    if (count1 > count2)
                    {
                        while (!list.IsEmpty())
                        {
                            int firstEl = list.First();
                            if (tr == 0)
                                sumList.AddFirst(firstEl);
                            else
                                if (firstEl + tr < 10)
                            {
                                sumList.AddFirst(firstEl + tr);
                                tr = 0;
                            }
                            else
                                sumList.AddFirst((firstEl + tr) % 10);
                            list.RemoveFirst();
                        }
                    }
                    else
                        while (!num.list.IsEmpty())
                        {
                            while (!num.list.IsEmpty())
                            {
                                int firstEl = num.list.First();
                                if (tr == 0)
                                    sumList.AddFirst(firstEl);
                                else
                                    if (firstEl + tr < 10)
                                {
                                    sumList.AddFirst(firstEl + tr);
                                    tr = 0;
                                }
                                else
                                    sumList.AddFirst((firstEl + tr) % 10);
                                num.list.RemoveFirst();
                            }
                        }
                }
                if (tr > 0)
                    sumList.AddFirst(1);
                if (sumList.First() == 0)
                    sumList.RemoveFirst();
                return new BigInteger() { list = sumList };
                //   return sumList;
            }
            public BigInteger Subtraction(BigInteger num)
            {
                var list2 = num.list;
                MyLinkedList<int> subList = new MyLinkedList<int>();
                int tr = 0;
                int count1 = this.list._Count;
                int count2 = num.list._Count;

                while (!list.IsEmpty() && !num.list.IsEmpty())
                {
                    int firstEl = list.First();
                    int secondEl = num.list.First();
                    int min = firstEl - secondEl;
                    if (min < 0)
                    {
                        subList.AddFirst((firstEl + 10) - secondEl + tr);
                        tr = -1;
                    }
                    else
                    {
                        subList.AddFirst(Math.Abs(min + tr));
                        tr = 0;
                    }
                    list.RemoveFirst();
                    num.list.RemoveFirst();
                }
                if (count1 != count2)
                {
                    while (!list.IsEmpty())
                    {
                        if (list.First() == 0 && tr != 0)
                        {
                            subList.AddFirst(list.First() + 10 + tr);
                            tr = -1;
                        }
                        else
                        {
                            subList.AddFirst(Math.Abs(list.First() + tr));
                            tr = 0;
                        }
                        list.RemoveFirst();
                    }
                }
                while (subList.First() == 0)
                {
                    subList.RemoveFirst();
                }
                return new BigInteger() { list = subList };
            }


        //    public BigInteger Multiplication(BigInteger number)
        //    {
        //    var list2 = number.list;
        //    MyLinkedList<int> mulList = new MyLinkedList<int>();
        //    int tr = 0;
        //    int count1 = list._Count;
        //    int count2 = number.list._Count;
        //    while (!list.IsEmpty())
        //    {
        //        MyLinkedList<int> trList = new MyLinkedList<int>();
        //        while (!list.IsEmpty())
        //        {
        //            int mul = list.First() * number.list.First();
        //            if (mul < 10)
        //            {
        //                trList.AddFirst(mul + tr);
        //                tr = 0;
        //            }
        //            else
        //            {
        //                if (tr == 0)
        //                    tr = mul - (mul % 10);
        //                else
        //                {
        //                    tr = mul - (mul % 10) + tr;
        //                }
        //                trList.AddFirst(mul % 10);
        //                if (mul - 10 == 0)
        //                    tr = 1;
        //            }
        //            number.list.RemoveFirst();
        //        }
        //        if (tr != 0)
        //        {
        //            if (tr < 10)
        //                trList.AddFirst(tr);
        //            else
        //            {
        //                trList.AddFirst(tr % 10);
        //                trList.AddFirst(tr / 10);
        //            }
        //        }
        //        if (!mulList.IsEmpty())
        //            mulList = trList;
        //        else
        //        {
        //            mulList.AddFirst(0);
        //            mulList = Sum(trList);
        //        }
        //        list.RemoveFirst();
        //    }
        //    return new BigInteger() { list = mulList };
        //}
        //public mylinkedlist<int> multiplication(int first, int second)
        //{
        //    _list1 = createbiginteger(_list1, first);
        //    _list2 = createbiginteger(_list2, second);
        //    mylinkedlist<int> mullist = new mylinkedlist<int>();
        //    int tr = 0;
        //    int count1 = _list1._count;
        //    int count2 = _list2._count;
        //    while (!_list1.isempty())
        //    {
        //        mylinkedlist<int> trlist = new mylinkedlist<int>();
        //        while (!_list2.isempty())
        //        {

        //            int mul = _list1.first() * _list2.first();
        //            if (mul < 10)
        //            {
        //                trlist.addfirst(mul + tr);
        //                tr = 0;
        //            }
        //            else
        //            {
        //                if (tr == 0)
        //                    tr = mul - (mul % 10);
        //                else
        //                {
        //                    tr = mul - (mul % 10) + tr;
        //                }
        //                trlist.addfirst(mul % 10);
        //                if (mul - 10 == 0)
        //                    tr = 1;
        //            }
        //            _list2.removefirst();
        //        }
        //        if (tr != 0)
        //        {
        //            if (tr < 10)
        //                trlist.addfirst(tr);
        //            else
        //            {
        //                trlist.addfirst(tr % 10);
        //                trlist.addfirst(tr / 10);
        //            }
        //        }
        //        if (!mullist.isempty())
        //            mullist = trlist;
        //        else
        //        {
        //            mullist.addfirst(0);
        //            mullist = sum(trlist, mullist);
        //        }
        //        _list1.removefirst();
        //    }
        //    return mullist;
        //}
        public BigInteger Division(BigInteger number)
            {
                throw new NotImplementedException();
            }

           
            //    //public MyLinkedList<int> Multiplication(int first, int second)
            //    //{
            //    //    _list1 = CreateBigInteger(_list1, first);
            //    //    _list2 = CreateBigInteger(_list2, second);
            //    //    MyLinkedList<int> mulList = new MyLinkedList<int>();
            //    //    int tr = 0;
            //    //    int count1 = _list1._Count;
            //    //    int count2 = _list2._Count;
            //    //    if (_list1._Count < _list2._Count)
            //    //    {
            //    //        while (!_list1.IsEmpty())
            //    //        {
            //    //            MyLinkedList<int> trList = new MyLinkedList<int>();
            //    //            while (!_list2.IsEmpty())
            //    //            {
            //    //                int mul = _list1.First() * _list2.First();
            //    //                if (mul < 10)
            //    //                {
            //    //                    trList.AddFirst(mul + tr);
            //    //                    tr = 0;
            //    //                }
            //    //                else
            //    //                {
            //    //                    if (tr == 0)
            //    //                        tr = mul / 10;
            //    //                    else
            //    //                    {
            //    //                        tr = mul / 10 + tr;
            //    //                    }
            //    //                    trList.AddFirst(mul % 10);
            //    //                    if (mul - 10 == 0)
            //    //                        tr = 1;
            //    //                }
            //    //                _list2.RemoveFirst();
            //    //            }
            //    //            if (tr != 0)
            //    //            {
            //    //                if (tr < 10)
            //    //                    trList.AddFirst(tr);
            //    //                else
            //    //                {
            //    //                    trList.AddFirst(tr % 10);
            //    //                    trList.AddFirst(tr / 10);
            //    //                }
            //    //            }
            //    //            if (mulList.IsEmpty())
            //    //                mulList = trList;
            //    //            else
            //    //            {
            //    //                mulList.AddFirst(0);
            //    //                mulList = Sum(trList, mulList);
            //    //            }
            //    //            _list1.RemoveFirst();
            //    //        }
            //    //    }
            //    //    else
            //    //    {
            //    //        while (!_list2.IsEmpty())
            //    //        {
            //    //            MyLinkedList<int> trList = new MyLinkedList<int>();
            //    //            while (!_list1.IsEmpty())
            //    //            {
            //    //                int mul = _list2.First() * _list1.First();
            //    //                if (mul < 10)
            //    //                {
            //    //                    trList.AddFirst(mul + tr);
            //    //                    tr = 0;
            //    //                }
            //    //                else
            //    //                {
            //    //                    if (tr == 0)
            //    //                        tr = mul / 10;
            //    //                    else
            //    //                    {
            //    //                        tr = mul / 10 + tr;
            //    //                    }
            //    //                    trList.AddFirst(mul % 10);
            //    //                    if (mul - 10 == 0)
            //    //                        tr = 1;
            //    //                }
            //    //                _list1.RemoveFirst();
            //    //            }
            //    //            if (tr != 0)
            //    //            {
            //    //                if (tr < 10)
            //    //                    trList.AddFirst(tr);
            //    //                else
            //    //                {
            //    //                    trList.AddFirst(tr % 10);
            //    //                    trList.AddFirst(tr / 10);
            //    //                }
            //    //            }
            //    //            if (mulList.IsEmpty())
            //    //                mulList = trList;
            //    //            else
            //    //            {
            //    //                mulList.AddFirst(0);
            //    //                mulList = Sum(trList, mulList);
            //    //            }
            //    //            _list2.RemoveFirst();
            //    //        }
            //    //    }
            //    //    return mulList;
            //    //}
            //    public MyLinkedList<int> Division(int first, int second)
            //    {
            //        throw new NotImplementedException();
            //    }

            //    public MyLinkedList<int> Multiplication(int first, int second)
            //    {
            //        _list1 = CreateBigInteger(_list1, first);
            //        _list2 = CreateBigInteger(_list2, second);
            //        MyLinkedList<int> mulList = new MyLinkedList<int>();
            //        int tr = 0;
            //        int count1 = _list1._Count;
            //        int count2 = _list2._Count;
            //        MyLinkedList<int> trList = new MyLinkedList<int>();

            //        while (!_list2.IsEmpty())
            //        {

            //            int mul = _list1.First() * _list2.First();
            //            if (mul < 10)
            //            {
            //                trList.AddFirst(mul + tr);
            //                tr = 0;
            //            }
            //            else
            //            {
            //                if (tr == 0)
            //                    tr = mul - (mul % 10);
            //                else
            //                {
            //                    tr = mul - (mul % 10) + tr;
            //                }
            //                trList.AddFirst(mul % 10);
            //                if (mul - 10 == 0)
            //                    tr = 1;
            //            }
            //            _list2.RemoveFirst();
            //        }
            //        if (tr != 0)
            //        {
            //            if (tr < 10)
            //                trList.AddFirst(tr);
            //            else
            //            {
            //                //trList.AddFirst(tr % 10);
            //                trList.AddFirst(tr / 10);
            //            }
            //        }
            //        if (mulList.IsEmpty())
            //            mulList = trList;
            //        else
            //        {
            //            trList.AddLast(0);
            //            mulList = Sum(mulList, trList);
            //        }
            //        return mulList;
            //    }
            //}
        }
    }
