using System;
namespace LeetCode.Test;

public class _0026_RemoveDuplicatesFromSortedArray_Test
{
    [Theory]
    [InlineData(new[] { 1, 1, 2 }, 2)]
    [InlineData(new[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 }, 5)]
    public void RemoveDuplicates(int[] data, int expected)
    {
        var sut = new _0026_RemoveDuplicatesFromSortedArray();

        var actual = sut.RemoveDuplicates(data);

        Assert.Equal(expected, actual);
    }
}
