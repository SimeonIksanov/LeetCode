using System.Diagnostics;

namespace LeetCode.Test;

public class _0420_StrongPasswordChecker_Test
{
    [Theory]
    [InlineData("a", 5)]
    [InlineData("aA1", 3)]
    [InlineData("1337C0d3", 0)]
    [InlineData("1aAzzz", 1)]
    [InlineData("aaa111", 2)]
    [InlineData("aaaaaa", 2)]
    [InlineData("12345678901234567890", 2)]
    [InlineData("bbaaaaaaaaaaaaaaacccccc", 8)]
    [InlineData("aaaB1", 1)]
    [InlineData("aaa123", 1)]
    [InlineData("ABABABABABABABABABAB1", 2)]
    [InlineData("FFFFFFFFFFFFFFF11111111111111111111AAA", 23)]
    public void StrongPasswordCheckerTest(string password, int expected)
    {
#if DEBUG
        // while (!Debugger.IsAttached) Thread.Sleep(500);
#endif
        var sut = new _0420_StrongPasswordChecker();
        var actual = sut.StrongPasswordChecker(password);
        Assert.Equal(expected, actual);
    }
}
