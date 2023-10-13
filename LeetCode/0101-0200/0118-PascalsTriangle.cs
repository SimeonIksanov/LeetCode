// Link: https://leetcode.com/problems/pascals-triangle/

namespace LeetCode;

public class _0118_PascalsTriangle
{
    public IList<IList<int>> Generate(int numRows)
    {
        var result = new List<IList<int>> { new List<int> { 1 } };
        for (int i = 2; i <= numRows; i++)
            result.Add(GenerateNextRow(result[result.Count - 1]));
        return result;
    }

    private IList<int> GenerateNextRow(IList<int> prevRow)
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
