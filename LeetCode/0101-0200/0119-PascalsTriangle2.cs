// Link: https://leetcode.com/problems/pascals-triangle-ii/

namespace LeetCode;
public class _0119_PascalsTriangle2
{
    public IList<int> GetRow(int rowIndex)
    {
        var result = new List<int> { 1 };
        for (int i = 2; i <= rowIndex + 1; i++)
            result = GenerateNextRow(result);
        return result;
    }

    private List<int> GenerateNextRow(List<int> prevRow)
    {
        int startIndex = 0, endIndex = prevRow.Count;
        var newRow = new List<int>(Enumerable.Repeat(0, prevRow.Count + 1));
        newRow[startIndex++] = 1; newRow[endIndex--] = 1;

        while (startIndex < endIndex)
        {
            var value = prevRow[startIndex - 1] + prevRow[startIndex];
            newRow[startIndex++] = value;
            newRow[endIndex--] = value;
        }
        if (startIndex == endIndex)
        {
            newRow[startIndex] = prevRow[startIndex - 1] + prevRow[startIndex];
        }
        return newRow;
    }
}
