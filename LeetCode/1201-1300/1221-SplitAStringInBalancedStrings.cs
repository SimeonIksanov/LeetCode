// Link: https://leetcode.com/problems/split-a-string-in-balanced-strings/

namespace LeetCode;

public class _1221_SplitAStringInBalancedStrings
{
    public int BalancedStringSplit(string s)
    {
        int balance = 0;
        int result = 0;
        foreach (char c in s)
        {
            balance += c == 'L' ? -1 : 1;

            if (balance == 0) result++;
        }

        return result;
    }
}