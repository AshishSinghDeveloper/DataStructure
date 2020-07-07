using System;
using System.Collections.Generic;

//------------------------------------------------------------------------------------------------------------------------------------------------------
//Question: Longest Substring without repeating characters (Leetcode: Amazon Playlist)
//Given a string, find the length of the longest substring without repeating characters.

//Example 1:
//Input: "abcabcbb"
//Output: 3 
//Explanation: The answer is "abc", with the length of 3.

//Example 2:
//Input: "bbbbb"
//Output: 1
//Explanation: The answer is "b", with the length of 1.

//Example 3:
//Input: "pwwkew"
//Output: 3
//Explanation: The answer is "wke", with the length of 3. 
//             Note that the answer must be a substring, "pwke" is a subsequence and not a substring.
//------------------------------------------------------------------------------------------------------------------------------------------------------

namespace AmazonStack
{
    public class LongestSubStringWithRepeatingCharacter
    {
        //T: O(n) S: O(n), where n is length of string
        public int LengthOfLongestSubstring(String s) //this is sliding window concept
        {
            int n = s.Length;
            HashSet<char> set = new HashSet<char>();
            int ans = 0, i = 0, j = 0;
            while (i < n && j < n)
            {
                // try to extend the range [i, j]
                if (!set.Contains(s[j])) //if string char doesn't exists in set
                {
                    set.Add(s[j++]); //add string char and then increment j by 1.
                    ans = Math.Max(ans, j - i); //take max. 
                }
                else
                {
                    set.Remove(s[i++]); //if string char does exists in set then remove it and increment i by 1.
                }
            }
            return ans;
        }
        //T: O(n) S: O(n), where n is length of string
        public int LengthOfLongestSubstring_Attempt1(string s)
        {
            int stringLength = s.Length;
            int answer = 0;
            for (int i = 0; i < stringLength; i++)
            {
                for (int j = i + 1; j <= stringLength; j++)
                {
                    if (IsAllUnique(s, i, j))
                    {
                        answer = Math.Max(answer, j - i);
                    }
                }
            }
            return answer;
        }
        public bool IsAllUnique(string subString, int start, int end)
        {
            HashSet<char> AddValue = new HashSet<char>();
            for (int i = start; i < end; i++)
            {
                char c = subString[i];
                if (AddValue.Contains(c))
                {
                    return false;
                }
                else
                {
                    AddValue.Add(c);
                }
            }
            return true;
        }
    }
}
