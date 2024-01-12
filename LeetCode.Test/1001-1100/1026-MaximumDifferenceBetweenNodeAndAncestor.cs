namespace LeetCode.Test;

public class _1026_MaximumDifferenceBetweenNodeAndAncestor_Test
{
    [Theory]
    [InlineData(new object[] { 8, 3, 10, 1, 6, null!, 14, null!, null!, 4, 7, null!, null!, 13 }, 7)]
    [InlineData(new object[] { 1, null!, 2, null!, null!, null!, 0, null!, null!, null!, null!, null!, null!, null!, 3 }, 3)]
    [InlineData(new object[] { 1, 1, 3, 4, 5, 6, 7 }, 6)]
    public void MaxAncestorDiff(object[] nums, int expected)
    {
        var sut = new _1026_MaximumDifferenceBetweenNodeAndAncestor();
        var actual = sut.MaxAncestorDiff(nums.ToTree());
        Assert.Equal(expected, actual);
    }
}
