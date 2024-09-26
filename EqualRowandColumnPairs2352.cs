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
            int count = 0;
            int len = grid.Length;


            Dictionary<string, int> rowCounts = [];
            foreach (int[] row in grid)
            {
                string rowString =  string.Join(", ", row) ;
                rowCounts[rowString] = 1 + (rowCounts.TryGetValue(rowString, out int rowCount) ? rowCount : 0);

            }


            for (int c = 0; c < len; c++)
            {
                int[] colArray = new int[len];
                for (int r = 0; r < len; ++r)
                {
                    colArray[r] = grid[r][c];
                }
                string colString = "[" + string.Join(", ", colArray) + "]";
                count += rowCounts.TryGetValue(colString, out int colCount) ? colCount : 0;
            }


            return count;
        }

        public static int EqualPairsTrie(int[][] grid)
        {


            return 0;
        }
    }
}
