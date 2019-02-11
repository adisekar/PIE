using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PIE.ArraysandStrings;

namespace PIE.Test.ArraysandStrings
{
    [TestClass]
    public class ReverseWordsTest
    {
        [TestMethod]
        public void ReverseString()
        {
           string result =  ReverseWords.Reverse("Hello");
            Assert.AreEqual("olleH", result);
        }

        [TestMethod]
        public void ReverseTheWords()
        {
            string result = ReverseWords.WordReverse("Do or do not, there is no try.");
            Assert.AreEqual("try. no is there not, do or Do", result);
        }

        [TestMethod]
        public void ReverseTheWordsUsingReverse()
        {
            string result = ReverseWords.WordReverseUsingReverse("Do or do not, there is no try.");
            Assert.AreEqual("try. no is there not, do or Do", result);
        }
    }
}
