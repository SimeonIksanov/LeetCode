// Link: https://leetcode.com/problems/minimum-area-rectangle/

namespace LeetCode;

public class _0939_MinimumAreaRectangle
{
    public int MinAreaRect(int[][] points)
    {
        var hashSet = new HashSet<int>(points.Length);
        int minArea = int.MaxValue;
        foreach (var point in points)
            hashSet.Add(GetHash(point[0], point[1]));

        for (int i = 0; i < points.Length; i++)
            for (int j = i + 1; j < points.Length; j++)
                if (points[i][0] != points[j][0] && points[i][1] != points[j][1])
                    if (hashSet.Contains(GetHash(points[i][0], points[j][1])) && hashSet.Contains(GetHash(points[j][0], points[i][1])))
                        minArea = Math.Min(minArea, GetArea(points, i, j));
        return minArea < int.MaxValue ? minArea : 0;
    }

    private int GetArea(int[][] point, int i, int j)
        => Math.Abs(point[i][0] - point[j][0]) * Math.Abs(point[i][1] - point[j][1]);
    private int GetHash(int x, int y)
        => 391 * x + y;
}