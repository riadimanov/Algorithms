namespace Algorithms.Leetcode.Easy
{
    /*
     Given an integer n, return an array ans of length n + 1 such that for each i (0 <= i <= n), ans[i] is the number of 1's in the binary representation of i.
     */
    public class _338_Counting_Bits
    {
        public int[] CountBits(int n)
        {
            int[] result = new int[n + 1];
            for (int i = 0; i <= n; i++)
            {
                int res = 0;
                int x = i;
                while (x > 0)
                {
                    if (x % 2 == 1)
                    {
                        res += 1;
                    }
                    x = Convert.ToInt32(x / 2);
                }
                result[i] = res;
            }

            return result;
        }
    }
}
