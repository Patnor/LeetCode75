using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode75
{
    static class MaxNumberofKSumPairs1679
    {

        // create hashmap
        // iterate through list checking if k - value is in hashmap. 
        // if it is remove from hasmap, remove from array, increment output counter by 1
        public static int MaxOperations(int[] nums, int k)
        {
            List<int> list = new List<int>();
            int val;
            int count = 0;
         
            for(int i = 0; i < nums.Length; i++)
            {
                val = k - nums[i];
                if(list.Contains(val))
                {                 
                    list.Remove(val);
                   
                    count++;
                }
                else
                {
                    list.Add(nums[i]);
                }
            }
            nums = list.ToArray();
            return count;
        }
    }
}
