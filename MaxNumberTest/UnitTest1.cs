using MaximumNumber;
using NUnit.Framework;

namespace MaxNumberTest
{
    public class Tests
    {
        [Test]
        public void GivenIntegerValuesFistPositionMax_WhenCheck__ShouldReturnMaxNum()
        {
            TestMaximum maximum = new TestMaximum();
            int max = maximum.MaximumIntNumberCheck(3, 2, 1);
            Assert.AreEqual(3, max);
        }

        [Test]
        public void GivenIntegerValuesSecondPositionMax_WhenCheck_ShouldReturnMaxNum()
        {
            TestMaximum maximum = new TestMaximum();
            int max = maximum.MaximumIntNumberCheck(1, 3, 2);
            Assert.AreEqual(3, max);
        }
        [Test]
        public void GivenIntegerValuesThirdPositionMax_WhenCheck_ShouldReturnMaxNum()
        {
            TestMaximum maximum = new TestMaximum();
            int max = maximum.MaximumIntNumberCheck(1, 2, 3);
            Assert.AreEqual(3, max);
        }
    }
}