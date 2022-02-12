using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumNumber
{
    public class TestMaximum
    {
        public double MaximumFloatNumberCheck(double firstNumber, double secondNumber, double thirdNumber)
        {
            if (firstNumber.CompareTo(secondNumber) > 0 && secondNumber.CompareTo(thirdNumber) > 0)
            {
                return firstNumber;
            }
            if (secondNumber.CompareTo(thirdNumber) > 0 && secondNumber.CompareTo(firstNumber) > 0)
            {
                return secondNumber;
            }
            else
            {
                return thirdNumber;
            }
        }
    }
}
