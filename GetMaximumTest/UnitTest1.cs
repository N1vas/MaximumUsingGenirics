using Microsoft.VisualStudio.TestTools.UnitTesting;
using GetMaximum;
namespace GetMaximumTest
{
    [TestClass]
    public class UnitTest1
    {        
        [TestMethod]
        public void MaxAtPositionThree()
        {
            int[] intArray = { 10, 20, 31 };
            int expected = 31;
            MaximumNumber<int> answer = new MaximumNumber<int>(intArray);
            int actual = answer.MaxValue();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void MaxAtPositionOneFloat()
        {
            double[] doubleArray = { 10.5, 20.5, 30.5 };
            double expected = 30.5;
            MaximumNumber<double> answer = new MaximumNumber<double>(doubleArray);
            double actual = answer.MaxValue();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void MaxAtPositionTwoFloat()
        {
            string[] stringArray = { "10", "20", "30" };
            string expected = "30";
            MaximumNumber<string> answer = new MaximumNumber<string>(stringArray);
            string actual = answer.MaxValue();
            Assert.AreEqual(expected, actual);
        }
    }
}
