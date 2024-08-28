﻿using NUnit.Framework;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Xml.Linq;

namespace LeetCode75
{
    
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // get the digits of a number
            int number = 1354;

            // simplification
            //List<int> digits = new List<int>();
            //List<int> digits = new();
            List<int> digits = [];

            // Extract digits from the number
            while (number > 0)
            {
                int digit = number % 10; // Get the last digit
                digits.Add(digit);       // Add it to the list
                number /= 10;            // Remove the last digit from the number
            }
            digits.Reverse();
            digits.ForEach(Console.Write);

            Console.WriteLine();

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
             int[] nums = [ 1, 2, 3, 4 ];
            // int[] nums = {-1,1,0,-3,3};
            //int[] nums = { 1, -1 };
            //int[] nums = { 1, 1 };
            //int[] nums =[ 1, 1, 1, 1, -1, 1, 5, 1, -1, -1, -1, 1, -1, 1, -3, 1, 1, 1, 1, 1, 1, 1, -1, 1, -1, 1, 1, 5, -1, 1, -1, 1, 1, 3, -1, -5, -1, 1, -1, 1, -1, -3, 1, 2, -1, 1, -1, 1, -1, 1, 1, 1, 1, 1, -1, -1, -1, -3, -1, -1, 4, -1, 1, -1, 1, -1, -1, -1, -1, 3, 1, 4, -5, -1, 1, 1, 1, 1, 1, -4, 1, 1, -3, -1, -1, 1, 3, -1, 1, -2, 1, -1, 1, 1, 1, -1, 1, 1, 1, -1];
            //[349920000,349920000,349920000,349920000,-349920000,349920000,69984000,349920000,-349920000,-349920000,-349920000,349920000,-349920000,349920000,-116640000,349920000,349920000,349920000,349920000,349920000,349920000,349920000,-349920000,349920000,-349920000,349920000,349920000,69984000,-349920000,349920000,-349920000,349920000,349920000,116640000,-349920000,-69984000,-349920000,349920000,-349920000,349920000,-349920000,-116640000,349920000,174960000,-349920000,349920000,-349920000,349920000,-349920000,349920000,349920000,349920000,349920000,349920000,-349920000,-349920000,-349920000,-116640000,-349920000,-349920000,87480000,-349920000,349920000,-349920000,349920000,-349920000,-349920000,-349920000,-349920000,116640000,349920000,87480000,-69984000,-349920000,349920000,349920000,349920000,349920000,349920000,-87480000,349920000,349920000,-116640000,-349920000,-349920000,349920000,116640000,-349920000,349920000,-174960000,349920000,-349920000,349920000,349920000,349920000,-349920000,349920000,349920000,349920000,-349920000]
            //[349920000,349920000,349920000,349920000,-349920000,349920000,69984000,349920000,-349920000,-349920000,-349920000,349920000,-349920000,349920000,116640000,349920000,349920000,349920000,349920000,349920000,349920000,349920000,-349920000,349920000,-349920000,349920000,349920000,69984000,-349920000,349920000,-349920000,349920000,349920000,116640000,-349920000,69984000,-349920000,349920000,-349920000,349920000,-349920000,116640000,349920000,174960000,-349920000,349920000,-349920000,349920000,-349920000,349920000,349920000,349920000,349920000,349920000,-349920000,-349920000,-349920000,116640000,-349920000,-349920000,87480000,-349920000,349920000,-349920000,349920000,-349920000,-349920000,-349920000,-349920000,116640000,349920000,87480000,69984000,-349920000,349920000,349920000,349920000,349920000,349920000,87480000,349920000,349920000,116640000,-349920000,-349920000,349920000,116640000,-349920000,349920000,174960000,349920000,-349920000,349920000,349920000,349920000,-349920000,349920000,349920000,349920000,-349920000]
            
            int[] numsResult = ProductExceptSelf(nums);

            foreach (int num in numsResult)
                Console.Write(num + " ");

            Console.WriteLine();

