﻿namespace LeetCode75
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // 605. Can Place Flowers
            // int[] flowerbed = {1,0,0,0,1,1,0,0,0,1,1,1,1,1};
            // int[] flowerbed = {1,0,0,0,0,0,1};
            // int [] flowerbed = {1,0,1,0,1,0,1};
            // int[] flowerbed = { 1, 0, 0, 0, 1, 0, 0 };
            int[] flowerbed = [ 0, 0, 1, 0, 1 ];
            //int[] flowers = [2, 3, 4, 5];
            int n = 1;
            Console.WriteLine("flowers: " + CanPlaceFlowers(flowerbed, n));

            //238. Product of Array Except Self
             int[] nums = { 1, 2, 3, 4 };
            // int[] nums = {-1,1,0,-3,3};
            //int[] nums = { 1, -1 };
            //int[] nums = { 1, 1 };
            //int[] nums =[ 1, 1, 1, 1, -1, 1, 5, 1, -1, -1, -1, 1, -1, 1, -3, 1, 1, 1, 1, 1, 1, 1, -1, 1, -1, 1, 1, 5, -1, 1, -1, 1, 1, 3, -1, -5, -1, 1, -1, 1, -1, -3, 1, 2, -1, 1, -1, 1, -1, 1, 1, 1, 1, 1, -1, -1, -1, -3, -1, -1, 4, -1, 1, -1, 1, -1, -1, -1, -1, 3, 1, 4, -5, -1, 1, 1, 1, 1, 1, -4, 1, 1, -3, -1, -1, 1, 3, -1, 1, -2, 1, -1, 1, 1, 1, -1, 1, 1, 1, -1];
            //[349920000,349920000,349920000,349920000,-349920000,349920000,69984000,349920000,-349920000,-349920000,-349920000,349920000,-349920000,349920000,-116640000,349920000,349920000,349920000,349920000,349920000,349920000,349920000,-349920000,349920000,-349920000,349920000,349920000,69984000,-349920000,349920000,-349920000,349920000,349920000,116640000,-349920000,-69984000,-349920000,349920000,-349920000,349920000,-349920000,-116640000,349920000,174960000,-349920000,349920000,-349920000,349920000,-349920000,349920000,349920000,349920000,349920000,349920000,-349920000,-349920000,-349920000,-116640000,-349920000,-349920000,87480000,-349920000,349920000,-349920000,349920000,-349920000,-349920000,-349920000,-349920000,116640000,349920000,87480000,-69984000,-349920000,349920000,349920000,349920000,349920000,349920000,-87480000,349920000,349920000,-116640000,-349920000,-349920000,349920000,116640000,-349920000,349920000,-174960000,349920000,-349920000,349920000,349920000,349920000,-349920000,349920000,349920000,349920000,-349920000]
            //[349920000,349920000,349920000,349920000,-349920000,349920000,69984000,349920000,-349920000,-349920000,-349920000,349920000,-349920000,349920000,116640000,349920000,349920000,349920000,349920000,349920000,349920000,349920000,-349920000,349920000,-349920000,349920000,349920000,69984000,-349920000,349920000,-349920000,349920000,349920000,116640000,-349920000,69984000,-349920000,349920000,-349920000,349920000,-349920000,116640000,349920000,174960000,-349920000,349920000,-349920000,349920000,-349920000,349920000,349920000,349920000,349920000,349920000,-349920000,-349920000,-349920000,116640000,-349920000,-349920000,87480000,-349920000,349920000,-349920000,349920000,-349920000,-349920000,-349920000,-349920000,116640000,349920000,87480000,69984000,-349920000,349920000,349920000,349920000,349920000,349920000,87480000,349920000,349920000,116640000,-349920000,-349920000,349920000,116640000,-349920000,349920000,174960000,349920000,-349920000,349920000,349920000,349920000,-349920000,349920000,349920000,349920000,-349920000]
            
            int[] numsResult = ProductExceptSelf(nums);

            foreach (int num in numsResult)
                Console.Write(num + " ");

        }

        //238. Product of Array Except Self

        public static int[] ProductExceptSelf(int[] nums)
        {
            int[] resultArray = new int[nums.Length];
            int prefix = 1;
            for (int i = 0; i < nums.Length; i++)
            {
                resultArray[i] = prefix;
                prefix *= nums[i];

            }

            int postfix = 1;
            for (int i = nums.Length - 1; i > 0 ; i--)
            {
                postfix *= nums[i];
                resultArray[i-1] = resultArray[i - 1] * postfix;
            }

            return resultArray;
        }



        // flowerpot
        public static bool CanPlaceFlowers(int[] flowerbed, int n)
        {

            if (n == 0)
            {
                return true;
            }

            for (int i = 0; i < flowerbed.Length; i++)
            {
                if (flowerbed[i] == 0 && (i == 0 || flowerbed[i - 1] == 0)
                        && (i == flowerbed.Length - 1 || flowerbed[i + 1] == 0))
                {
                    flowerbed[i] = 1;
                    n--;
                    if (n == 0)
                        return true;
                }
            }

            return false;
        }
    }
}


/*
 * if(array[i] == 0 && ( i = 0 || array[i - 1] == 0) && (i == array.Length - 1 || array[i + 1] == 0)){
 *      condition is true so do what needs to be done
 * }
 * 
 * 
 */