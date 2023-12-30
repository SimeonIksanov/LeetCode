using System.Linq;
using System.Text;

namespace LeetCode;

public class _0168_ExcelSheetColumnTitle
{
    private const int len = 26;
    public string ConvertToTitle(int columnNumber)
    {
        var sb = new List<char>();
        while (columnNumber-- > 0)
        {
            sb.Add(ConvertToChar(columnNumber));
            columnNumber = columnNumber / len;
        };
        return string.Join(string.Empty, sb.Reverse<char>());
    }

    private char ConvertToChar(int num) => (char)(65 + (num % len));
}
