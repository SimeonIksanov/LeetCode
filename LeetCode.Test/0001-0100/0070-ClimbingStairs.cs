namespace LeetCode.Test;

public class _0070_ClimbingStairs_Test
{
    [Theory]
    [InlineData(1, 1)]
    [InlineData(2, 2)]
    [InlineData(3, 3)]
    [InlineData(4, 5)]
    [InlineData(5, 8)]
    [InlineData(6, 13)]
    public void ClimbStairs(int num, int expected)
    {
        var sut = new _0070_ClimbingStairs();

        var actual = sut.ClimbStairs(num);

        Assert.Equal(expected, actual);
    }
}
