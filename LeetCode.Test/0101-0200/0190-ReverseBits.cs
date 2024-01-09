namespace LeetCode.Test;

public class _0190_ReverseBits_Test
{
    [Theory]
    [InlineData(43261596, 964176192)]
    [InlineData(4294967293, 3221225471)]
    public void ReverseBits(uint n, uint expected)
    {
        var sut = new _0190_ReverseBits();
        var actual = sut.ReverseBits(n);
        Assert.Equal(expected, actual);
    }
}
