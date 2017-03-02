using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NumberWorder.Test
{
    [TestClass]
    public class NumberWorderTest
    {
        public NumberWordProcessor NumberWorder { get; set; }

        public NumberWorderTest()
        {
            NumberWorder = new NumberWordProcessor();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ConvertNumbersToWords_NullParam_ExceptionThrown()
        {
            NumberWorder.ConvertNumbersToWords(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ConvertNumbersToWords_EmptyParam_ExceptionThrown()
        {
            NumberWorder.ConvertNumbersToWords("a-1");
        }

        [TestMethod]
        public void ConvertNumbersToWords_AllNumberTypes_CorrectWords()
        {
            var words = NumberWorder.ConvertNumbersToWords("1234567890");
            Assert.IsTrue(words == "ONETWOTHREEFOURFIVESIXSEVENEIGHTNINEZERO");
        }
    }
}
