namespace Algorithms.Leetcode.Easy
{
    /*
      Given an integer x, return true if x is a palindrome, and false otherwise.
     */
    public class _9_Palindrome_Number
    {
        public bool IsPalindrome(int x)
        {
            if (x < 0) return false;

            int temp = x;
            int sum = 0;

            while (temp != 0)
            {
                sum = sum * 10 + temp % 10;
                temp /= 10;
            }
            return sum == x;
        }
    }
}
