namespace LeetCode;

public class _0171_ExcelSheetColumnNumber
{
    const int len = 26;
    public int TitleToNumber(string columnTitle) => columnTitle
        .Select(c => CharToNumber(c))
        .Aggregate(0, (a, b) => a * len + b);

    private int CharToNumber(char c) => (int)c - 64;
}
