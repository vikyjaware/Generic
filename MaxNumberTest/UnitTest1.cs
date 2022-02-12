using NUnit.Framework;
using MaximumNumber;

namespace MaxNumberTest
{
    public class Tests
    {
        TestMaximum<int> maxInt = new TestMaximum<int>();
        TestMaximum<double> maxFloat = new TestMaximum<double>();
        TestMaximum<string> maxString = new TestMaximum<string>();
      //For integers
       [Test]
        public void GivenIntegerValuesFistPositionMax_WhenCheck__ShouldReturnMaxNum()
        {
            int max = maxInt.MaximumCheck(3, 2, 1);
            Assert.AreEqual(3, max);
        }

        [Test]
        public void GivenIntegerValuesSecondPositionMax_WhenCheck_ShouldReturnMaxNum()
        {
            int max = maxInt.MaximumCheck(1, 3, 2);
            Assert.AreEqual(3, max);
        }
        [Test]
        public void GivenIntegerValuesThirdPositionMax_WhenCheck_ShouldReturnMaxNum()
        {
            int max = maxInt.MaximumCheck(1, 2, 3);
            Assert.AreEqual(3, max);
        }

        //For Float
        [Test]
        public void GivenFloatValuesFistPositionMax_WhenCheck__ShouldReturnMaxNum()
        {
            double max = maxFloat.MaximumCheck(3.3, 2.2, 1.1);
            Assert.AreEqual(3.3, max);
        }

        [Test]
        public void GivenFloatValuesSecondPositionMax_WhenCheck_ShouldReturnMaxNum()
        {
            double max = maxFloat.MaximumCheck(1.1, 3.3, 2.2);
            Assert.AreEqual(3.3, max);
        }
        [Test]
        public void GivenFloatValuesThirdPositionMax_WhenCheck_ShouldReturnMaxNum()
        {
            double max = maxFloat.MaximumCheck(1.1, 2.2, 3.3);
            Assert.AreEqual(3.3, max);
        }

        //For String
        [Test]
        public void GivenStringValuesFistPositionMax_WhenCheck__ShouldReturnMaxNum()
        {
            string max = maxString.MaximumCheck("Peach", "Apple", "Banana");
            Assert.AreEqual("Peach", max);
        }

        [Test]
        public void GivenStringValuesSecondPositionMax_WhenCheck_ShouldReturnMaxNum()
        {
            string max = maxString.MaximumCheck("Banana", "Peach", "Apple");
            Assert.AreEqual("Peach", max);
        }
        [Test]
        public void GivenStringValuesThirdPositionMax_WhenCheck_ShouldReturnMaxNum()
        {
            string max = maxString.MaximumCheck("Apple", "Banana", "Peach");
            Assert.AreEqual("Peach", max);
        }
    }
}
