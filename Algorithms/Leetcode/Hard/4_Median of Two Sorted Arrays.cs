namespace Algorithms.Leetcode.Hard
{
    /*
     Given two sorted arrays nums1 and nums2 of size m and n respectively, return the median of the two sorted arrays.
     The overall run time complexity should be O(log (m+n)).
     */
    public class _4_Median_of_Two_Sorted_Arrays
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int[] margeArray = new int[nums1.Length + nums2.Length];

            nums1.CopyTo(margeArray, 0);
            nums2.CopyTo(margeArray, nums1.Length);

            Array.Sort(margeArray);

            if (margeArray.Length % 2 != 0)
            {
                return margeArray[margeArray.Length / 2];
            }
            else
            {
                return Convert.ToDouble((margeArray[(margeArray.Length / 2) - 1] + margeArray[(margeArray.Length / 2)]) / 2.0);
            }

        }
    }
}