            PrefixSumExample pse = new();
            int[] testNums = [4, 5, 1, 8, 2];
            int[] answers = pse.ProductExceptSelf238(testNums);

            foreach(int num in answers)
            {
                Console.Write(num + " ");
            }

            Console.WriteLine();
            answers = pse.ProductExceptSelf238_0_1_space(testNums);
            foreach(int num in answers)
            {
                Console.Write(num + " ");
            }

            //334.Increasing Triplet Subsequence
            //int[] numsTriplet = [1, 2, 3, 4, 5];
            //int[] numsTriplet = [5, 4, 3, 2, 1];
            //int[] numsTriplet = [2, 1, 5, 0, 4, 6];
            //int[] numsTriplet = [20, 100, 10, 12, 5, 13];
            //int[] numsTriplet = [1, 5, 0, 4, 1, 3];
            //int[] numsTriplet = [6, 7, 1, 2];
            //int[] numsTriplet = [2, 1, 5, 0, 3, 4];
            int[] numsTriplet = [5, 1, 5, 5, 2, 5, 4];


            Leetcode334 lt334 = new();
            Console.WriteLine();
            Console.WriteLine("334 = " + lt334.IncreasingTriplet(numsTriplet));

            // 443 string compresion
            //char[] charsCompress = ['a','a','b','b','c','c','c'];
            //char[] charsCompress = ['a'];
            char[] charsCompress = ['a', 'a', 'a', 'b', 'b', 'a', 'a'];
            //
            //
            //char[] charsCompress = ['a','b','b','b','b','b','b','b','b','b','b','b','b'];
            //StringCompression443 sc443 = new StringCompression443();

            int longestCount = StringCompression443.Compress2(charsCompress);
            Console.WriteLine("Count = " + longestCount);
            foreach(char ch in charsCompress)
            {
                Console.Write(ch + " ");
            }


            // 283 moving zeros
            Console.WriteLine();
            int[] numsMove = [0, 1, 0, 3, 12];

            MoveZeros283.MoveZeros(numsMove);
            foreach (int num in numsMove)
                Console.Write(num + " ");


            // 392 Is Subsequence
            // two pointers
            Console.WriteLine();
            //string s = "abc", t = "ahbgdc"; // true
            string s = "axc", t = "ahbgdc";  // false

            Console.Write(" Is sub = " + IsSubsequence392.IsSubsequence(s, t));

            Console.WriteLine();


            // Container with most water 11
            int[] height = [1, 8, 6, 2, 5, 4, 8, 3, 7];
            //int[] height = [1, 0, 0, 0, 0, 0, 0, 2, 2];
            //int[] height = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];



            int solution = ContainerWithMostWater11.MaxArea(height);
            Console.WriteLine("Area most water = " + solution);




            // 1679. Max Number of K-Sum Pairs
            //int[] nums1679 = [1, 2, 3, 4];
            //int k1679 = 5;

            int[] nums1679 = [3, 1, 3, 4, 3];
            int k1679 = 6;

            //int[] nums1679 = nums = [3, 1, 5, 1, 1, 1, 1, 1, 2, 2, 3, 2, 2];
            //int k1679 = 1;

            Console.WriteLine("1679 Max: " + MaxNumberofKSumPairs1679.MaxOperations(nums1679, k1679));


            // 643. maximum average subarray I
            // Input: nums = [1, 12, -5, -6, 50, 3], k = 4
            // Output: 12.75000
            // Explanation: Maximum average is (12 - 5 - 6 + 50) / 4 = 51 / 4 = 12.75

            int[] nums643 = [1, 12, -5, -6, 50, 3];
            int k643 = 4;

            //int[] nums643 = [5];
            //int k643 = 1;

            Console.WriteLine(MaximumAverageSubarray643.FindMaxAverage(nums643, k643));

            // 1456. Maximum Number of Vowels in a Substring of Given Length

            //Input: s = "abciiidef", k = 3
            //Output: 3
            //Explanation: The substring "iii" contains 3 vowel letters.


            string str1456 = "abciiidef";
            int k1456 = 3;

