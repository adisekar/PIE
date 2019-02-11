using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIE.ArraysandStrings
{
   public class RemoveSpecifiedCharacters
    {
        public static string RemoveCharInString(string input, string charToBeRemoved)
        {
            StringBuilder sb = new StringBuilder();
            bool[] boolArrayOfCharacters = RemoveSpecifiedCharacters.GetBooleanArrayOfCharacters(charToBeRemoved);

            foreach(char c in input)
            {
                int character = (int)c;
                //int offset = (int)'A';
                //int charPosition = character - offset;
                if (boolArrayOfCharacters[character] == true)
                {
                    // Skip this without appending
                    continue;
                }
                sb.Append(c);
            }
            return sb.ToString();
        }

        public static bool[] GetBooleanArrayOfCharacters(string s)
        {
            bool[] array = new bool[128];

            for(int i =0; i< s.Length; i++)
            {
                char c = s[i];
                //int offset = (int)'A';
                //int charPosition = (int)c - offset;
                array[c] = true;
            }
            return array;
        }
    }
}
