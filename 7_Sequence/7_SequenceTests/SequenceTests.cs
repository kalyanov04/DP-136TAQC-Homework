using Microsoft.VisualStudio.TestTools.UnitTesting;
using _7_Sequence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Sequence.Tests
{
    [TestClass()]
    public class SequenceTests
    {
        Sequence sequence, sequence1;
        [TestInitialize()]
        public void SequenceTest()
        {
            sequence = new Sequence(10, 100);
            sequence1 = new Sequence(5, 881123);
        }

        [TestMethod()]
        public void ToStringTest_sequence()
        {
            string expected = "10 11 12 13 14 15 16 17 18 19 ";
            string actual = sequence.ToString();

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ToStringTest_sequence1()
        {
            string expected = "939 940 941 942 943 ";
            string actual = sequence1.ToString();

            Assert.AreEqual(expected, actual);
        }
    }
}