using Microsoft.VisualStudio.TestTools.UnitTesting;
using GetMaximum;
namespace GetMaximumTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void MaxAtPositionOne()
        {
            int firstValue = 18, secondValue = 8, thirdValue = 1;
            int expected = 18;
            MaximumNumber answer = new MaximumNumber();
            int actual = answer.MaximumIntegerNumber(firstValue, secondValue,thirdValue);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void MaxAtPositionTwo()
        {
            int firstValue = 18, secondValue = 28, thirdValue = 1;
            int expected = 28;
            MaximumNumber answer = new MaximumNumber();
            int actual = answer.MaximumIntegerNumber(firstValue, secondValue, thirdValue);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void MaxAtPositionThree()
        {
            int firstValue = 18, secondValue = 8, thirdValue = 31;
            int expected = 31;
            MaximumNumber answer = new MaximumNumber();
            int actual = answer.MaximumIntegerNumber(firstValue, secondValue, thirdValue);
            Assert.AreEqual(expected, actual);
        }
        public void MaxAtPositionOneFloat()
        {
            double firstValue = 18.1, secondValue = 8.1, thirdValue = 1.1;
            double expected = 18.1;
            MaximumNumber answer = new MaximumNumber();
            double actual = answer.MaximumFloatNumber(firstValue, secondValue, thirdValue);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void MaxAtPositionTwoFloat()
        {
            double firstValue = 18.1, secondValue = 28.1, thirdValue = 1.1;
            double expected = 28.1;
            MaximumNumber answer = new MaximumNumber();
            double actual = answer.MaximumFloatNumber(firstValue, secondValue, thirdValue);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void MaxAtPositionThreeFloat()
        {
            double firstValue = 18.1, secondValue = 8.1, thirdValue = 31.1;
            double expected = 31.1;
            MaximumNumber answer = new MaximumNumber();
            double actual = answer.MaximumFloatNumber(firstValue, secondValue, thirdValue);
            Assert.AreEqual(expected, actual);
        }
    }
}
