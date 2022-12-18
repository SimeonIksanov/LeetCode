namespace LeetCode.Test;

public class _0939_MinimumAreaRectangle_Test
{
    [Fact]
    public void MinAreaRect_1()
    {
        // Arrange
        var solution = new _0939_MinimumAreaRectangle();

        // Act
        var actual = solution.MinAreaRect(new int[][] { new int[] { 1, 1 }, new int[] { 1, 3 }, new int[] { 3, 1 }, new int[] { 3, 3 }, new int[] { 2, 2 } });

        // Assert
        Assert.Equal(4, actual);
    }

    [Fact]
    public void MinAreaRect_2()
    {
        // Arrange
        var solution = new _0939_MinimumAreaRectangle();

        // Act
        var actual = solution.MinAreaRect(new int[][] { new int[] { 1, 1 }, new int[] { 1, 3 }, new int[] { 3, 1 }, new int[] { 3, 3 }, new int[] { 4, 1 }, new int[] { 4, 3 } });

        // Assert
        Assert.Equal(2, actual);
    }
}
