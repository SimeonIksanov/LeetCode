namespace LeetCode.Test;

public class _0219_ContainsDuplicate2_Test
{
    [Theory]
    [InlineData(new[] { 1, 2, 3, 1 }, 3, true)]
    [InlineData(new[] { 1, 0, 1, 1 }, 1, true)]
    [InlineData(new[] { 1, 2, 3, 1, 2, 3 }, 2, false)]
    [InlineData(new[] { 1 }, 2, false)]
    [InlineData(new[] { 1, 2, 1 }, 0, false)]
    public void ContainsNearbyDuplicate(int[] nums, int k, bool expected)
    {
        var sut = new _0219_ContainsDuplicate2();
        var actual = sut.ContainsNearbyDuplicate(nums, k);
        Assert.Equal(expected, actual);
    }
}
