using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIE.ArraysandStrings
{
    public class ReverseWords
    {
        // This alone will work, but will need a string array buffer
        public static string WordReverse(string input)
        {
            string[] inputArray = input.Split(' ');
            int length = inputArray.Length - 1;
            for (int i = 0; i < inputArray.Length / 2; i++, length--)
            {
                string temp = inputArray[i];
                inputArray[i] = inputArray[length];
                inputArray[length] = temp;
            }
            return string.Join(" ",inputArray);
        }

    
        public static string WordReverseUsingReverse(string input)
        {
            string reversedString = ReverseWords.Reverse(input);
            string[] reversedStrArr = reversedString.Split(' ');
            StringBuilder sb = new StringBuilder();

           foreach(string word in reversedStrArr)
            {
              sb.Append(ReverseWords.Reverse(word) + " ");
            }
            return sb.ToString().Trim();
        }
        public static string Reverse(string input)
        {
            int length = input.Length - 1;
            char[] inputArr = input.ToCharArray();
            for (int i =0; i< input.Length/2; i++, length--)
            {
                char temp = inputArr[i];
                inputArr[i] = inputArr[length];
                inputArr[length] = temp;
            }
            return new string(inputArr);
        }
    }
}
