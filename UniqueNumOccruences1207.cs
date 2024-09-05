using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode75
{
    internal class UniqueNumOccruences1207
    {
        public static bool UniqueOccurrences(int[] arr)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();

            foreach(int num in arr)
            {
                if (dic.TryAdd(num, 0))
                {

                }
                else
                {
                    dic[num] += 1;
                }
            }
            HashSet<int> hs = dic.Values.ToHashSet();

            return hs.Count == dic.Count;
        }
    }
}
