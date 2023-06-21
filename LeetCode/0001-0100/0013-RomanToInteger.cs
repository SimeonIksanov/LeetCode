// Link: https://leetcode.com/problems/roman-to-integer/

namespace LeetCode;

public class _0013_RomanToInteger
{
    private Dictionary<char, int> _dict = new Dictionary<char, int>{
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000},
        };

    public int RomanToInt(string s)
    {
        int retValue = 0;

        int index = 0;
        int prev = -1, cur = 0;
        while (index < s.Length)
        {
            prev = index == 0 ? -1 : cur;

            cur = _dict[s[index]];
            if (cur > prev && prev != -1)
            {
                retValue += (cur - prev) - prev;
            }
            else
            {
                retValue += cur;
            }

            index++;
        }

        return retValue;
    }
}

