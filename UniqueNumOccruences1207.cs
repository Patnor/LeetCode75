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
            var dic = new Dictionary<int, int>();

            foreach (int num in arr)
            {
                if (dic.TryAdd(num, 1))
                {

                }
                else
                {
                    dic[num] += 1;
                }
            }
            var hs = dic.Values.ToHashSet();

            return hs.Count == dic.Count;
        }
    }
}
