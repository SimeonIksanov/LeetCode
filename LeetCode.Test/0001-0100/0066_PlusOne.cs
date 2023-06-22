namespace LeetCode.Test;

public class _0066_PlusOne_Test
{
    [Theory]
    [InlineData(new[] { 1, 2, 3 }, new[] { 1, 2, 4 })]
    [InlineData(new[] { 4, 3, 2, 1 }, new[] { 4, 3, 2, 2 })]
    [InlineData(new[] { 9 }, new[] { 1, 0 })]
    [InlineData(new[] { 9, 9 }, new[] { 1, 0, 0 })]
    public void PlusOne(int[] digits, int[] expected)
    {
        var sut = new _0066_PlusOne();

        var actual = sut.PlusOne(digits);

        Assert.Equal(expected, actual);
    }
}
