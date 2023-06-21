namespace LeetCode.Test;

public class _0020_ValidParentheses_Test
{
    [Theory]
    [InlineData("()", true)]
    [InlineData("()[]{}", true)]
    [InlineData("(]", false)]
    public void IsValid(string data, bool expected)
    {
        var sut = new _0020_ValidParentheses();

        var actual = sut.IsValid(data);

        Assert.Equal(expected, actual);
    }
}

