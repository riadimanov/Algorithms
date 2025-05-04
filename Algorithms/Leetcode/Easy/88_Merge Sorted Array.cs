namespace Algorithms.Leetcode.Easy
{
    /*
     You are given two integer arrays nums1 and nums2, sorted in non-decreasing order, and two integers m and n, representing the number of elements in nums1 and nums2 respectively.
    Merge nums1 and nums2 into a single array sorted in non-decreasing order.
    The final sorted array should not be returned by the function, but instead be stored inside the array nums1. To accommodate this, nums1 has a length of m + n, where the first m elements denote the elements that should be merged, and the last n elements are set to 0 and should be ignored. nums2 has a length of n.
     */
    public class _88_Merge_Sorted_Array
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {

            int j = m - 1;
            int i = n - 1;
            int di = n + m - 1;

            while (j >= 0 && i >= 0)
            {
                if (nums1[j] <= nums2[i])
                {
                    nums1[di--] = nums2[i--];
                }

                else
                {
                    nums1[di--] = nums1[j--];
                }
            }
            while (i >= 0)
            {
                nums1[di--] = nums2[i--];
            }

        }
    }
}
