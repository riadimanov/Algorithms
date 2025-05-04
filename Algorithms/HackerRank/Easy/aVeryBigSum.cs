namespace Algorithms.HackerRank.Easy
{

    /*In this challenge, you need to calculate and print the sum of elements in an array, considering that some integers may be very large.
    Function Description:
    Complete the aVeryBigSum function with the following parameter(s):
    int arr [n] an array of integers
    Return long: the sum of the array elements
     */
    internal class aVeryBigSum
    {
        public static long AVeryBigSum(List<long> ar)
        {
            long sum = 0;
            for (int i = 0; i < ar.Count; i++)
            {
                sum += ar[i];

            }
            return sum;
        }

    }
}
