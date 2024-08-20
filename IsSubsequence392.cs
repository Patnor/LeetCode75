using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode75
{
    internal class IsSubsequence392
    {
        public static bool IsSubsequence(string s, string t)
        {

            if (s == "")
                return true;
            if (t == "")
                return false;

            int patternCount = 0;

            for (int i = 0; i < t.Length; i++)
            {
                if (s[patternCount] == t[i])
                {
                    patternCount++;
                    if (patternCount == s.Length)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
