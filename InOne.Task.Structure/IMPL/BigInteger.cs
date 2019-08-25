using System;
using System.Collections;

namespace InOne.Task.Structure.IMPL
{
    public class BigInteger : IEnumerable // : ICalculate, IEnumerable
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
        public BigInteger() { }

        #region + - * /
        public BigInteger Sum(int num) => new BigInteger(num).Sum(this);
        public BigInteger Sum(BigInteger num)
        {
            var list2 = num.list;
            MyLinkedList<int> sumList = new MyLinkedList<int>();
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
            return new BigInteger() { list = sumList };
        }
        public BigInteger Subtraction(int num) => new BigInteger(num).Subtraction(this);
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
                        {
                            tr = mul - (mul % 10) + tr;
                        }
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
                    BigInteger trI = new BigInteger() {list = trList };
                    BigInteger muI = new BigInteger() {list = mulList };
                    muI = Sum(trI);
                }
                list.RemoveFirst();
            }
            return new BigInteger() { list = mulList };
        }
        public BigInteger Division(int num) => new BigInteger(num).Division(this);
        public BigInteger Division(BigInteger number)
        {
            throw new NotImplementedException();
        }
        #endregion

        public BigInteger Factorial(int number) => new BigInteger(FactorialInt(number));
        private int FactorialInt(int number)
        {
            if (number == 0)
                return 1;
            return number * FactorialInt(number - 1);
        }
        public void Reverse(BigInteger bigInt)
        {
            
        } // ??????????
        public IEnumerator GetEnumerator()
        {
            foreach (var val in list)
            {
                yield return val;
            }
        }
    }
}
