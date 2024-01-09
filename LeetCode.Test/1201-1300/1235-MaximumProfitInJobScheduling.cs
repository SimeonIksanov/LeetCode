namespace LeetCode.Test;

public class _1235_MaximumProfitInJobScheduling_Test
{
    [Theory]
    [InlineData(new[] { 1, 2, 3, 3 }, new[] { 3, 4, 5, 6 }, new[] { 50, 10, 40, 70 }, 120)]
    [InlineData(new[] { 1, 2, 3, 4, 6 }, new[] { 3, 5, 10, 6, 9 }, new[] { 20, 20, 100, 70, 60 }, 150)]
    [InlineData(new[] { 1, 1, 1 }, new[] { 2, 3, 4 }, new[] { 5, 6, 4 }, 6)]
    public void JobScheduling(int[] startTime, int[] endTime, int[] profit, int expected)
    {
        // Arrange
        var solution = new _1235_MaximumProfitInJobScheduling();

        // Act
        var actual = solution.JobScheduling(startTime, endTime, profit);

        // Assert
        Assert.Equal(expected, actual);
    }
}
