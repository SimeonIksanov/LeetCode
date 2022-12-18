namespace LeetCode.Test;

public class _0004_MedianOfTwoSortedArrays_Test
{
    [Theory]
    [InlineData(1.5, new int[] { 1 }, new int[] { 2 })]
    [InlineData(1, new int[] { 1 }, new int[] { 1 })]
    [InlineData(2, new int[] { 1, 3 }, new int[] { 2 })]
    [InlineData(1, new int[] { 1, 1 }, new int[] { 1, 1 })]
    [InlineData(1, new int[] { 1, 2 }, new int[] { 1, 1 })]
    [InlineData(5, new int[] { 2, 5, 8, 9 }, new int[] { 1, 3, 6 })]
    public void FindMedianSortedArrays(double expected, int[] a, int[] b)
    {
        // Arrange
        var solution = new _0004_MedianOfTwoSortedArrays();

        // Act
        var actual = solution.FindMedianSortedArrays(a, b);

        // Assert
        Assert.Equal(expected, actual, 3);
    }

    [Theory]
    [InlineData(2, new int[0], new int[] { 2 })]
    [InlineData(2, new int[] { 2 }, new int[0])]
    [InlineData(2, new int[0], new int[] { 1, 2, 3 })]
    [InlineData(2, new int[] { 1, 2, 3 }, new int[0])]
    public void FindMedianSortedArrays_OneArrayEmpty(double expected, int[] a, int[] b)
    {
        // Arrange
        var solution = new _0004_MedianOfTwoSortedArrays();

        // Act
        var actual = solution.FindMedianSortedArrays(a, b);

        // Assert
        Assert.Equal(expected, actual, 3);
    }

    [Theory]
    [InlineData(2.5, new int[] { 1, 2 }, new int[] { 3, 4 })]
    [InlineData(3.5, new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 })]
    [InlineData(4, new int[] { 1, 2, 3 }, new int[] { 4, 5, 6, 7 })]
    [InlineData(6, new int[] { 1, 2, 3 }, new int[] { 4, 5, 6, 7, 8, 9, 10, 11 })]
    [InlineData(6.5, new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 3 }, new int[] { 5, 6, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7 })]
    public void FindMedianSortedArrays_FirstArrayOnLeft(double expected, int[] a, int[] b)
    {
        // Arrange
        var solution = new _0004_MedianOfTwoSortedArrays();

        // Act
        var actual = solution.FindMedianSortedArrays(a, b);

        // Assert
        Assert.Equal(expected, actual, 3);
    }

    [Theory]
    [InlineData(9, new int[] { 13, 14, 15 }, new int[] { 4, 5, 6, 7, 8, 9, 10, 11 })]
    public void FindMedianSortedArrays_FirstArrayOnRight(double expected, int[] a, int[] b)
    {
        // Arrange
        var solution = new _0004_MedianOfTwoSortedArrays();

        // Act
        var actual = solution.FindMedianSortedArrays(a, b);

        // Assert
        Assert.Equal(expected, actual, 3);
    }

}