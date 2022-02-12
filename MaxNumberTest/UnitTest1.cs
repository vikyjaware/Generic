using MaximumNumber;
using NUnit.Framework;

namespace MaxNumberTest
{
    public class Tests
    {
        [Test]
        public void GivenStringValuesFistPositionMax_WhenCheck__ShouldReturnMaxNum()
        {
            TestMaximum maximum = new TestMaximum();
            string max = maximum.MaximumCheck("Peach", "Apple", "Banana");
            Assert.AreEqual("Peach", max);
        }

        [Test]
        public void GivenStringValuesSecondPositionMax_WhenCheck_ShouldReturnMaxNum()
        {
            TestMaximum maximum = new TestMaximum();
            string max = maximum.MaximumCheck("Banana", "Peach", "Apple");
            Assert.AreEqual("Peach", max);
        }
        [Test]
        public void GivenStringValuesThirdPositionMax_WhenCheck_ShouldReturnMaxNum()
        {
            TestMaximum maximum = new TestMaximum();
            string max = maximum.MaximumCheck("Apple", "Banana", "Peach");
            Assert.AreEqual("Peach", max);
        }
    }
}