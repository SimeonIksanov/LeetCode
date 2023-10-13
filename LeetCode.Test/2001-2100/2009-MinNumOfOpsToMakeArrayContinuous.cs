using System.Diagnostics;

namespace LeetCode.Test;

public class _2009_Minimum_Number_of_Operations_to_Make_Array_Continuous_Test
{
    [Theory]
    [InlineData(new[] { 4, 2, 5, 3 }, 0)]
    [InlineData(new[] { 1, 2, 3, 5, 6 }, 1)]
    [InlineData(new[] { 1, 10, 100, 1000 }, 3)]
    public void TestMinOperations(int[] values, int expected)
    {
        // while (!Debugger.IsAttached)
        // {
        //     Thread.Sleep(100);
        // }
        var sut = new _2009_Minimum_Number_of_Operations_to_Make_Array_Continuous();
        var actual = sut.MinOperations(values);

        Assert.Equal(expected, actual);
    }
}
