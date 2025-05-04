namespace Algorithms.HackerRank.Easy
{
    /*
       You are choreographing a circus show with various animals. For one act, you are given two kangaroos on a number line ready to jump in the positive direction (i.e, toward positive infinity).
        The first kangaroo starts at location 𝑥1 and moves at a rate of 𝑣1 meters per jump.
        The second kangaroo starts at location 𝑥2 and moves at a rate of 𝑣2 meters per jump.
        You have to figure out a way to get both kangaroos at the same location at the same time as part of the show. If it is possible, return YES, otherwise return NO.
    */
    internal class Number_Line_Jumps
    {
        public static string kangaroo(int x1, int v1, int x2, int v2)
        {


            int maxaddim = 10000;
            bool netice = false;


            for (int i = 1; i < maxaddim; i++)
            {
                int a = x1 + v1 * i;
                int b = x2 + v2 * i;

                if (a == b)
                {
                    netice = true;
                    break;
                }

            }

            if (netice)
            {
                return "YES";
            }
            else
            {
                return "NO";
            }

        }
    }

}
