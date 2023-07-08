// Link https://leetcode.com/problems/valid-palindrome-ii/
namespace LeetCode;

public class _0680_ValidPalindromeII
{
    public bool ValidPalindrome(string s) {
        int l = 0, r = s.Length - 1;

        if (SpinAndCheck(s, ref l, ref r))
            return true;
        else
        {
            int l1 = l + 1, r1 = r;
            int l2 = l, r2 = r - 1;
            if (SpinAndCheck(s, ref l1, ref r1) || SpinAndCheck(s, ref l2, ref r2))
                return true;
        }
        return false;
    }
    private bool SpinAndCheck(string s, ref int l, ref int r)
    {
        while (l < r)
        {
            if (s[l] != s[r])
            {
                return false;
            }                    
            l++; r--;
        }
        return true;
    }
}
