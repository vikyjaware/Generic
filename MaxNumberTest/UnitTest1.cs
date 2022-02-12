using MaximumNumber;
using NUnit.Framework;

namespace MaxNumberTest
{
    public class Tests
    {
        [Test]
<<<<<<< HEAD
        public void GivenFloatValuesFistPositionMax_WhenCheck__ShouldReturnMaxNumber()
=======
        public void GivenIntegerValuesFistPositionMax_WhenCheck__ShouldReturnMaxNumber()
>>>>>>> UC2-FloatMaximumNumber
        {
            TestMaximum maximum = new TestMaximum();
            double max = maximum.MaximumFloatNumberCheck(3.3, 2.2, 1.1);
            Assert.AreEqual(3.3, max);
        }

        [Test]
<<<<<<< HEAD
        public void GivenFloatValuesSecondPositionMax_WhenCheck_ShouldReturnMaxNumber()
=======
        public void GivenIntegerValuesSecondPositionMax_WhenCheck_ShouldReturnMaxNumber()
>>>>>>> UC2-FloatMaximumNumber
        {
            TestMaximum maximum = new TestMaximum();
            double max = maximum.MaximumFloatNumberCheck(1.1, 3.3, 2.2);
            Assert.AreEqual(3.3, max);
        }
        [Test]
<<<<<<< HEAD
        public void GivenFloatValuesThirdPositionMax_WhenCheck_ShouldReturnMaxNumber()
=======
        public void GivenIntegerValuesThirdPositionMax_WhenCheck_ShouldReturnMaxNumber()
>>>>>>> UC2-FloatMaximumNumber
        {
            TestMaximum maximum = new TestMaximum();
            double max = maximum.MaximumFloatNumberCheck(1.1, 2.2, 3.3);
            Assert.AreEqual(3.3, max);
        }
    }
}