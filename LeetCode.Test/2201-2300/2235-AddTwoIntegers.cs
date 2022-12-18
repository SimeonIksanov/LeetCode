namespace LeetCode.Test;

public class _2235_AddTwoIntegers_Test
{
    [Theory]
    [InlineData(17, 12, 5)]
    public void Sum(int expected, int a, int b)
    {
        // Arrange
        var solution = new _2235_AddTwoIntegers();

        //Act
        var actual = solution.Sum(a, b);

        //Assert
        Assert.Equal(expected, actual);
    }
}