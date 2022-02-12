using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumNumber
{
    public class TestMaximum
    {
<<<<<<< HEAD
        public double MaximumFloatNumberCheck(double first, double second, double third)
=======
        public double MaximumIntNumberCheck(double firstNumber, double secondNumber, double thirdNumber)
>>>>>>> UC2-FloatMaximumNumber
        {
            if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0)
            {
                return first;
            }
            if (second.CompareTo(third) > 0 && second.CompareTo(first) > 0)
            {
                return second;
            }
            else
            {
                return third;
            }
        }
    }
}
