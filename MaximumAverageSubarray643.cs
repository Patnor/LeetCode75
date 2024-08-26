using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode75
{
    internal class MaximumAverageSubarray643
    {
        public static double FindMaxAverage(int[] nums, int k)
        {
            if (k < 0 || k > nums.Length)
                return 0.0;

            double  currentTotal = 0;
            double maxAve = Double.NegativeInfinity;
            
            for(int i = 0; i < nums.Length; i++)
            {
                currentTotal += nums[i];

                if(i >= k - 1)
                {
                    maxAve = Math.Max((currentTotal / k), maxAve);
                    currentTotal -= nums[i - (k - 1)];
                }
            }

            return maxAve;
        }
    }
}
