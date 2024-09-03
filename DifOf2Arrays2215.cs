using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode75
{
    internal class DifOf2Arrays2215
    {
        public static IList<IList<int>> FindDifference(int[] nums1, int[] nums2)
        {
            IList<IList<int>> result = new List<IList<int>>();

            HashSet<int> hs1 = nums1.ToHashSet();
            HashSet<int> hs2 = nums2.ToHashSet();

            Dictionary<int, int> myDict = new();

            foreach (int num in hs1)
            {
                myDict.Add(num, 1);
            }
            foreach (int num2 in hs2)
            {
                bool added = true;
                added = myDict.TryAdd(num2, 2);
                if (added == false)
                {
                    myDict.Remove(num2);
                }
            }

            result.Add(myDict.Where(pair => pair.Value == 1).Select(pair => pair.Key).ToList());
            result.Add(myDict.Where(pair => pair.Value == 2).Select(pair => pair.Key).ToList());

            return result;
        }
    }
}
