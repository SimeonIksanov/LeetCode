// Ling https://leetcode.com/problems/sqrtx/

namespace LeetCode;

public class _0069_Sqrt
{
    public int MySqrt(int x)
    {
        int left = 1, right = Math.Min(x / 2, 46_340);

        while (left < right)
        {
            int mid = (left + right) / 2;
            int square = mid * mid;
            if (square == x)
                return mid;
            if (square > x)
            {
                right = mid;
                continue;
            }

            if (square < x)
            {
                left = mid + 1;
            }
        }

        return left * left > x ? left - 1 : left;
    }
}
