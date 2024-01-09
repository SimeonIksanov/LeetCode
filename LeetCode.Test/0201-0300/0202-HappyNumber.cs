namespace LeetCode.Test;

public class _0202_HappyNumber_Test
{
    [Theory]
    [InlineData(2, false)]
    [InlineData(3, false)]
    [InlineData(4, false)]
    [InlineData(5, false)]
    [InlineData(6, false)]
    [InlineData(7, true)]
    [InlineData(8, false)]
    [InlineData(9, false)]
    [InlineData(19, true)]
    public void IsHappy(int n, bool expected)
    {
        var sut = new _0202_HappyNumber();
        var actual = sut.IsHappy(n);
        Assert.Equal(expected, actual);
    }
}
