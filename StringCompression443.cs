using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode75
{
    internal class StringCompression443
    {
       // two pointers

        public int Compress(char[] chars)
        {
            int start = 0;
            int end = 1 ;
            int count = 1;
            int charLen = 0;
            char currentChar = chars[0];

            for(int i = 1; i <= chars.Length;i++)
            {
                if (end < chars.Length && chars[end] == currentChar)
                {
                    count++;
                    end++;
                }
                else
                {
                    charLen++;
                    // Extract digits from the number
                    List<int> digits = [];
                    while (count > 0)
                    {
                        int digit = count % 10; // Get the last digit
                        digits.Add(digit);       // Add it to the list
                        count /= 10;            // Remove the last digit from the number
                    }
                    digits.Reverse();
                    for(int j = 0; j<digits.Count; j++)
                    {
                        //chars[start + 1 + j] = (char)digits[j];
                        //int number = 3;
                        chars[start + 1 + j] = digits[j].ToString()[0];
                        //Console.WriteLine(charRepresentation); // Output: '3'

                        charLen++;
                    }
                    if(i < chars.Length)
                        currentChar = chars[i];
                    start = end;
                    end++;
                    count = 1;
                }
            }
            return charLen;
        }
    }
}
