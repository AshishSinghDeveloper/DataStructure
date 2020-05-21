using System;
using System.Collections.Generic;

namespace AmazonStack
{
    public class LongestSubStringWithRepeatingCharacter
    {
        public LongestSubStringWithRepeatingCharacter()
        {
        }
        public int SlidingWindow(String s)
        {
            int n = s.Length;
            HashSet<char> set = new HashSet<char>();
            int ans = 0, i = 0, j = 0;
            while (i < n && j < n)
            {
                // try to extend the range [i, j]
                if (!set.Contains(s[j]))
                {
                    set.Add(s[j++]);
                    ans = Math.Max(ans, j - i);
                }
                else
                {
                    set.Remove(s[i++]);
                }
            }
            return ans;
        }
        public int LengthOfLongestSubstring(string s)
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
