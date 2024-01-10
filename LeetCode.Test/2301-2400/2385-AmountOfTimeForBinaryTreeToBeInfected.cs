namespace LeetCode.Test;

public class _2385_AmountOfTimeForBinaryTreeToBeInfected_Test
{
    [Theory]
    [InlineData(new object[] { 1, 5, 3, null!, 4, 10, 6, null!, null!, 9, 2 }, 3, 4)]
    [InlineData(new object[] { 1 }, 1, 0)]
    public void AmountOfTime(object[] nums, int start, int expected)
    {
        var tree = nums.ToTreeNode();
        var sut = new _2385_AmountOfTimeForBinaryTreeToBeInfected();
        var actual = sut.AmountOfTime(tree, start);
        Assert.Equal(expected, actual);
    }
}
