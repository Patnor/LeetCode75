using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode75
{
    internal class EqualRowandColumnPairs2352
    {
        public static int EqualPairsBrutForce(int[][] grid)
        {
            int count = 0, n = grid.Length;

            // check each row r against each column c
            for(int r = 0; r < n; ++r)
            {
                for(int c = 0; c < n; ++c)
                {
                    Boolean match = true;

                    for(int i = 0; i < n; i++)
                    {
                        if (grid[r][i] != grid[i][c])
                        {
                            match = false;
                            break;
                        }                
                    }
                    count += match ? 1 : 0;
                }
            }
            return count;
        }

        public static int EqualPairsHash(int[][] grid)
        {


            return 0;
        }

        public static int EqualPairsTrie(int[][] grid)
        {


            return 0;
        }
    }
}
