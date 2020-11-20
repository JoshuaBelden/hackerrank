using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

namespace hackerrank
{
    public partial class Solution
    {
        /*
        Lilah has a string, s, of lowercase English letters that she repeated infinitely many times.
        Given an integer, n, find and print the number of letter a's in the first n letters of Lilah's infinite string.
        */
        public static long repeatedStrings(string pattern, long range)
        {
            /*
                Given that the range is a long and pattern is a string, actually building out a full string
                to simply count the letters is going to take too long. I need to actually calculate the value
                without building out a string.

                Given a pattern, how many blocks would I need to fill a range. Plus they'll be some remainder
                of letters that doesn't feel a full block
            */

            // Get the number of occurrences of A in the pattern
            var aCount = pattern.Sum(c => c == 'a' ? 1: 0);

            // Calculate the number of full blocks that can be used and the number of A's in those blocks.
            var blocks = range / pattern.Length;
            var asInBlocks = Math.Floor((decimal)blocks) * aCount;

            // If there's a remainder of the pattern to fill the range, calculate the number of A's in it.
            var remainder = range % pattern.Length;
            var asInRemainder = pattern.Substring(0, (int)remainder).Sum(c => c == 'a' ? 1 : 0);

            // Return all A's in the blocks and remainders.
            return (long)asInBlocks + asInRemainder;
        }
    }
}