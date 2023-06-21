// Link: https://leetcode.com/problems/palindrome-number/

namespace LeetCode;

public class _0009_PalindromeNumber
{
    public bool IsPalindrome(int x)
    {
        if (x < 0) return false;
        var reversed = Reverse(x);
        return x == reversed;
    }

    private int Reverse(int x)
    {
        int retValue = 0;
        while (x > 0)
        {
            retValue = retValue * 10 + x % 10;
            x /= 10;
        }
        return retValue;
    }
}

