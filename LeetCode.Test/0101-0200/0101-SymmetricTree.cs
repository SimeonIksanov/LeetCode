using System.Diagnostics;
using System.Windows.Markup;

namespace LeetCode.Test;

public class _0101_SymmetricTree_Test
{
    [Theory]
    [InlineData(new object[] { 1, 2, 2, 3, 4, 4, 3 }, true)]
    [InlineData(new object[] { 1, 2, 2, 3, null, null, 3 }, true)]
    [InlineData(new object[] { 1, 2, 2, 2, null, 2 }, false)]
    public void IsSymmetricTree(object[] values, bool expected)
    {
        // while (!Debugger.IsAttached)
        // {
        //     Thread.Sleep(100);
        // }
        // int[] values = new[] { 1, 2, 2, 3, 4, 4, 3 };
        var root = values.ToTree();

        var t = new _0101_SymmetricTree();
        var actual = t.IsSymmetric(root);
        Assert.Equal(expected, actual);
    }
}
