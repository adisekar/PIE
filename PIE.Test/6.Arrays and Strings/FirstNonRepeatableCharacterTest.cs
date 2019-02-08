using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PIE.ArraysandStrings;

namespace DSandAlgorithms.Test.Arrays_and_Strings
{
    [TestClass]
    public class FirstNonRepeatableCharacterTest
    {
        [TestMethod]
        public void CaseInsensitiveTrue()
        {
            char? result = FirstNonRepeatableCharacter.Find("Total", true);
            Assert.AreEqual(result, 'o');
        }

        [TestMethod]
        public void CaseInsensitiveFalse()
        {
            char? result =   FirstNonRepeatableCharacter.Find("Total", false);
            Assert.AreEqual(result, 'T');
        }

        [TestMethod]
        public void FirstNonRepeatableCharacterTrue()
        {
            char? result = FirstNonRepeatableCharacter.Find("teeter", true);
            Assert.AreEqual(result, 'r');
        }

        [TestMethod]
        public void FirstNonRepeatableCharacterFalse()
        {
            char? result = FirstNonRepeatableCharacter.Find("Teeter", false);
            Assert.AreNotEqual(result, 'r');
        }

        [TestMethod]
        public void InputNull()
        {
            Action action = () => FirstNonRepeatableCharacter.Find(null, false);
            Assert.ThrowsException<NullReferenceException>(action);
        }

        [TestMethod]
        public void InputEmpty()
        {
            char? result = FirstNonRepeatableCharacter.Find("", false);
            Assert.IsNull(result);
        }
    }
}
