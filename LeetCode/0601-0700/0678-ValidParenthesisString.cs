// Link: https://leetcode.com/problems/valid-parenthesis-string/

using System;

namespace LeetCode;

public class _0678_ValidParenthesisString
{
    public bool CheckValidString(string s)
    {
        var hackedS = HackString(s);
        int counter = Solve(hackedS, 0, 0);

        return counter == 0;
    }

    private string HackString(string s)
    {
        var indexClose = s.IndexOf(')');
        if (indexClose == -1) indexClose = int.MaxValue;
        var indexOpen = s.IndexOf('(');
        if (indexOpen == -1) indexOpen = int.MaxValue;
        var indexAsterisk = s.IndexOf('*');
        if (indexAsterisk == -1) indexAsterisk = int.MaxValue;
        if (indexOpen > indexAsterisk && indexOpen < indexClose)
        {
            var valueStringLength = s.Length - indexOpen;
            var doubledValueStringLength = valueStringLength * 2;
            if (s.Length > doubledValueStringLength)
            {
                return s.Substring(s.Length - doubledValueStringLength);
            }
        }
        return s;
    }

    private int Solve(string s, int index, int counter, int asteriskCount = 0)
    {
        if (counter < 0) return counter;

        for (int i = index; i < s.Length; i++)
        {
            if (s[i] == '(')
            {
                counter++;
            }
            else if (s[i] == ')')
            {
                counter--;
                if (counter < 0)
                {
                    return counter;
                }
            }
            else
            {
                asteriskCount++;
                if (Solve(s, i + 1, counter + 1, asteriskCount) == 0) // * == (
                    return 0;
                if (i >= asteriskCount && Solve(s, i + 1, counter - 1, asteriskCount) == 0) // * == )
                    return 0;
                if (Solve(s, i + 1, counter, asteriskCount) == 0 ) // * == ' '
                    return 0;

                return -1;
            }
        }
        if (asteriskCount == s.Length) return 0;

        return counter;
    }
}
