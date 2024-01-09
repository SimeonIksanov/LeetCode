namespace LeetCode.Test;

public class _0222_CountCompleteTreeNodes_Test
{
    [Theory]
    [InlineData(new object[0], 0)]
    [InlineData(new object[] { 1 }, 1)]
    [InlineData(new object[] { 1, 2 }, 2)]
    [InlineData(new object[] { 1, 2, 3 }, 3)]
    [InlineData(new object[] { 1, 2, 3, 4 }, 4)]
    [InlineData(new object[] { 1, 2, 3, 4, 5 }, 5)]
    [InlineData(new object[] { 1, 2, 3, 4, 5, 6 }, 6)]
    public void CountNodes(object[] treeArray, int expected)
    {
        var sut = new _0222_CountCompleteTreeNodes();
        var actual = sut.CountNodes(treeArray.ToTree());
        Assert.Equal(expected, actual);
    }
}
