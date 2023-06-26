namespace LeetCode.Test;

public class _0069_Sqrt_Test
{
    [Theory]
    [InlineData(4, 2)]
    [InlineData(8, 2)]
    [InlineData(9, 3)]
    [InlineData(10, 3)]
    [InlineData(11, 3)]
    [InlineData(12, 3)]
    [InlineData(13, 3)]
    [InlineData(14, 3)]
    [InlineData(15, 3)]
    [InlineData(16, 4)]
    [InlineData(121, 11)]
    [InlineData(122, 11)]
    [InlineData(2147395599, 46339)]
    public void MySqrt(int num, int expected)
    {
        var sut = new _0069_Sqrt();

        var actual = sut.MySqrt(num);

        Assert.Equal(expected, actual);
    }
}
