namespace LeetCode;

public class _0125_ValidPalindrome
{
    public bool IsPalindrome(string s) {
        int i = 0, j = s.Length - 1;
        while (i<j)
        {
            while (i < s.Length && !char.IsLetterOrDigit(s[i])) i++;
            while (j >= 0 && !char.IsLetterOrDigit(s[j])) j--;
            if (i>=s.Length || j<0)
                break;
            if (char.ToLower(s[i]) != char.ToLower(s[j]))
                return false;

            i++; j--;
        }
        return true;
    }
}
