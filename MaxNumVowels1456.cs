using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode75
{
    internal class MaxNumVowels1456
    {
        public static int MaxVowels(string s, int k)
        {

            int maxNumVowel = 0;
            int currentNumVowel = 0;
            char[] chars = s.ToCharArray();
            HashSet<char> hs = new() { 'a', 'e', 'i', 'o', 'u' };

            for(int i = 0; i < s.Length; i++)
            {     
                    if (hs.Contains(chars[i]))
                    {
                        currentNumVowel += 1;
                        maxNumVowel = Math.Max(maxNumVowel, currentNumVowel);
                        if (maxNumVowel == k)
                            return k;
    
                    }
                    if (i >= k - 1)
                    {
                        if (hs.Contains(chars[i - (k - 1)]))
                        {
                            currentNumVowel--;
                        }

                    }
            }
            return maxNumVowel;
        }
    }
}
