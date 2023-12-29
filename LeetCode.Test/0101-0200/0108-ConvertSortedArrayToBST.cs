using System.Diagnostics;

namespace LeetCode.Test;

public class _0108_ConvertSortedArrayToBST_Test
{
    [Theory]
    [InlineData(new[]{1,3})]
    public void Test_SortedArrayToBST(int[]nums)
    {
#if DEBUG
        while (!Debugger.IsAttached) {Thread.Sleep(500);}
#endif
        var sut = new _0108_ConvertSortedArrayToBST();
        var actual = sut.SortedArrayToBST(nums);
        Assert.NotNull(actual);
    }
}