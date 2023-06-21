namespace LeetCode.Test;

public class _0009_PalindromeNumber_Test
{
    [Theory]
    [InlineData(121, true)]
    [InlineData(-121, false)]
    [InlineData(10, false)]
    public void IsPalindrome(int num, bool expected)
    {
        var sut = new _0009_PalindromeNumber();

        var actual = sut.IsPalindrome(num);

        Assert.Equal(expected, actual);
    }
}

