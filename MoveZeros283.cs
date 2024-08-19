using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode75
{
    internal class MoveZeros283
    {

        public static void MoveZeros(int[] nums)
        {
            int reader = 0;
            int writer = 0;
            for(; reader < nums.Length; reader++)
            {
                if (nums[reader] != 0)
                {
                    nums[writer] = nums[reader];
                    writer++;
                }
                   
            }
            while(writer < nums.Length)
            {
                nums[writer++] = 0;
            }
        }


        public static void MoveZeroes2(int[] nums)
        {  
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {     
                    for (int j = i + 1; j < nums.Length; j++)
                    {
                        if (nums[j] != 0)
                        {
                            nums[i] = nums[j];
                            nums[j] = 0;
                            break;
                        }
                    }
                }
            }
        }
    }
}
