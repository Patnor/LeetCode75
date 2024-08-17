using NUnit.Framework.Internal;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;

namespace LeetCode75
{
    internal class PrefixSumExample
    {
        //Algorithm
        //Initialize two empty arrays, L and R where for a given index i, L[i]
        //would contain the product of all the numbers to the left of i and R[i]
        //would contain the product of all the numbers to the right of i.

        //We would need two different loops to fill in values for the two arrays.
        //For the array L, L[0] would be 1 since there are no elements to the
        //left of the first element. For the rest of the elements, we simply
        //use L[i]= L[i−1]∗nums[i−1]. Remember that L[i] represents product of
        //all the elements to the left of element at index i.

        //For the other array, we do the same thing but in reverse i.e.we start
        //with the initial value of 1 in R[length−1] where length is the number
        //of elements in the array, and keep updating R[i] in reverse.Essentially,
        //R[i]= R[i + 1]∗nums[i + 1]. Remember that R[i] represents product of
        //all the elements to the right of element at index i.

        //    Once we have the two arrays set up properly, we simply iterate
        //    over the input array one element at a time, and for each element
        //    at index i, we find the product except self as L[i]∗R[i].


        //238. Product of Array Except Self

        public int[] ProductExceptSelf238(int[] nums)
        {
            int[] left = new int[nums.Length];
            int[] right = new int[nums.Length];
            int[] answer = new int[nums.Length];

            left[0] = 1;
            right[nums.Length - 1] = 1;

            // prefix sums
            for(int i = 1; i < nums.Length; i++)
            {
                left[i] = left[i - 1] * nums[i - 1];
            }

            // postfix sums
            for(int i = nums.Length-2; i >= 0; i--)
            {
                right[i] = right[i + 1] * nums[i + 1];
            }

            // answer
            for(int i = 0; i < nums.Length; i++)
            {
                answer[i] = left[i] * right[i];
            }

            return answer;
        }

        public int[] ProductExceptSelf238_0_1_space(int[] nums)
        {
            int[] answer = new int[nums.Length];
            answer[0] = 1;

            for(int i = 1; i < nums.Length; i++)
            {
                answer[i] = answer[i - 1] * nums[i - 1];
            }

            int postfix = 1;
            // start at length - 1 because we are using 
            // a variable to hold the postfix number
            for(int i = nums.Length -1; i >= 0; i--)
            {
                answer[i] = answer[i] * postfix;
                postfix *= nums[i];
            }

            return answer;
        }

    }




}
