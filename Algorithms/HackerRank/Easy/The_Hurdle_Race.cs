namespace Algorithms.HackerRank.Easy
{/*
    A video player plays a game in which the character competes in a hurdle race. Hurdles are of varying heights, and the characters have a maximum height they can jump. There is a magic potion they can take that will increase their maximum jump height by  unit for each dose. How many doses of the potion must the character take to be able to jump all of the hurdles. If the character can already clear all of the hurdles, return .

Example
    height=[1,2,3,3,3]
    k=1

The character can jump  unit high initially and must take  doses of potion to be able to jump all of the hurdles.
Function Description:
Complete the hurdleRace function in the editor below.
hurdleRace has the following parameter(s):
int k: the height the character can jump naturally
int height[n]: the heights of each hurdle
Returns
int: the minimum number of doses required, always 0 or more
  */
    internal class The_Hurdle_Race
    {
        public static int hurdleRace(int k, List<int> height)
        {

            int a = 0;



            int maxheight = 0;

            for (int i = 0; i < height.Count(); i++)
            {

                if (height[i] > maxheight)
                    maxheight = height[i];
            }

            if (k < maxheight)
            { a = maxheight - k; }

            else
            { a = 0; }

            return a;

        }

    }

}
