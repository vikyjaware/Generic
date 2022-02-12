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
<<<<<<< HEAD
        public void GivenFloatValuesFistPositionMax_WhenCheck__ShouldReturnMaxNumber()
        {
<<<<<<< HEAD
            TestMaximum maximum = new TestMaximum();
<<<<<<< HEAD
            double max = maximum.MaximumFloatNumberCheck(3.3, 2.2, 1.1);
=======
            double max = maximum.MaximumIntNumberCheck(3.3, 2.2, 1.1);
>>>>>>> UC2-FloatMaximumNumber
            Assert.AreEqual(3.3, max);
=======
            int max = maxInt.MaximumCheck(3, 2, 1);
            Assert.AreEqual(3, max);
>>>>>>> UC4-RefactorUsingGeneric
        }

        [Test]
        public void GivenFloatValuesSecondPositionMax_WhenCheck_ShouldReturnMaxNumber()
        {
<<<<<<< HEAD
            TestMaximum maximum = new TestMaximum();
<<<<<<< HEAD
            double max = maximum.MaximumFloatNumberCheck(1.1, 3.3, 2.2);
=======
            double max = maximum.MaximumIntNumberCheck(1.1, 3.3, 2.2);
>>>>>>> UC2-FloatMaximumNumber
            Assert.AreEqual(3.3, max);
=======
            int max = maxInt.MaximumCheck(1, 3, 2);
            Assert.AreEqual(3, max);
>>>>>>> UC4-RefactorUsingGeneric
        }
        [Test]
        public void GivenFloatValuesThirdPositionMax_WhenCheck_ShouldReturnMaxNumber()
        {
<<<<<<< HEAD
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
=======
            int max = maxInt.MaximumCheck(1, 2, 3);
            Assert.AreEqual(3, max);
>>>>>>> UC4-RefactorUsingGeneric
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