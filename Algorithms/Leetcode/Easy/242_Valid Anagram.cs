﻿namespace Algorithms.Leetcode.Easy
{
    /*
      Given two strings s and t, return true if t is an anagram of s, and false otherwise.
     */
    public class _242_Valid_Anagram
    {
        public bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length)
                return false;

            Dictionary<char, int> dict1 = new Dictionary<char, int>();
            Dictionary<char, int> dict2 = new Dictionary<char, int>();

            for (int i = 0; i < s.Length; i++)
            {
                if (dict1.ContainsKey(s[i]))
                    dict1[s[i]]++;
                else
                    dict1[s[i]] = 1;

                if (dict2.ContainsKey(t[i]))
                    dict2[t[i]]++;
                else
                    dict2[t[i]] = 1;
            }

            return dict1.OrderBy(kv => kv.Key).SequenceEqual(dict2.OrderBy(kv => kv.Key));
        }

    }
}
