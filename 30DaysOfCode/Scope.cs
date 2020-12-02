using System;
using System.Collections.Generic;
using System.Linq;

namespace hackerrank
{
    class Difference
    {
        private int[] elements;
        public int maximumDifference;

        public Difference(int[] elements)
        {
            this.elements = elements;
        }

        public void computeDifference()
        {
            var min = this.elements.Min();
            var max = this.elements.Max();
            this.maximumDifference = max - min;
        }
    }
}
