
namespace LeetCode.Test;

public class _0145_BinaryTreePostorderTraversal_Test
{
    [Theory]
    [InlineData(new object[] { 1, 2, 3 }, new[] { 2, 3, 1 })]
    [InlineData(new object[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 }, new[] { 8, 9, 4, 10, 11, 5, 2, 12, 13, 6, 14, 15, 7, 3, 1 })]
    public void PostorderTraversal(object[] nums, int[] expected)
    {
        var treeNode = nums.ToTree();

        var sut = new _0145_BinaryTreePostorderTraversal();
        var actual = sut.PostorderTraversal(treeNode);
        Assert.Equal(expected, actual);
    }
}
