namespace LeetCode.Test;

public class _1221_SplitAStringInBalancedStrings_Test
{
    [Theory]
    [InlineData("RLRRLLRLRL", 4)]
    [InlineData("RLRRRLLRLL", 2)]
    [InlineData("LLLLRRRR", 1)]
    public void BalancedStringSplit(string s, int expected)
    {
        // Arrange
        var solution = new _1221_SplitAStringInBalancedStrings();

        // Act
        var actual = solution.BalancedStringSplit(s);

        // Assert
        Assert.Equal(expected, actual);
    }
}
