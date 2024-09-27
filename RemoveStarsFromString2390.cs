using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode75
{
    internal class RemoveStarsFromString2390
    {

        public static string RemoveStars(string s)
        {
            int index = 0;

            if (!s.Contains('*'))
                return s;

            while(index < s.Length)
            {
                if (s.ElementAt(index) == '*')
                {
                    
                    s = s.Remove(index - 1, 2);
                    index -= 2;
                }
                index++;
            }

            return s;
        }

        public static string RemoveStarsStack(string s)
        {
            Stack<char> stack = new();

            foreach(char c in s)
            {
                if (c != '*')
                    stack.Push(c);
                else
                    stack.Pop();
            }

            return string.Join("",stack.ToArray().Reverse());
        }
    }
}
