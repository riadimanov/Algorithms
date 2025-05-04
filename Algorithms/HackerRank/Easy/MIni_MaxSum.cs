namespace Algorithms.HackerRank.Easy
{
    /*
      Given five positive integers, find the minimum and maximum values that can be calculated by summing exactly four of the five integers. Then print the respective minimum and maximum values as a single line of two space-separated long integers.
      Print two space-separated integers on one line: the minimum sum and the maximum sum of  of  elements.No value should be returned.
        Note For some languages, like C, C++, and Java, the sums may require that you use a long integer due to their size.
  */
    internal class MIni_MaxSum
    {
        public static void miniMaxSum(List<int> b)

            {

                long totalsum = b.Sum(x => (long)x);


                long minsum = totalsum - b.Max();
                long maxsum = totalsum - b.Min();

                Console.WriteLine($"{minsum} {maxsum}");
            }

        }
    }