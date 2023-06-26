namespace LeetCode.Test;

public class _0067_AddBinary_Test
{
    [Theory]
    [InlineData("11", "1", "100")]
    [InlineData("1010", "1011", "10101")]
    [InlineData("1000", "1", "1001")]
    [InlineData("1", "111", "1000")]
    public void AddBinary(string a, string b, string expected)
    {
        var sut = new _0067_AddBinary();

        var actual = sut.AddBinary(a, b);

        Assert.Equal(expected, actual);
    }
}
