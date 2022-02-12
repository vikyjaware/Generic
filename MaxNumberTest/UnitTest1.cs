using NUnit.Framework;
using MaximumNumber;

namespace MaxNumberTest
{
    public class Tests
    {
        [Test]
<<<<<<< HEAD
        public void GivenFloatValuesFistPositionMax_WhenCheck__ShouldReturnMaxNumber()
        {
            TestMaximum maximum = new TestMaximum();
<<<<<<< HEAD
            double max = maximum.MaximumFloatNumberCheck(3.3, 2.2, 1.1);
=======
            double max = maximum.MaximumIntNumberCheck(3.3, 2.2, 1.1);
>>>>>>> UC2-FloatMaximumNumber
            Assert.AreEqual(3.3, max);
        }

        [Test]
        public void GivenFloatValuesSecondPositionMax_WhenCheck_ShouldReturnMaxNumber()
        {
            TestMaximum maximum = new TestMaximum();
<<<<<<< HEAD
            double max = maximum.MaximumFloatNumberCheck(1.1, 3.3, 2.2);
=======
            double max = maximum.MaximumIntNumberCheck(1.1, 3.3, 2.2);
>>>>>>> UC2-FloatMaximumNumber
            Assert.AreEqual(3.3, max);
        }
        [Test]
        public void GivenFloatValuesThirdPositionMax_WhenCheck_ShouldReturnMaxNumber()
        {
            TestMaximum maximum = new TestMaximum();
<<<<<<< HEAD
            double max = maximum.MaximumFloatNumberCheck(1.1, 2.2, 3.3);
=======
            double max = maximum.MaximumIntNumberCheck(1.1, 2.2, 3.3);
>>>>>>> UC2-FloatMaximumNumber
            Assert.AreEqual(3.3, max);
=======
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
>>>>>>> UC3-StringMaximum
        }
    }
}