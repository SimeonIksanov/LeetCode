namespace LeetCode.Test;

public class _0125_ValidPalindrome_Test
{
    [Theory]
    [InlineData("A man, a plan, a canal: Panama", true)]
    [InlineData("race a car", false)]
    [InlineData(".,", true)]
    public void IsPalindrome(string s, bool expected)
    {
        var sut = new _0125_ValidPalindrome();

        var actual = sut.IsPalindrome(s);

        Assert.Equal(expected, actual);
    }
}
