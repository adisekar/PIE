using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PIE.ArraysandStrings;

namespace PIE.Test.ArraysandStrings
{
    [TestClass]
    public class RemoveSpecifiedCharacterTest
    {
        [TestMethod]
        public void CharinArrayPosition()
        {
            bool[] result = RemoveSpecifiedCharacters.GetBooleanArrayOfCharacters("aeiou");
            int c = (int)'a';
            //int offset = (int)'A';
            //int charPosition = character - offset;

            Assert.AreEqual(result[c], true);
        }
        [TestMethod]
        public void RemoveSpecifiedChars()
        {
            string result = RemoveSpecifiedCharacters.RemoveCharInString("Battle of the Vowels: Hawaii vs Grozny", "aeiou");
            Assert.AreEqual(result, "Bttl f th Vwls: Hw vs Grzny");
        }
    }
}
