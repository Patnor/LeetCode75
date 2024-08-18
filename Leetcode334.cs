using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode75
{
    internal class Leetcode334
    {
       
        public bool IncreasingTriplet(int[] nums)
        {
            if (nums.Length < 3)
                return false;
            int firstNum = int.MaxValue;
            int secondNum = int.MaxValue;
            foreach (int num in nums)
            {
                if (num <= firstNum)
                    firstNum = num;
                else if (num <= secondNum)
                    secondNum = num;
                else return true;
            }
            return false;

            //for(int i = 0, j = 1, k = 2; j < nums.Length-1;)
            //{
            //    if (nums[i] < nums[j])
            //    {
            //        while (j < nums.Length - 1)
            //        {
            //            while (k < nums.Length)
            //            {
            //                if (nums[j] < nums[k] && nums[i] < nums[j])
            //                {
            //                    return true;
            //                }
            //                k++;
            //            }
            //            j++;
            //            k = j + 1;
            //        }
            //        i += 2;
            //        j = i + 1;
            //        k = j + 1;
            //    }
            //    else
            //    {
            //        j++;
            //        while(j < nums.Length - 1)
            //        {
            //            if (nums[i] < nums[j])
            //            {
            //                k = j + 1;
            //                while (j < nums.Length - 1)
            //                {
            //                    while (k < nums.Length)
            //                    {
            //                        if (nums[j] < nums[k] && nums[i] < nums[j])
            //                        {
            //                            return true;
            //                        }
            //                        k++;
            //                    }
            //                    j++;
            //                    k = j + 1;
            //                }
            //                i = j + 1;
            //                j = i + 1;
            //                k = j + 1;
            //            }
            //            j++;
            //        }
            //    }
            //}
            //return false;


            //for (int i = 0, j = 1, k = 2; k < nums.Length;)
            //{

            //    if (nums[i] < nums[j])
            //    {
            //        while(k < nums.Length)
            //        {    
            //            if (nums[j] < nums[k])
            //            {
            //                return true;
            //            }
            //            k++;
            //        }
            //        i += 2;
            //        j = i + 1;
            //        k = j + 1;         
            //    }
            //    else
            //    {
            //        while (j < nums.Length-1)
            //        {
            //            if (nums[i] < nums[j])
            //            {
            //                while (k < nums.Length)
            //                {
            //                    if (nums[j] < nums[k])
            //                    {
            //                        return true;
            //                    }
            //                    k++;
            //                }
            //                i += 2;
            //                j = i + 1;
            //                k = j + 1;
            //            }
            //            j++;
            //        }
            //        i = j;
            //        j = i + 1;
            //        k = j + 1;
            //    }

            //}
            //return false;

            //for (int i = 0; i < nums.Length - 2; i++)
            //{
            //    if (nums[i] < nums[i+1] && nums[i+1] < nums[i+2])
            //    {
            //        return true;
            //    }
            //}
            //return false;
        }
    }
}
