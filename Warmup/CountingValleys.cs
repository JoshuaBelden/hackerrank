using System.Collections.Generic;
using System.Linq;

namespace hackerrank
{
    public partial class Solution
    {
        public static int CountingValleys(int steps, string path)
        {
            // We need an accumulator that reads the path forward and alerts every time
            // we dip below sea level and back up.

            return trackAltitude(path).Sum();

            IEnumerable<int> trackAltitude(string path)
            {
                int altitude = 0;

                foreach(var step in path)
                    yield return changeAltitude(step == 'U' ? altitude + 1 : altitude - 1);

                int changeAltitude(int newAltitude) {
                    var oldAltitude = altitude;
                    altitude = newAltitude;
                    return oldAltitude < 0 && newAltitude >= 0 ? 1 : 0;
                }
            }
        }
    }
}