using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode75
{

    internal class ContainerWithMostWater11
    {

        // editorial solution

        public int MaxArea2(int[] height)
        {
            int maxArea = 0;
            int left = 0;
            int right = height.Length - 1;

            while (left < right)
            {
                int width = right - left;
                maxArea = Math.Max(maxArea,
                                   Math.Min(height[left], height[right]) * width);
                if (height[left] <= height[right])
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }

            return maxArea;
        }





        // my solution
        public static int MaxArea(int[] height)
        {
            int maxY = height.Max();
            int maxArea;

            int endIndex = height.Length - 1;
            int startIndex = 0;
            int currentArea = 0;
            int currentMaxArea = 0;
            int distance;

            while(startIndex < endIndex)
            {
                distance = endIndex - startIndex;
                maxArea = maxY * distance;
                if (currentMaxArea >= maxArea)
                    return currentMaxArea;

                if (height[startIndex] < height[endIndex])
                {
                    currentArea = height[startIndex] * distance;
                    if (currentArea > currentMaxArea)
                        currentMaxArea = currentArea;

                    startIndex++;
                }
                else
                {
                    currentArea = height[endIndex] * distance;
                    if (currentArea > currentMaxArea)
                        currentMaxArea = currentArea;
                    endIndex--;
                }
            }

            return currentMaxArea;
        }
    }
}


