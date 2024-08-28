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

        // java version
        //public static int maxVowels2(String s, int k)
        //{
        //    Set<Character> vowels = Set.of('a', 'e', 'i', 'o', 'u');

        //    // Build the window of size k, count the number of vowels it contains.
        //    int count = 0;
        //    for (int i = 0; i < k; i++)
        //    {
        //        count += vowels.contains(s.charAt(i)) ? 1 : 0;
        //    }
        //    int answer = count;

        //    // Slide the window to the right, focus on the added character and the
        //    // removed character and update "count". Record the largest "count".
        //    for (int i = k; i < s.length(); i++)
        //    {
        //        count += vowels.contains(s.charAt(i)) ? 1 : 0;
        //        count -= vowels.contains(s.charAt(i - k)) ? 1 : 0;
        //        answer = Math.max(answer, count);
        //    }

        //    return answer;
        //}
    }
}
