using System.Linq;

namespace LeetCode.Test;

public class _0001_TwoSum_Test
{
    [Theory]
    [InlineData(new int[] { 2, 7, 11, 15 }, 9, new int[] { 0, 1 })]
    [InlineData(new int[] { 3, 2, 4 }, 6, new int[] { 1, 2 })]
    [InlineData(new int[] { 3, 3 }, 6, new int[] { 0, 1 })]
    [InlineData(new int[] { 1, 1, 1, 1, 1, 4, 1, 1, 1, 1, 1, 7, 1, 1, 1, 1, 1 }, 11, new int[] { 5, 11 })]
    public void TwoSum(int[] nums, int target, int[] expected)
    {
        // Arrange
        var solution = new _0001_TwoSum();

        // Act
        var actual = solution.TwoSum(nums, target);

        // Assert
        Assert.NotNull(actual);
        Assert.NotEmpty(actual);
        Assert.Equal(expected.Length, actual.Length);
        Assert.Equal(expected.Order(), actual.Order());
    }
}