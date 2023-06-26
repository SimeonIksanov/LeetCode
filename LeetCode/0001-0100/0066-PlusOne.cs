// Link https://leetcode.com/problems/plus-one/

namespace LeetCode;

public class _0066_PlusOne
{
    public int[] PlusOne(int[] digits)
    {
        int tmp, rem = 1;
        int i = digits.Length;

        while (--i >= 0 && rem != 0)
        {
            tmp = digits[i] + rem;
            digits[i] = tmp % 10;
            rem = tmp / 10;
        }

        if (rem == 0)
            return digits;

        var newDigits = new int[digits.Length + 1];
        newDigits[0] = 1;
        return newDigits;
    }
}
