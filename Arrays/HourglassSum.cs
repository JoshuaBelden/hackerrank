using System;
using System.Collections.Generic;
using System.Linq;

namespace hackerrank
{
    public partial class Solution
    {
        public static int hourglassSum(int[][] arr)
        {
            var retVal = int.MinValue;

            for (var x = 0; x < 4; x++)
            for (var y = 0; y < 4; y++)
            {
                var sum = sumHourglass(arr, x, y);
                if (sum > retVal)
                    retVal = sum;
            }

           return retVal;
        }

        static int sumHourglass(int[][] arr, int x, int y)
        {
            return arr[x][y] + arr[x][y+1] + arr[x][y+2]
                            + arr[x+1][y+1]
            + arr[x+2][y] + arr[x+2][y+1] + arr[x+2][y+2];
        }
    }
}