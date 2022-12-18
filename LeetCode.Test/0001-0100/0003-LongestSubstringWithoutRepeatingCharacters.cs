namespace LeetCode.Test;

public class _0003_LongestSubstringWithoutRepeatingCharacters_Test
{
    [Theory]
    [InlineData(6, "abcdaef")]
    [InlineData(3, "abcabcbb")]
    [InlineData(1, "bbbbb")]
    [InlineData(3, "pwwkew")]
    public void LengthOfLongestSubstring(int expected, string inputString)
    {
        // Arrange
        var solution = new _0003_LongestSubstringWithoutRepeatingCharacters();

        // Act
        var actual = solution.LengthOfLongestSubstring(inputString);

        // Assert
        Assert.Equal(expected, actual);
    }
}