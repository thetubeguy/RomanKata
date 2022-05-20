using NUnit.Framework;
using FluentAssertions;
using RomanKata;

namespace RomanKata.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void Expect_VIII_For_8()
        {
            Convert_Roman_Numerals _this_conversion = new Convert_Roman_Numerals();

            string actual_result = _this_conversion.convert(8);


            string expected_result = "VIII";

            Assert.AreEqual(expected_result, actual_result);

        }

        [Test]
        public void Expect_IV_For_4()
        {
            Convert_Roman_Numerals _this_conversion = new Convert_Roman_Numerals();

            string actual_result = _this_conversion.convert(4);


            string expected_result = "IV";

            Assert.AreEqual(expected_result, actual_result);

        }

        [Test]
        public void Expect_IX_For_9()
        {
            Convert_Roman_Numerals _this_conversion = new Convert_Roman_Numerals();

            string actual_result = _this_conversion.convert(9);


            string expected_result = "IX";

            Assert.AreEqual(expected_result, actual_result);

        }

        [Test]
        public void Expect_XL_For_40()
        {
            Convert_Roman_Numerals _this_conversion = new Convert_Roman_Numerals();

            string actual_result = _this_conversion.convert(40);


            string expected_result = "XL";

            Assert.AreEqual(expected_result, actual_result);

        }

        [Test]
        public void Expect_CM_For_900()
        {
            Convert_Roman_Numerals _this_conversion = new Convert_Roman_Numerals();

            string actual_result = _this_conversion.convert(900);


            string expected_result = "CM";

            Assert.AreEqual(expected_result, actual_result);


        }

        [Test]
        public void Expect_MMCDXCIX_For_2499()
        {
            Convert_Roman_Numerals _this_conversion = new Convert_Roman_Numerals();

            string actual_result = _this_conversion.convert(2499);


            string expected_result = "MMCDXCIX";

            Assert.AreEqual(expected_result, actual_result);

        }
    }
}