using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode75
{
    public class AsteriodCollision735
    {
        public static int[] AsteroidCollision(int[] asteroids)
        {
            Stack<int> stack = new();

            foreach(int num in asteroids)
            {
                if(stack.Count > 0)
                {
                    // check sign of top of stack
                    // if signs are the same push
                    // if signs are different compare
                    // and push bigger astroid on the stack

                    int temp = stack.Pop();

                    // check if the signs are the same.
                    if(temp * num > 0)
                    {
                        stack.Push(temp);
                        stack.Push(num);
                    }
                    else
                    {
                        if (Math.Abs(temp) > Math.Abs(num))
                            stack.Push(temp);
                        else
                        {
                            while (stack.Count > 0)
                            {
                                temp = stack.Pop();

                                if (Math.Abs(temp) > Math.Abs(num))
                                {
                                    stack.Push(temp);
                                    break;
                                }
                                else if (Math.Abs(temp) == Math.Abs(num))
                                    break;
                                else
                                {
                                    stack.Push(num);
                                }
                            }
                        }                 
                    }                             
                }
                else
                {
                    stack.Push(num);
                }
            }

            return stack.ToArray().Reverse().ToArray();
        }
    }
}
