using MaximumNumber;
using NUnit.Framework;

namespace MaxNumberTest
{
    public class Tests
    {
        [Test]
        public void GivenFloatValuesFistPositionMax_WhenCheck__ShouldReturnMaxNum()
        {
            TestMaximum maximum = new TestMaximum();
            double max = maximum.MaximumFloatNumberCheck(3.3, 2.2, 1.1);
            Assert.AreEqual(3.3, max);
        }

        [Test]
        public void GivenFloatValuesSecondPositionMax_WhenCheck_ShouldReturnMaxNum()
        {
            TestMaximum maximum = new TestMaximum();
            double max = maximum.MaximumFloatNumberCheck(1.1, 3.3, 2.2);
            Assert.AreEqual(3.3, max);
        }
        [Test]
        public void GivenFloatValuesThirdPositionMax_WhenCheck_ShouldReturnMaxNum()
        {
            TestMaximum maximum = new TestMaximum();
            double max = maximum.MaximumFloatNumberCheck(1.1, 2.2, 3.3);
            Assert.AreEqual(3.3, max);
        }
    }
}