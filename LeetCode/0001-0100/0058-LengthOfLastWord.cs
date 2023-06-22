// Link https://leetcode.com/problems/length-of-last-word/

namespace LeetCode;

public class _0058_LengthOfLastWord
{
    public int LengthOfLastWord(string s)
    {
        var end = s.Length - 1;
        while (s[end] == ' ' && end > 0)
        {
            end--;
        }

        var start = end;
        while (start > 0 && s[start - 1] != ' ')
        {
            start--;
        }

        return end - start + 1;
    }
}
