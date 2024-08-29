using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode75
{
    internal class LongestSub1493
    {
        public static int LongestSubarray(int[] nums)
        {
            int maxCount = 0;
            int currentCount = 0;
            int startIndex = 0;
            int deleteIndex = -1;

            for(int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 1)
                {
                    currentCount++;
                }
                else
                {
                    if(deleteIndex == -1)
                    {
                        deleteIndex = i;
                    }
                    else
                    {
                        maxCount = Math.Max(currentCount, maxCount);
                        startIndex = deleteIndex + 1;
                        deleteIndex = i;
                        currentCount = i - startIndex;
                    }
                }
            }
            if(currentCount == nums.Length)
            {
                currentCount--;
            }
            return Math.Max(currentCount, maxCount);
        }
    }
}
