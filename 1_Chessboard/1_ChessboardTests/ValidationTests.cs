using Microsoft.VisualStudio.TestTools.UnitTesting;
using _1_Chessboard;

namespace _1_ChessboardTests
{
    [TestClass]
    public class ValidationTests
    {
        [TestMethod]
        public void IsIntegerTest_15_True()
        {
            string data = "15";
            bool expected = true;
            bool actual = Validation.IsInteger(data, out int result);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void IsIntegerTest_NotNumber_False()
        {
            string data = "Hello World";
            bool expected = false;
            bool actual = Validation.IsInteger(data, out int result);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void IsIntegerTest_DoubleNumber_False()
        {
            string data = "19,6";
            bool expected = false;
            bool actual = Validation.IsInteger(data, out int result);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void IsPositiveTest_5_True()
        {
            int data = 5;
            bool expected = true;
            bool actual = Validation.IsPositive(data);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void IsPositiveTest_Minus10_False()
        {
            int data = -10;
            bool expected = false;
            bool actual = Validation.IsPositive(data);

            Assert.AreEqual(expected, actual);
        }
    }
}
