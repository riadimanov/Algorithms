namespace Algorithms.Leetcode.Easy
{
    /*
     Given an integer array nums, return true if any value appears at least twice in the array, and return false if every element is distinct.
     */
    public class _217_Contains_Duplicate
    {
        public bool ContainsDuplicate(int[] nums)
        {
            return new HashSet<int>(nums).Count != nums.Length;
        }
    }
}
