using System.Diagnostics;

namespace LeetCode.Test;

public class _0844_BackspaceStringCompare_Test
{
    [Theory]
    [InlineData("ab#c", "ad#c", true)]
    [InlineData("ab##", "c#d#", true)]
    [InlineData("a#c", "b", false)]
    [InlineData("nzp#o#g", "b#nzp#o#g", true)]
    public void BackspaceCompareTest(string s, string t, bool expected)
    {
// #if DEBUG
//         while(!Debugger.IsAttached) Thread.Sleep(500);
// #endif
        var sut = new _0844_BackspaceStringCompare();
        var actual = sut.BackspaceCompare(s,t);
        Assert.Equal(expected, actual);
    }
}