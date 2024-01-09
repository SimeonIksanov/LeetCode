namespace LeetCode;

public class _0202_HappyNumber
{
    public bool IsHappy(int n)
    {
        var cache = new HashSet<int>();
        while (true)
        {
            n = SplitNumber(n).Select(x => x * x).Sum();
            if (n == 1) return true;
            if (cache.Contains(n))
                return false;
            cache.Add(n);
        }
    }

    private IEnumerable<int> SplitNumber(int n)
    {
        int r;
        while (n > 0)
        {
            (n, r) = int.DivRem(n, 10);
            yield return r;
        }
    }
}
