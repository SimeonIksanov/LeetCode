// Link: https://leetcode.com/problems/number-of-dice-rolls-with-target-sum/

namespace LeetCode;

public class _1155_NumberOfDiceRollsWithTargetSum
{
    public int NumRollsToTarget(int N, int K, int target)
    {
        if (N * K < target || target < N || N < 1) return 0;

        int[] a = new int[target + 1], b = new int[target + 1], t;

        for (int i = 1; i <= K && i < a.Length; i++) a[i] = 1;

        for (int n = 2; n < N + 1; n++)
        {
            for (int i = 1; i < target + 1; i++)
                b[i] = 0 <= i && i < a.Length ? Sum(a, K, i) : 0;

            t = a;
            a = b;
            b = t;
        }

        return a[target];
    }
    private int Sum(int[] a, int K, int t)
    {
        long total = 0;
        for (int k = 1; k <= K; k++)
        {
            if (t - k <= 0) break;
            total += a[t - k];
        }
        return (int)(total % (int)(1E+9 + 7));
    }

}
