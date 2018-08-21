using Microsoft.VisualStudio.TestTools.UnitTesting;
using _8_Fibonacci;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace _8_Fibonacci.Tests
{
    [TestClass()]
    public class FibonacciTests
    {
        Fibonacci fibonacciRange;
        Fibonacci fibonacciLength;
        [TestInitialize()]
        public void FibonacciTest()
        {
            fibonacciRange = new Fibonacci(0, 20);
            fibonacciLength = new Fibonacci(2);
        }       
        [TestMethod()]
        public void ToStringTest_FibonacciRange()
        {
            string expected = "0 1 1 2 3 5 8 13 ";
            string actual = fibonacciRange.ToString();

            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void ToStringTest_FibonacciLength()
        {
            string expected = "13 21 34 55 89 ";
            string actual = fibonacciLength.ToString();

            Assert.AreEqual(expected, actual);
        }
    }
}