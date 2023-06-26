namespace LeetCode.Test;

public class _0071_SimplifyPath_Test
{
    [Theory]
    [InlineData("/home/", "/home")]
    [InlineData("/../", "/")]
    [InlineData("//home//foo/", "/home/foo")]
    [InlineData("//home//../foo/", "/foo")]
    public void SimplifyPath(string path, string expected)
    {
        var sut = new _0071_SimplifyPath();

        var actual = sut.SimplifyPath(path);

        Assert.Equal(expected, actual);
    }
}
