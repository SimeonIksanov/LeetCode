namespace LeetCode.Test;

public class _0007_ReverseInteger_Test
{
    [Theory]
    [InlineData(123, 321)]
    [InlineData(-123, -321)]
    [InlineData(120, 21)]
    [InlineData(1534236469, 0)]
    [InlineData(-2147483648, 0)]
    public void Reverse(int x, int expected)
    {
        var sut = new _0007_ReverseInteger();
        var actual = sut.Reverse(x);
        Assert.Equal(expected, actual);
    }
}
