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

        // an editorial version that uses ternary operator
        public static int LongestSubarray2(int[] nums)
        {
            // Number of zero's in the window.
            int zeroCount = 0;
            int longestWindow = 0;
            // Left end of the window.
            int start = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                zeroCount += (nums[i] == 0 ? 1 : 0);

                // Shrink the window until the zero counts come under the limit.
                while (zeroCount > 1)
                {
                    zeroCount -= (nums[start] == 0 ? 1 : 0);
                    start++;
                }

                longestWindow = Math.Max(longestWindow, i - start);
            }

            return longestWindow;
        }
    }



}
