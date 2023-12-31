namespace LeetCode.Test;

public class _0171_ExcelSheetColumnNumber_Test
{
    [Theory]
    [InlineData("A", 1)]
    [InlineData("AB", 28)]
    [InlineData("AZ", 52)]
    [InlineData("ZY", 701)]
    [InlineData("AIC", 913)]
    public void TitleToNumber(string columnTitle, int expected)
    {
        var sut = new _0171_ExcelSheetColumnNumber();
        var actual = sut.TitleToNumber(columnTitle);
        Assert.Equal(expected, actual);
    }
}
