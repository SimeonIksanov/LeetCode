namespace LeetCode.Test;

public class _0013_RomanToInteger_Test
{
    [Theory]
    [InlineData("III", 3)]
    [InlineData("LVIII", 58)]
    [InlineData("MCMXCIV", 1994)]
    public void RomanToInt(string roman, int expected)
    {
        var sut = new _0013_RomanToInteger();

        var actual = sut.RomanToInt(roman);

        Assert.Equal(expected, actual);
    }
}

