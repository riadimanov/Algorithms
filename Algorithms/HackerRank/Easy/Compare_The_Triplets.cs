namespace Algorithms.HackerRank.Easy
{

    /*
    Alice and Bob each created one problem for HackerRank. A reviewer rates the two challenges, awarding points on a scale from 1 to 100 for three categories: problem clarity, originality, and difficulty.

    The rating for Alice's challenge is the triplet a = (a[0], a[1], a[2]), and the rating for Bob's challenge is the triplet b = (b[0], b[1], b[2]).

    The task is to calculate their comparison points by comparing each category:

    If a[i] > b[i], then Alice is awarded 1 point.
    If a[i] < b[i], then Bob is awarded 1 point.
    If a[i] = b[i], then neither person receives a point.

    */


    internal class Compare_The_Triplets
    {
        public static List<int> compareTriplets(List<int> a, List<int> b)
        {
            int say_a = 0;
            int say_b = 0;

            for (int t = 0; t < 3; t++)
            {
                if (a[t] > b[t])
                {
                    say_a++;
                }
                else if (a[t] < b[t])
                {
                    say_b++;
                }
                else
                {
                    say_a = say_a + 0;
                    say_b = say_b + 0;
                }
            }

            return new List<int> { say_a, say_b };
        }

    }
}
