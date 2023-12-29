namespace LeetCode.Test;

public class _0111_MinimumDepthOfBinaryTree_Test
{
    [Theory]
    [InlineData(new object[] { 3, 9, 20, null, null, 15, 7 }, 2)]
    [InlineData(new object[] { 2,null,3,null,null,null,4,null,null,null,null,null,null,null,5,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,6 }, 5)]
    public void MinDepth(object[] nums, int expected)
    {
        var tree = nums.ToTreeNode();
        var sut = new _0111_MinimumDepthOfBinaryTree();

        var actual = sut.MinDepth(tree);

        Assert.Equal(expected, actual);
    }
}
