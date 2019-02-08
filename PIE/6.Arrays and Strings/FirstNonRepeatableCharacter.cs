using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIE.ArraysandStrings
{
    public class FirstNonRepeatableCharacter
    {
        public static char? Find(string input, bool caseInsensitive)
        {
            if (input.Length < 1)
            {
                return null;
            }

            if (caseInsensitive)
            {
                input = input.ToLower();
            }

            Dictionary<char, int> characterCountHashTable = FirstNonRepeatableCharacter.GetCharacterCountHashTable(input);

            foreach (char key in characterCountHashTable.Keys)
            {
                if (characterCountHashTable[key] == 1)
                {
                    return key;
                }
            }
            return null;
        }

        private static Dictionary<char, int> GetCharacterCountHashTable(string input)
        {
            Dictionary<char, int> characterCountHashTable = new Dictionary<char, int>();

            foreach (char c in input)
            {
                if (characterCountHashTable.ContainsKey(c))
                {
                    int value;
                    if (characterCountHashTable.TryGetValue(c, out value))
                    {
                        characterCountHashTable[c] = value + 1;
                    }
                }
                else
                {
                    characterCountHashTable.Add(c, 1);
                }
            }
            return characterCountHashTable;
        }
    }
}
