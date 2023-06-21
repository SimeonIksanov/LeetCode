namespace LeetCode.Test;

public class _0014_LongestCommonPrefix_Test
{
    [Theory]
    [InlineData(new[] { "flower", "flow", "flight" }, "fl")]
    [InlineData(new[] { "dog", "racecar", "car" }, "")]
    public void LongestCommonPrefix(string[] data, string expected)
    {
        var sut = new _0014_LongestCommonPrefix();

        var actual = sut.LongestCommonPrefix(data);

        Assert.Equal(expected, actual);
    }
}

