using System;

namespace InOne.Task.Structure.IMPL
{
    public class BigInteger : MyLinkedList<int>//, ICalculate
    {
        private MyLinkedList<int> _list1;
        private MyLinkedList<int> _list2;
        public MyLinkedList<int> CreateBigInteger(MyLinkedList<int> list, int number)
        {
            list = new MyLinkedList<int>();
            while (number > 0)
            {
                list.Add(number % 10);
                number /= 10;
            }
            return list;
        }
        public MyLinkedList<int> Sum(int first, int second)
        {
            _list1 = CreateBigInteger(_list1, first);
            _list2 = CreateBigInteger(_list2, second);
            MyLinkedList<int> sumList = new MyLinkedList<int>();
            int tr = 0;
            int count1 = _list1._Count;
            int count2 = _list2._Count;
            while (!_list1.IsEmpty() && !_list2.IsEmpty())
            {
                int sum = _list1.First() + _list2.First();
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
                _list1.RemoveFirst();
                _list2.RemoveFirst();
            }
            if (count1 != count2)
            {
                if (count1 > count2)
                {
                    while (!_list1.IsEmpty())
                    {
                        int firstEl = _list1.First();
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
                        _list1.RemoveFirst();
                    }
                }
                else
                    while (!_list2.IsEmpty())
                    {
                        while (!_list2.IsEmpty())
                        {
                            int firstEl = _list2.First();
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
                            _list2.RemoveFirst();
                        }
                    }
            }
            if (tr > 0)
                sumList.AddFirst(1);
            if (sumList.First() == 0)
                sumList.RemoveFirst();
            return sumList;
        }
        public MyLinkedList<int> Sum(MyLinkedList<int> first, MyLinkedList<int> second)
        {
            MyLinkedList<int> sumList = new MyLinkedList<int>();
            int tr = 0;
            int count1 = _list1._Count;
            int count2 = _list2._Count;
            while (!_list1.IsEmpty() && !_list2.IsEmpty())
            {
                int sum = _list1.First() + _list2.First();
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
                _list1.RemoveFirst();
                _list2.RemoveFirst();
            }
            if (count1 != count2)
            {
                if (count1 > count2)
                {
                    while (!_list1.IsEmpty())
                    {
                        int firstEl = _list1.First();
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
                        _list1.RemoveFirst();
                    }
                }
                else
                    while (!_list2.IsEmpty())
                    {
                        while (!_list2.IsEmpty())
                        {
                            int firstEl = _list2.First();
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
                            _list2.RemoveFirst();
                        }
                    }
            }
            if (tr > 0)
                sumList.AddFirst(1);
            if (sumList.First() == 0)
                sumList.RemoveFirst();
            return sumList;
        }
        public MyLinkedList<int> Subtraction(int first, int second)
        {
            _list1 = CreateBigInteger(_list1, first);
            _list2 = CreateBigInteger(_list2, second);
            MyLinkedList<int> subList = new MyLinkedList<int>();
            int tr = 0;
            int count1 = _list1._Count;
            int count2 = _list2._Count;
            while (!_list1.IsEmpty() && !_list2.IsEmpty())
            {
                int firstEl = _list1.First();
                int secondEl = _list2.First();
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
                _list1.RemoveFirst();
                _list2.RemoveFirst();
            }
            if (count1 != count2)
            {
                while (!_list1.IsEmpty())
                {
                    if (_list1.First() == 0 && tr != 0)
                    {
                        subList.AddFirst(_list1.First() + 10 + tr);
                        tr = -1;
                    }
                    else
                    {
                        subList.AddFirst(Math.Abs(_list1.First() + tr));
                        tr = 0;
                    }
                    _list1.RemoveFirst();
                }
            }
            while (subList.First() == 0)
            {
                subList.RemoveFirst();
            }
            return subList;
        }
        //public MyLinkedList<int> Multiplication(int first, int second)
        //{
        //    _list1 = CreateBigInteger(_list1, first);
        //    _list2 = CreateBigInteger(_list2, second);
        //    MyLinkedList<int> mulList = new MyLinkedList<int>();
        //    int tr = 0;
        //    int count1 = _list1._Count;
        //    int count2 = _list2._Count;
        //    while (!_list1.IsEmpty())
        //    {
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
        //                trList.AddFirst(tr % 10);
        //                trList.AddFirst(tr / 10);
        //            }
        //        }
        //        if (!mulList.IsEmpty())
        //            mulList = trList;
        //        else
        //        {
        //            mulList.AddFirst(0);
        //            mulList = Sum(trList, mulList);
        //        }
        //        _list1.RemoveFirst();
        //    }
        //    return mulList;
        //}
        //public MyLinkedList<int> Multiplication(int first, int second)
        //{
        //    _list1 = CreateBigInteger(_list1, first);
        //    _list2 = CreateBigInteger(_list2, second);
        //    MyLinkedList<int> mulList = new MyLinkedList<int>();
        //    int tr = 0;
        //    int count1 = _list1._Count;
        //    int count2 = _list2._Count;
        //    if (_list1._Count < _list2._Count)
        //    {
        //        while (!_list1.IsEmpty())
        //        {
        //            MyLinkedList<int> trList = new MyLinkedList<int>();
        //            while (!_list2.IsEmpty())
        //            {
        //                int mul = _list1.First() * _list2.First();
        //                if (mul < 10)
        //                {
        //                    trList.AddFirst(mul + tr);
        //                    tr = 0;
        //                }
        //                else
        //                {
        //                    if (tr == 0)
        //                        tr = mul / 10;
        //                    else
        //                    {
        //                        tr = mul / 10 + tr;
        //                    }
        //                    trList.AddFirst(mul % 10);
        //                    if (mul - 10 == 0)
        //                        tr = 1;
        //                }
        //                _list2.RemoveFirst();
        //            }
        //            if (tr != 0)
        //            {
        //                if (tr < 10)
        //                    trList.AddFirst(tr);
        //                else
        //                {
        //                    trList.AddFirst(tr % 10);
        //                    trList.AddFirst(tr / 10);
        //                }
        //            }
        //            if (mulList.IsEmpty())
        //                mulList = trList;
        //            else
        //            {
        //                mulList.AddFirst(0);
        //                mulList = Sum(trList, mulList);
        //            }
        //            _list1.RemoveFirst();
        //        }
        //    }
        //    else
        //    {
        //        while (!_list2.IsEmpty())
        //        {
        //            MyLinkedList<int> trList = new MyLinkedList<int>();
        //            while (!_list1.IsEmpty())
        //            {
        //                int mul = _list2.First() * _list1.First();
        //                if (mul < 10)
        //                {
        //                    trList.AddFirst(mul + tr);
        //                    tr = 0;
        //                }
        //                else
        //                {
        //                    if (tr == 0)
        //                        tr = mul / 10;
        //                    else
        //                    {
        //                        tr = mul / 10 + tr;
        //                    }
        //                    trList.AddFirst(mul % 10);
        //                    if (mul - 10 == 0)
        //                        tr = 1;
        //                }
        //                _list1.RemoveFirst();
        //            }
        //            if (tr != 0)
        //            {
        //                if (tr < 10)
        //                    trList.AddFirst(tr);
        //                else
        //                {
        //                    trList.AddFirst(tr % 10);
        //                    trList.AddFirst(tr / 10);
        //                }
        //            }
        //            if (mulList.IsEmpty())
        //                mulList = trList;
        //            else
        //            {
        //                mulList.AddFirst(0);
        //                mulList = Sum(trList, mulList);
        //            }
        //            _list2.RemoveFirst();
        //        }
        //    }
        //    return mulList;
        //}
        public MyLinkedList<int> Division(int first, int second)
        {
            throw new NotImplementedException();
        }

