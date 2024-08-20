using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LeetCode75
{
    internal class IsSubsequence392
    {
        string source, target;
        int leftBound, rightBound;

        private bool rec_isSubsequence(int leftIndex, int rightIndex)
        {
            // base cases
            if (leftIndex == leftBound)
                return true;
            if (rightIndex == rightBound)
                return false;

            // consume both strings or just the target string
            if (source[leftIndex] == target[rightIndex])
                ++leftIndex;
            ++rightIndex;

            return rec_isSubsequence(leftIndex, rightIndex);
        }

        public bool IsSubsequenceRec(string s, string t)
        {
            this.source = s;
            this.target = t;
            this.leftBound = s.Length;
            this.rightBound = t.Length;

            return rec_isSubsequence(0, 0);
        }
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
