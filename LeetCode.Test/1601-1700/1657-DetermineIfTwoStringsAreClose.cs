namespace LeetCode.Test;

public class _1657_DetermineIfTwoStringsAreClose_Test
{
    [Theory]
    [InlineData("abc", "bca", true)]
    [InlineData("a", "aa", false)]
    [InlineData("cabbba", "abbccc", true)]
    [InlineData("uau", "ssx", false)]
    public void CloseStrings(string word1, string word2, bool expected)
    {
        var sut = new _1657_DetermineIfTwoStringsAreClose();
        var actual = sut.CloseStrings(word1, word2);
        Assert.Equal(expected, actual);
    }
}
