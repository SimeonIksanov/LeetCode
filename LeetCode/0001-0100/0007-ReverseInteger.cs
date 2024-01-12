namespace LeetCode;

public class _0007_ReverseInteger
{
    public int Reverse(int num)
    { //  -2147483648    2147483647
        int x = num, value = 0;
        int m = int.MaxValue / 10, r = int.MaxValue % 10;
        while (x != 0)
        {
            if (value > m || (value == m && Math.Abs(x % 10) > r)) return 0;
            value = value * 10 + Math.Abs(x % 10);
            x /= 10;
        }
        return int.CopySign(value, num);
    }
}
