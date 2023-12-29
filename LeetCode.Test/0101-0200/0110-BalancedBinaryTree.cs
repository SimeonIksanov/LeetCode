namespace LeetCode.Test;

public class _0110_BalancedBinaryTree_Test
{
    [Theory]
    [InlineData(new object[] { 3, 9, 20, null!, null!, 15, 7 }, true)]
    [InlineData(new object[] { 1, 2, 2, 3, 3, null!, null!, 4, 4 }, false)]
    [InlineData(new object[] { 1, 2, 2, 3, null!, null!, 3, 4, null!, null!, 4 }, false)]
    [InlineData(new object[] { 1, 2, 3, 4, 5, 6, null!, 8 }, true)]
    [InlineData(new object[] { 1, 2, 3, 4, 5, null!, 6, 7, null!, null!, null!, null!, 8 }, true)]
    public void IsBalanced(object[] nums, bool expected)
    {
        var tree = nums.ToTree();
        var sut = new _0110_BalancedBinaryTree();

        var actual = sut.IsBalanced(tree);

        Assert.Equal(expected, actual);
    }
}
