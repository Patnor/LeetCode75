using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode75
{
    internal class MaxConsecOnes1004
    {
        public static int LongestOnes(int[] nums, int k)
        {
            int maxOnes = 0;
            int currentOnes = 0;
            int numZeros = k;
            int startIndex = 0;

            for(int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 1)
                {
                    currentOnes++;      
                }
                else if (numZeros > 0) 
                {
                    numZeros--; 
                    currentOnes++;                
                }
                else // reset
                {
                    maxOnes = Math.Max(currentOnes, maxOnes);

                    while (nums[startIndex] != 0)
                    {
                        startIndex++;
                        currentOnes--;
                    } 
                    startIndex++;
                }
            }
            maxOnes = Math.Max(currentOnes, maxOnes);
            return maxOnes;
        }
    }
}
