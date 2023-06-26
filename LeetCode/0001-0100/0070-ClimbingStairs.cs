// Link https://leetcode.com/problems/climbing-stairs/

namespace LeetCode;

public class _0070_ClimbingStairs
{
    public int ClimbStairs(int n) {
        int retValue = 0;
        if (n == 1) return 1;

        int a = 1, b = 1;
        for (int i = 2; i <= n; i++)
        {
            retValue = a + b;
            a = b; 
            b = retValue;
        }
        return retValue;
    }
}
