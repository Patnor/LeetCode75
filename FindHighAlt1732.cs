using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode75
{
    internal class FindHighAlt1732
    {
        public static int LargestAltitude(int[] gain)
        {
            int maxAlt = 0;
            int[] prefixVals = new int[gain.Length +1];
            prefixVals[0] = 0;

            for(int i = 1; i <= gain.Length; i++)
            {
                prefixVals[i] = prefixVals[i - 1] + gain[i - 1];
                maxAlt = Math.Max(maxAlt, prefixVals[i]);
            }

            return maxAlt;
        }
    }
}
