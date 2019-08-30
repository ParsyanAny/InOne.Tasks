using System;
using System.Collections;

namespace InOne.Task.Structure.IMPL
{
    public class BigInteger : IEnumerable // : ICalculate, IEnumerable
    {

        private MyLinkedList<int> list;
        private bool sign = false;
        public char Sign { get => sign == true ? '-' : '+'; }
        public BigInteger(int num)
        {
            if (num < 0)
            {
                sign = true;
                num = Math.Abs(num);
            }
            list = new MyLinkedList<int>();
            while (num > 0)
            {
                list.Add(num % 10);
                num /= 10;
            }
        }
        public BigInteger() { }
        public int Compare(MyLinkedList<int> other)
        {
            MyLinkedList<int> list1 = list;
            MyLinkedList<int> list2 = other;
            var count1 = list1._Count;
            var count2 = list2._Count;
            int res = -5;
            if (count1 < count2)
                res = -1;
            else if (count2 < count1)
                res = 1;
            else
            {
                while (count1 != 0 && res != -1)
                {
                    int f = list1.First();
                    int s = list2.First();
                    if (s < f)
                        res = -1;
                    else if (s == f)
                        res = 0;
                    list1.RemoveFirst();
                    list2.RemoveFirst();
                    count1--;
                }
                if (res == -5)
                    return 1;
            }
            return res;
        }
        #region + - * /
        public BigInteger Sum(int num) => new BigInteger(num).Sum(this);
        public BigInteger Sum(BigInteger num)
        {
            MyLinkedList<int> sumList = new MyLinkedList<int>();
            if (sign == true && num.sign == false)
            {
                BigInteger f = new BigInteger() { list = list };
                return f.Subtraction(num);
            }
            else if (sign == true && num.sign == false)
            {
                BigInteger f = new BigInteger() { list = list };
                return num.Subtraction(f);
            }
            else
            {
                var list2 = num.list;
                int tr = 0;
                int count1 = list._Count;
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

                if (sign == true && num.sign == true)
                    return new BigInteger() { list = sumList, sign = true };
                return new BigInteger() { list = sumList };
            }
        }
        public BigInteger Subtraction(int num) => new BigInteger(num).Subtraction(this);
        public BigInteger Subtraction(BigInteger num)
        {
            MyLinkedList<int> subList = new MyLinkedList<int>();
            if (sign == true && num.sign == true)
            {
                BigInteger f = new BigInteger() { list = list };
                return f.Sum(num);
            }
            else
            {
                var list2 = num.list;
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
            }
            if (sign == true && num.sign == true)
                return new BigInteger() { list = subList, sign = true };
            return new BigInteger() { list = subList };
        }
        public BigInteger Multiplication(int num) => new BigInteger(num).Multiplication(this);
        public BigInteger Multiplication(BigInteger number)
        {
            MyLinkedList<int> mulList = new MyLinkedList<int>();
            int tr = 0;
            int count1 = list._Count;
            int count2 = number.list._Count;
            while (!list.IsEmpty())
            {
                MyLinkedList<int> trList = new MyLinkedList<int>();
                while (!number.list.IsEmpty())
                {
                    int mul = list.First() * number.list.First();
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
                            tr = mul - (mul % 10) + tr;
                        trList.AddFirst(mul % 10);
                        if (mul - 10 == 0)
                            tr = 1;
                    }
                    number.list.RemoveFirst();
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
                    mulList.AddFirst(0);
                    BigInteger trI = new BigInteger() { list = trList };
                    BigInteger muI = new BigInteger() { list = mulList };
                    muI = Sum(trI);
                }
                list.RemoveFirst();
            }
            if (sign == true || number.sign == true)
                return new BigInteger() { list = mulList, sign = true };
            return new BigInteger() { list = mulList };
        }
        public BigInteger Division(int num) => new BigInteger(num).Division(this);
        public BigInteger Division(BigInteger num)
        {
            var list2 = num.list;
            list2.Reverse();
            list.Reverse();
            int count1 = list._Count;
            int count2 = num.list._Count;
            if (count2 > count1)
                throw new Exception("Your first number is too small");
            int tr = 0;
            MyLinkedList<int> divList = new MyLinkedList<int>();
            while (count1 != 0)
            {
                MyLinkedList<int> trList = new MyLinkedList<int>();
                while (count2 != 0)
                {
                    trList.AddFirst(list2.Last());
                    list2.RemoveLast();
                    count2--;
                }
                //if (trList.)
                //{

                //}

            }
            if (sign == true || num.sign == true)
                return new BigInteger() { list = divList, sign = true };
            return new BigInteger() { list = divList };
        }
        #endregion

        #region Factorial, Factorial
        public BigInteger Factorial(int number)
        {
            BigInteger fac = new BigInteger(FactorialInt(number));
            fac.Reverse();
            return fac;
        }
        private int FactorialInt(int number)
        {
            if (number == 0)
                return 1;
            return number * FactorialInt(number - 1);
        }
        public void Reverse()
        {
            this.list.Reverse();
        }
        #endregion

        #region IEnumerator
        public IEnumerator GetEnumerator()
        {
            foreach (var val in list)
            {
                yield return val;
            }
        }
        #endregion
    }
}
