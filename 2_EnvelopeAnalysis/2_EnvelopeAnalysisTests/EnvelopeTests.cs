using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _2_EnvelopeAnalysis;

namespace _2_EnvelopeAnalysisTests
{
    [TestClass]
    public class EnvelopeTests
    {
        [TestMethod]
        public void IsFitTest_Env1020Env0510_False()
        {
            Envelope envelope1 = new Envelope(10, 20);
            Envelope envelope2 = new Envelope(5, 10);

            bool expected = false;
            bool actual = Envelope.IsFit(envelope1, envelope2);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void IsFitTest_Env1530Env2043_True()
        {
            Envelope envelope1 = new Envelope(15, 30);
            Envelope envelope2 = new Envelope(20, 43);

            bool expected = true;
            bool actual = Envelope.IsFit(envelope1, envelope2);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void IsFitTest_Env0505Env0505_False()
        {
            Envelope envelope1 = new Envelope(5, 5);
            Envelope envelope2 = new Envelope(5, 5);

            bool expected = false;
            bool actual = Envelope.IsFit(envelope1, envelope2);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void IsFitTest_Env1220Env0530_False()
        {
            Envelope envelope1 = new Envelope(12, 20);
            Envelope envelope2 = new Envelope(5, 30);

            bool expected = false;
            bool actual = Envelope.IsFit(envelope1, envelope2);

            Assert.AreEqual(expected, actual);
        }
    }
}
