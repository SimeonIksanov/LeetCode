using System.Diagnostics;

namespace LeetCode.Test;

public class _0205_IsomorphicStrings_Test
{
    [Theory]
    [InlineData("egg", "add", true)]
    [InlineData("foo", "bar", false)]
    [InlineData("paper", "title", true)]
    [InlineData("badc", "baba", false)]
    public void IsIsomorphic(string s, string t, bool expected)
    {
        var sut = new _0205_IsomorphicStrings();
        var actual = sut.IsIsomorphic(s, t);
        Assert.Equal(expected, actual);
    }
}
