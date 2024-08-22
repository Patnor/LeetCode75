using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode75
{
    internal class ContainerWithMostWater11
    {
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


//int maxY = height.Max();
//int maxArea;

//int endIndex = height.Length - 1;
//int startIndex = 0;
//int currentArea = 0;
//int currentMaxArea = 0;
////int distance;

//while (startIndex < endIndex)
//{
//    //distance = endIndex - startIndex;
//    maxArea = maxY * (endIndex - startIndex);
//    if (currentMaxArea >= maxArea)
//        return currentMaxArea;

//    currentArea = Math.Min(height[startIndex], height[endIndex]) * (endIndex - startIndex);
//    currentMaxArea = Math.Max(currentArea, currentMaxArea);


//    if (height[startIndex] < height[endIndex])
//        startIndex++;
//    else
//        endIndex--;



//    //if (height[startIndex] < height[endIndex])
//    //{
//    //    currentArea = height[startIndex] * distance;
//    //    if (currentArea > currentMaxArea)
//    //        currentMaxArea = currentArea;

//    //    startIndex++;
//    //}
//    //else
//    //{
//    //    currentArea = height[endIndex] * distance;
//    //    if (currentArea > currentMaxArea)
//    //        currentMaxArea = currentArea;
//    //    endIndex--;
//    //}
//}

//return currentMaxArea;