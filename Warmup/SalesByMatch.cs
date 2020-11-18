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
        public static int SockMerchant(int numberOfSocks, int[] allSocks)
        {
            // Create a hash to store socks by color.
            var coloredSocks = new Dictionary<int, int>();

            foreach (var sockColor in allSocks)
            {
                if (coloredSocks.ContainsKey(sockColor))
                    coloredSocks[sockColor]++;
                else
                    coloredSocks.Add(sockColor, 1);
            }

            var totalPairs = 0;
            foreach (var sock in coloredSocks)
                totalPairs += sock.Value / 2; // relying on C#'s implicit integer handling to ignore the remainder.

            return totalPairs;
        }
    }
}