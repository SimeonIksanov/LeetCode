namespace LeetCode.Test;

public class _0680_ValidPalindromeII_Test
{
    [Theory]
    [InlineData("aba", true)]
    [InlineData("abca", true)]
    [InlineData("abc", false)]
    public void ValidPalindrome(string s, bool expected)
    {
        var sut = new _0680_ValidPalindromeII();

        var actual = sut.ValidPalindrome(s);
        
        Assert.Equal(expected, actual);
    }
}
