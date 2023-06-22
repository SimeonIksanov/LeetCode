namespace LeetCode.Test;

public class _0027_RemoveElement_Test
{
    [Theory]
    [InlineData(new[] { 3, 2, 2, 3 }, 3, 2)]
    [InlineData(new[] { 0, 1, 2, 2, 3, 0, 4, 2 }, 2, 5)]
    public void RemoveDuplicates(int[] data, int val, int expected)
    {
        var sut = new _0027_RemoveElement();

        var actual = sut.RemoveElement(data, val);

        Assert.Equal(expected, actual);
    }
}
