namespace LeetCode.Test;

public class _1347_MinimumNumberOfStepsToMakeTwoStringsAnagram_Test
{
    [Theory]
    [InlineData("bab", "aba", 1)]
    [InlineData("leetcode", "practice", 5)]
    [InlineData("anagram", "mangaar", 0)]
    public void MinSteps(string s, string t, int expected)
    {
        var sut = new _1347_MinimumNumberOfStepsToMakeTwoStringsAnagram();
        var actual = sut.MinSteps(s, t);
        Assert.Equal(expected, actual);
    }
}
