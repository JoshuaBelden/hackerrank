using System;

namespace hackerrank
{
    class Program
    {
        static void Main()
        {
            var arg = new int[6][];
            arg[0] = new int[] { 1, 1, 1, 0, 0, 0, };
            arg[1] = new int[] { 0, 1, 0, 0, 0, 0, };
            arg[2] = new int[] { 1, 1, 1, 0, 0, 0, };
            arg[3] = new int[] { 0, 0, 2, 4, 4, 0, };
            arg[4] = new int[] { 0, 0, 0, 2, 0, 0, };
            arg[5] = new int[] { 0, 0, 1, 2, 4, 0, };
            var result = Solution.hourglassSum(arg);
            Console.WriteLine($"Result: {result}");
        }
    }
}