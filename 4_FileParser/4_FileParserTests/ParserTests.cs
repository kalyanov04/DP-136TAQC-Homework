using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _4_FileParser;

namespace _4_FileParserTests
{
    [TestClass]
    public class ParserTests
    {
        Parser parser;
        [TestInitialize]
        public void CreateParser()
        {
            parser = new Parser(@"..\..\..\4_FileParser\text.txt");
        }
        [TestMethod]
        public void GetTextTest()
        {
            string expected = "Plorem ipsum dolor sit amet, consectetur adipiscing elit.\n" +
                "Mauris commodo magna orci, in feugiat sapien dictum facilisis.\n" +
                "Praesent augue nisl, gravida vitae justo vitae, facilisis sollicitudin nunc.\n" +
                "Ut a mollis dolor. Proin tortor augue, vestibulum ac dapibus et, consequat malesuada magna.\n" +
                "Curabitur ipsum sapien, tempus at fringilla ut, bibendum non lectus.\n" +
                "Plorem ipsum dolor sit amet, consectetur adipiscing elit.\n" +
                "Morbi dapibus eget est viverra tincidunt.";
            string actual = parser.GetText();

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CountStringTest_Lorem_2()
        {
            int expected = 2;
            int actual = parser.CountSubstring("Plorem");

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CountStringTest_e_30()
        {
            int expected = 30;
            int actual = parser.CountSubstring("e");

            Assert.AreEqual(expected, actual);
        }
    }
}
