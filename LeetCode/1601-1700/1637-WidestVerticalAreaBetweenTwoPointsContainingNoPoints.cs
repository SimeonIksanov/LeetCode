// Link: https://leetcode.com/problems/widest-vertical-area-between-two-points-containing-no-points/

namespace LeetCode;

public class _1637_WidestVerticalAreaBetweenTwoPointsContainingNoPoints
{
    public int MaxWidthOfVerticalArea(int[][] points)
    {
        var sortedPoints = points
            .Select(p => p[0])
            .Distinct()
            .OrderBy(x => x);

        if (sortedPoints.Count() == 1) return 0;
        var max = sortedPoints
            .Zip(sortedPoints.Skip(1), (f, s) => s - f)
            .Max();

        return max;
    }
}