﻿namespace Algorithms.Leetcode.Easy
{
    /*
     Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
     You may assume that each input would have exactly one solution, and you may not use the same element twice.
     You can return the answer in any order.
     */
    public class _1_Two_Sum
    {
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {

                int number = target - nums[i];

                if (map.ContainsKey(number))
                {
                    return new[] { map[number], i };
                }
                map[nums[i]] = i;

            }
            return new int[] { };
        }
    }
}
