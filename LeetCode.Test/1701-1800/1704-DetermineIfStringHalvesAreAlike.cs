namespace LeetCode.Test;

public class _1704_DetermineIfStringHalvesAreAlike_Test
{
    [Theory]
    [InlineData("book", true)]
    [InlineData("textbook", false)]
    public void HalvesAreAlike(string s, bool expected)
    {
        var sut = new _1704_DetermineIfStringHalvesAreAlike();
        bool actual = sut.HalvesAreAlike(s);
        Assert.Equal(expected, actual);
    }
}
