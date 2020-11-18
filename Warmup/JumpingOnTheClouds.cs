using System.Collections.Generic;
using System.Linq;

namespace hackerrank
{
    public partial class Solution
    {
        /*
        Emma is playing a new mobile game that starts with consecutively numbered clouds. Some of the clouds are 
        thunderheads and others are cumulus. She can jump on any cumulus cloud having a number that is equal to 
        the number of the current cloud plus 1 or 2. She must avoid the thunderheads. Determine the minimum number of 
        jumps it will take Emma to jump from her starting postion to the last cloud. It is always possible to win 
        the game.

        https://www.hackerrank.com/challenges/jumping-on-the-clouds/problem
        */
        public static int JumpingOnTheClouds(int[] clouds)
        {
            // Instead of looking ahead at possible jumps to make, I'm going to monitor what actions have been taken
            // already and track the number of jumps.

            var jumpedThunderhead = false;
            var jumpedCumulus = false;

            // Skip the first cloud, there's no action to take and it will never be a thundercloud.
            return clouds.Skip(1).Sum(cloud =>
            {
                // We just jumped a thunderhand, return 1 representing another jump.
                if (IsThunderhead(cloud))
                {
                    jumpedThunderhead = true;
                    return 1;
                }

                // We previously jumped a thunderhead, reset the tracking and don't record a jump.
                if (jumpedThunderhead)
                {
                    jumpedThunderhead = 
                        jumpedCumulus = false;
                    return 0;
                }

                // We just jumped a cumulus cloud, reverse the tracking and return wheather or not we jumped.
                // The fact that we can only jump a max of two allows me to use a boolean. This would
                // break if I could jump 3 or more cumulus clouds.
                jumpedCumulus = !jumpedCumulus;
                return jumpedCumulus ? 1 : 0;
            });
        }

        public static bool IsThunderhead(int cloud) => cloud == 1;
    }
}