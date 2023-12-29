using System.Diagnostics;

namespace LeetCode.Test;
public class _1046_LastStoneWeight_Test
{
    [Theory]
    [InlineData(new [] {2,7,4,1,8,1}, 1)]
    [InlineData(new [] {1,8,9}, 0)]
    [InlineData(new [] {8,9}, 1)]
    [InlineData(new [] {9,10,1,7,3}, 2)]
    public void LastStoneWeight(int[] stones, int expected)
    {
// #if DEBUG
//         while (!Debugger.IsAttached) {Thread.Sleep(500);}
// #endif
        var sut = new _1046_LastStoneWeight();
        var actual = sut.LastStoneWeight(stones);
        Assert.Equal(expected, actual);
    }
}