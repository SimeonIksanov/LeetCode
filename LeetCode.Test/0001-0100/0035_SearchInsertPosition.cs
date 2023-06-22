namespace LeetCode.Test;

public class _0035_SearchInsertPosition_Test
{
    [Theory]
    [InlineData(new[] { 1, 3, 5, 6 }, 5, 2)]
    [InlineData(new[] { 1, 3, 5, 6 }, 2, 1)]
    [InlineData(new[] { 1, 3, 5, 6 }, 7, 4)]
    public void RemoveDuplicates(int[] data, int val, int expected)
    {
        var sut = new _0035_SearchInsertPosition();

        var actual = sut.SearchInsert(data, val);

        Assert.Equal(expected, actual);
    }
}
