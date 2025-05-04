namespace Algorithms.Leetcode.Medium
{
    /*
     Given an unsorted array of integers nums, return the length of the longest consecutive elements sequence.
     You must write an algorithm that runs in O(n) time.
     */
    public class _128_Longest_Consecutive_Sequence
    {
        public int LongestConsecutive(int[] nums)
        {
            if (nums.Length == 0) return 0;

            var dict = new Dictionary<int, int>(); // Hər ədədin ardıcıllıq uzunluğunu saxlayırıq.
            int maxLength = 0;

            foreach (var num in nums)
            {
                if (dict.ContainsKey(num))
                    continue; // Əgər bu ədəd artıq varsa, onu yenidən işləməyə ehtiyac yoxdur.

                int left = dict.ContainsKey(num - 1) ? dict[num - 1] : 0; // Sol tərəfdəki ardıcıllıq uzunluğu
                int right = dict.ContainsKey(num + 1) ? dict[num + 1] : 0; // Sağ tərəfdəki ardıcıllıq uzunluğu
                int currentLength = left + right + 1; // Yeni ardıcıllıq uzunluğu

                dict[num] = currentLength; // Mövcud ədədin ardıcıllıq uzunluğunu təyin edirik.
                maxLength = Math.Max(maxLength, currentLength); // Ən uzun ardıcıllığı yeniləyirik.

                // Ardıcıllığın başlanğıc və son hissələrini yeniləyirik
                if (left > 0) dict[num - left] = currentLength;
                if (right > 0) dict[num + right] = currentLength;
            }

            return maxLength;
        }
    }
}
