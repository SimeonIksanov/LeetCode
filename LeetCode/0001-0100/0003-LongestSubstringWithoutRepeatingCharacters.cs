// Link: https://leetcode.com/problems/longest-substring-without-repeating-characters/

using System;
using System.Collections.Generic;

namespace LeetCode;

public class _0003_LongestSubstringWithoutRepeatingCharacters
{
    private readonly Dictionary<char, int> _memory = new Dictionary<char, int>();
    public int LengthOfLongestSubstring(string inputString)
    {
        if (string.IsNullOrEmpty(inputString))
            return 0;

        int maxSubStringLength = 0, startPos = 0, currPos = 0;

        for (currPos = 0; currPos < inputString.Length; currPos++)
        {
            if (_memory.ContainsKey(inputString[currPos]) && _memory[inputString[currPos]] >= startPos)
            {
                maxSubStringLength = Math.Max(maxSubStringLength, (currPos - startPos));
                startPos = _memory[inputString[currPos]] + 1;
            }
            _memory[inputString[currPos]] = currPos;
        }
        maxSubStringLength = Math.Max(maxSubStringLength, (currPos - startPos));
        return maxSubStringLength;
    }
}
