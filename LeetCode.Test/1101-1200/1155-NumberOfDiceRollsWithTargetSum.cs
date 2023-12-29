namespace LeetCode.Test;

public class _1155_NumberOfDiceRollsWithTargetSum_Test
{
    [Theory]
    [InlineData(1, 6, 3, 1)]
    [InlineData(2, 6, 7, 6)]
    [InlineData(30, 30, 500, 222616187)]
    public void NumRollsToTarget(int n, int k, int target, int expected)
    {
        // Arrange
        var solution = new _1155_NumberOfDiceRollsWithTargetSum();

        // Act
        var actual = solution.NumRollsToTarget(n, k, target);

        // Assert
        Assert.Equal(expected, actual);
    }
}
