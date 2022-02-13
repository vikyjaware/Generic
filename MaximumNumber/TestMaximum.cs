using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MaximumNumber
{
    public class TestMaximum<T> where T: IComparable
    {
        public T first, second, third, fourth;
        public void TestMaximumnum(T first, T second, T third, [Optional] T fourth)
        {
            this.first = first;
            this.second = second;
            this.third = third;
            this.fourth = fourth;
        }
        public T MaximumCheck(T first, T second, T third, [Optional] T fourth)
        {
            if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0  && first.CompareTo(fourth) > 0 )
            {
                return first;
            }
            if (second.CompareTo(third) > 0 && second.CompareTo(first) > 0 && second.CompareTo(fourth) > 0)
            {
                return second;
            }
            if (third.CompareTo(second) > 0 && third.CompareTo(first) > 0 && third.CompareTo(fourth) > 0)
            {
                return third;
            }
            else
            {
                return fourth;
            }
        }
        public void Print(T var)
        {
            Console.WriteLine(var);
        }
    }
}