        public MyLinkedList<int> Multiplication(int first, int second)
        {
            _list1 = CreateBigInteger(_list1, first);
            _list2 = CreateBigInteger(_list2, second);
            MyLinkedList<int> mulList = new MyLinkedList<int>();
            int tr = 0;
            int count1 = _list1._Count;
            int count2 = _list2._Count;
            MyLinkedList<int> trList = new MyLinkedList<int>();

            while (!_list2.IsEmpty())
            {

                int mul = _list1.First() * _list2.First();
                if (mul < 10)
                {
                    trList.AddFirst(mul + tr);
                    tr = 0;
                }
                else
                {
                    if (tr == 0)
                        tr = mul - (mul % 10);
                    else
                    {
                        tr = mul - (mul % 10) + tr;
                    }
                    trList.AddFirst(mul % 10);
                    if (mul - 10 == 0)
                        tr = 1;
                }
                _list2.RemoveFirst();
            }
            if (tr != 0)
            {
                if (tr < 10)
                    trList.AddFirst(tr);
                else
                {
                    //trList.AddFirst(tr % 10);
                    trList.AddFirst(tr / 10);
                }
            }
            if (mulList.IsEmpty())
                mulList = trList;
            else
            {
                trList.AddLast(0);
                mulList = Sum(mulList, trList);
            }
            return mulList;
        }
    }
}
