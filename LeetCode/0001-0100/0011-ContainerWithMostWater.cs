namespace LeetCode;

public class _0011_ContainerWithMostWater
{
    public int MaxArea(int[] height)
    {
        int p1 = 0, p2 = height.Length - 1, total = 0;
        while (p1 < p2)
        {
            total = Math.Max(total, Math.Min(height[p1], height[p2]) * (p2 - p1));
            var d1 = height[p1] <= height[p2] ? 1 : 0;
            var d2 = height[p1] >= height[p2] ? 1 : 0;
            p1 += d1; p2 -= d2;
        }
        return total;
    }
}
