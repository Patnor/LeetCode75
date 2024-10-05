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
                    int temp = stack.Pop();

                    if(temp < 0 || num > 0 )
                    {
                        stack.Push(temp);
                        stack.Push(num);
                    }
                    else
                    {
                        while (temp > 0)
                        {
                            if (Math.Abs(temp) == Math.Abs(num))
                                break;
                            else if( Math.Abs(num) > temp)
                            {
                                if(stack.Count() > 0)
                                {
                                    temp = stack.Pop();
                                    if(temp < 0)
                                    {
                                        stack.Push(temp);
                                        stack.Push(num);
                                        break;
                                    }
                                }                             
                                else
                                {
                                    stack.Push(num);
                                    break;
                                }
                            }
                            else
                            {
                                stack.Push(temp);
                                break;
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



/*
  else if(num > 0 && temp > 0)
                    {
                        stack.Push(temp);
                        stack.Push(num);
                    }                  
                    else if (Math.Abs(temp) > Math.Abs(num))
                    {
                        stack.Push(temp);
                    }                         
                    else
                    {
                        while (temp > 0 && stack.Count() > 0)
                        {
                           
                            

                            if (temp < 0)
                            {
                                stack.Push(temp);
                                stack.Push(num);
                            }
                            else if(Math.Abs(temp) == Math.Abs(num))
                            {
                                break;
                            }
                            else if (Math.Abs(temp) > Math.Abs(num))
                            {
                                stack.Push(temp);
                                break;
                            }
                            temp = stack.Pop();
                        }
                    }                 
 */