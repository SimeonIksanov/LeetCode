namespace LeetCode.Test;

public class _0011_ContainerWithMostWater_Test
{
    [Theory]
    [InlineData(new[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 }, 49)]
    [InlineData(new[] { 1, 1 }, 1)]
    public void MaxArea(int[] height, int expected)
    {
        var sut = new _0011_ContainerWithMostWater();
        var actual = sut.MaxArea(height);
        Assert.Equal(expected, actual);
    }
}
