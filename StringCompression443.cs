using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode75
{
    internal class StringCompression443
    {
       // two pointers

        // a better solution than the one I came up with
        public static int Compress2(char[] chars)
        {
            int i = 0, res = 0;

            while(i < chars.Length)
            {
                int groupLenth = 1;
                while(i + groupLenth < chars.Length && chars[i] == chars[i + groupLenth])
                {
                    groupLenth++;
                }

                chars[res++] = chars[i];
                if(groupLenth > 1)
                {
                    foreach(char c in groupLenth.ToString().ToCharArray())
                    {
                        chars[res++] = c;
                    }
                }
                i += groupLenth;
            }

            return res;
        }

        public static int Compress(char[] chars)
        {
            int len = chars.Length;

            if (len == 0)
                return 0; 

            int start = 0;
            int end = 1 ;
            int count = 1;
            int charLen = 0;
            char currentChar = chars[0];
            
            for(int i = 1; i <= len; i++)
            {
                if (end < len && chars[end] == currentChar)
                {
                    count++;
                    end++;
                }
                else
                {
                    chars[charLen] = currentChar;
                    charLen++;
                    // Extract digits from the number
                    List<int> digits = [];
                    int compute = count;
                    while (compute > 0)
                    {
                        int digit = compute % 10; // Get the last digit
                        digits.Add(digit);       // Add it to the list
                        compute /= 10;            // Remove the last digit from the number
                    }
                    digits.Reverse();
                    for(int j = 0; j<digits.Count && count > 1; j++)
                    {
                        chars[charLen] = digits[j].ToString()[0];                  
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
