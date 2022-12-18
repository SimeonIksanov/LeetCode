namespace LeetCode.Test;

public class _1637_WidestVerticalAreaBetweenTwoPointsContainingNoPoints_Test
{
    [Fact]
    public void Test1()
    {
        // Arrange
        var solution = new _1637_WidestVerticalAreaBetweenTwoPointsContainingNoPoints();

        // Act
        var actual = solution.MaxWidthOfVerticalArea(new int[][] { new int[] { 8, 7 }, new int[] { 9, 9 }, new int[] { 7, 4 }, new int[] { 9, 7 } });

        // Assert
        Assert.Equal(1, actual);
    }

    [Fact]
    public void Test2()
    {
        // Arrange
        var solution = new _1637_WidestVerticalAreaBetweenTwoPointsContainingNoPoints();

        // Act
        var actual = solution.MaxWidthOfVerticalArea(new int[][] { new int[] { 3, 1 }, new int[] { 9, 0 }, new int[] { 1, 0 }, new int[] { 1, 4 }, new int[] { 5, 3 }, new int[] { 8, 8 } });

        // Assert
        Assert.Equal(3, actual);
    }
}