namespace LeetCode.Test;

public class _0226_InvertBinaryTree_Test
{
    [Theory]
    [InlineData(new object[] { 4, 2, 7, 1, 3, 6, 9 }, new object[] { 4, 7, 2, 9, 6, 3, 1 })]
    [InlineData(new object[] { 2, 1, 3 }, new object[] { 2, 3, 1 })]
    [InlineData(new object[] { 1, 2, null! }, new object[] { 1, null!, 2 })]
    [InlineData(new object[0], new object[0])]
    public void InvertTree(object[] nums, object[] expected)
    {
        var sut = new _0226_InvertBinaryTree();
        var actual = sut.InvertTree(nums.ToTree());
        Assert.Equal(expected, actual.ToArray());
    }
}
