using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _3_SortTriangles;

namespace _3_SortTrianglesTests
{
    [TestClass]
    public class InputTests
    {
        [TestMethod]
        public void IsTriangleTest_345_True()
        {
            bool expected = true;
            bool actual = Input.IsTriangle(3, 4, 5);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void IsTriangleTest_1327_False()
        {
            bool expected = false;
            bool actual = Input.IsTriangle(13, 2, 7);

            Assert.AreEqual(expected, actual);
        }
    }
}
