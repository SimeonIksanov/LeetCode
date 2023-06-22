namespace LeetCode.Test;

public class _0058_LengthOfLastWord_Test
{
    [Theory]
    [InlineData("Hello World", 5)]
    [InlineData("   fly me   to   the moon  ", 4)]
    [InlineData("luffy is still joyboy", 6)]
    [InlineData("a", 1)]
    [InlineData(" a", 1)]
    public void LengthOfLastWord(string s, int expected)
    {
        var sut = new _0058_LengthOfLastWord();

        var actual = sut.LengthOfLastWord(s);

        Assert.Equal(expected, actual);
    }
}
