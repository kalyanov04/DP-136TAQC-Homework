using Microsoft.VisualStudio.TestTools.UnitTesting;
using _5_NumberToText;
using System.Text;

namespace _5_NumberToTextTest
{
    [TestClass]
    public class ConverterTests
    {
        [TestMethod]
        public void ConvertToThousandsTest_1337562()
        {
            long number = 1337562;

            System.String expected = "пятьсот шестьдесят два ";

            string actual = Converter.ConvertToHundreds(number, true, "", "", "");

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ConvertToThousandsTest_Thousands1337562()
        {
            long number = 1337562;
            number /= 1000;

            System.String expected = "триста тридцать семь тысяч ";

            string actual = Converter.ConvertToHundreds(number, false, "тысяча ", "тысячи ", "тысяч ");

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ConvertToStringTest_MaxLong()
        {
            long number = 9223372036854775807;

            System.String expected = "девять квинтиллионов двести двадцать три квадриллиона триста семьдесят два триллиона " +
                "тридцать шесть миллиардов восемьсот пятьдесят четыре миллиона семьсот семьдесят пять тысяч восемьсот семь ";

            string actual = Converter.ConvertToString(number);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ConvertToStringTest_0()
        {
            long number = 0;

            System.String expected = "ноль";

            string actual = Converter.ConvertToString(number);

            Assert.AreEqual(expected, actual);
        }
    }
}