            //string str1456 = "aeiou";
            //int k1456 = 2;

            //string str1456 = "leetcode";
            //int k1456 = 3;

            Console.WriteLine("num vowels = " + MaxNumVowels1456.MaxVowels(str1456, k1456));


            //1004. Max Consecutive Ones III

            //        Input: nums = [1, 1, 1, 0, 0, 0, 1, 1, 1, 1, 0], k = 2
            //Output: 6
            //int[] nums1004 = [1, 1, 1, 0, 0, 0, 1, 1, 1, 1, 0];
            //int k1004 = 2;

            // 10
            //int[] nums1004 = [1, 0, 1, 1, 0, 0, 1, 1, 1, 0, 1, 1, 0, 0, 0, 1, 1, 1, 1];
            //int k1004 = 3;


            //int[] nums1004 = [1, 0, 1, 1, 0, 1, 0, 0, 1, 1, 0, 1, 1, 1, 1, 1, 0, 0, 1, 0, 1, 1, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 1, 0, 1, 1, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 1, 1, 0, 1, 0, 0, 0, 0, 1, 1, 1, 1, 0, 1, 1, 1, 1, 1, 0, 1, 1, 0, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 1, 1, 1, 1, 1, 0, 1, 1, 1, 0, 1, 1, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 1, 1, 1, 1, 1, 1, 0, 1, 0, 0, 0, 1, 1, 0, 1, 1, 1, 0, 1, 1, 0, 1, 1, 1, 0, 1, 0, 1, 0, 1, 1, 0, 0, 0, 0, 1, 0, 0, 0, 1, 1, 1, 1, 0, 1, 0, 0, 0, 1, 0, 1, 0, 1, 1, 1, 1, 1, 0, 1, 0, 1, 1, 1, 1, 0, 1, 1, 0, 0, 0, 1, 0, 0, 1, 1, 1, 1, 0, 1, 0, 0, 1, 1, 0, 1, 1, 0, 0, 1, 1, 1, 0, 1, 1, 0, 1, 1, 1, 0, 0, 1, 0, 0, 0, 1, 0, 0, 1, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 1, 1, 1, 1, 0, 1, 1, 0, 0, 0, 0, 1, 0, 1, 0, 0, 1, 1, 0, 0, 1, 0, 1, 0, 0, 1, 1, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 1, 1, 0, 0, 0, 0, 1, 1, 1, 0, 0, 1, 1, 1, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 1, 0, 1, 0, 1, 1, 0, 1, 0, 0, 1, 0, 1, 1, 0, 1, 0, 1, 1, 0, 1, 0, 1, 1, 0, 0, 1, 0, 0, 0, 1, 1, 0, 1, 1, 0, 0, 1, 0, 1, 1, 0, 1, 0, 1, 0, 1, 0, 1, 1, 1, 0, 0, 1, 1, 0, 1, 1, 0, 1, 1, 0, 0, 1, 1, 1, 1, 1, 1, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 1, 0, 1, 0, 1, 1, 0, 0, 1, 1, 0, 0, 1, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 1, 0, 1, 1, 0, 1, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 1, 0, 1, 1, 0, 1, 1, 0, 1, 0, 1, 1, 0, 1, 1, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 1, 0, 1, 1, 0, 1, 1, 0, 0, 1, 1, 0, 1, 0, 0, 1, 1, 1, 1, 1, 0, 1, 0, 0, 0, 0, 1, 0, 1, 0, 0, 1, 0, 1, 1, 0, 1, 0, 1, 1, 1, 1, 1, 0, 1, 0, 1, 1, 1, 0, 0, 1, 1, 0, 1, 1, 0, 1, 0, 0, 1, 0, 0, 1, 1, 0, 1, 0, 1, 1, 0, 1, 1, 1, 0, 1, 1, 1, 0, 0, 1, 1, 0, 0, 0, 0, 1, 0, 0, 1, 0, 1, 0, 1, 0, 0, 0, 1, 0, 1, 1, 1, 0, 0, 1, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 0, 1, 1, 0, 1, 1, 0, 1, 1, 1, 1, 0, 1, 1, 1, 0, 1, 1, 1, 0, 1, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 1, 1, 0, 1, 1, 0, 0, 0, 1, 0, 1, 0, 1, 0, 1, 1, 1, 0, 1, 0, 0, 1, 1, 1, 1, 0, 1, 1, 0, 1, 0, 1, 1, 0, 1, 1, 0, 1, 0, 0, 0, 1, 1, 1, 0, 0, 1, 1, 0, 1, 0, 1, 0, 0, 1, 1, 1, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 0, 1, 1, 1, 0, 0, 0, 1, 1, 0, 1, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 1, 0, 0, 1, 1, 1, 0, 0, 0, 1, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 1, 1, 0, 1, 1, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 1, 0, 0, 0, 0, 1, 1, 0, 1, 1, 1, 1, 0, 0, 1, 1, 1, 0, 0, 1, 0, 1, 1, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0, 1, 1, 1, 1, 1, 0, 1, 0, 0, 1, 1, 0, 1, 1, 1, 0, 1, 0, 0, 1, 0, 0, 1, 1, 0, 1, 0, 1, 0, 0, 1, 1, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0, 1, 1, 1, 1, 0, 1, 0, 1, 0, 0, 0, 1, 0, 1, 1, 0, 0, 0, 1, 0, 1, 0, 0, 1, 1, 0, 0, 1, 1, 1, 0, 1, 1, 0, 1, 0, 1, 1, 1, 0, 1, 0, 0, 1, 1, 1, 0, 1, 1, 1, 0, 1, 1, 0, 0, 0, 1, 0, 1, 0, 1, 1, 0, 1, 1, 1, 1, 1, 1, 0, 1, 0, 1, 0, 0, 0, 0, 1, 1, 0, 1, 0, 0, 0, 1, 0, 1, 1, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 1, 1, 0, 1, 0, 0, 0, 1, 1, 0, 0, 1, 1, 0, 1, 1, 0, 1, 1, 0, 1, 0, 1, 0, 1, 0, 0, 1, 1, 1, 0, 1, 1, 1, 1, 1, 0, 1, 0, 0, 0, 0, 0, 1, 0, 1, 0, 1, 0, 1, 1, 1, 1, 0, 0, 1, 0, 0, 1, 1, 0, 1, 0, 1, 0, 1, 1, 0, 1, 1, 0, 1, 1, 0, 0, 1, 0, 1, 0, 1, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 0, 1, 1, 1, 0, 1, 0, 0, 1, 1, 0, 1, 1, 0, 1, 1, 0, 1, 0, 1, 0, 1, 1, 0, 0, 1, 1, 0, 1, 1, 0, 1, 1, 1, 1, 1, 0, 1, 1, 1, 1, 0, 1, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 1, 0, 0, 0, 1, 0, 1, 1, 0, 0, 1, 1, 1, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 1, 0, 0, 1, 1, 0, 0, 1, 1, 1, 1, 0, 1, 1, 0, 1, 1, 0, 1, 0, 0, 1, 1, 0, 1, 1];
            //int k1004 = 225;





            //1493. Longest Subarray of 1's After Deleting One Element

            //            Example 1:

            int[] nums1493 = [1, 1, 0, 1];
            //Output: 3
            //Explanation: After deleting the number in position 2, [1, 1, 1] contains 3 numbers with value of 1's.

            //Example 2:

            //int[] nums1493 = [0, 1, 1, 1, 0, 1, 1, 0, 1];
            //Output: 5
            //Explanation: After deleting the number in position 4, [0, 1, 1, 1, 1, 1, 0, 1] longest subarray with value of 1's is [1,1,1,1,1].

            //Example 3:

            //int[] nums1493 = [1, 1, 1];
            //Output: 2
            //Explanation: You must delete one element.

            Console.WriteLine("Longest sub = " + LongestSub1493.LongestSubarray(nums1493));

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