namespace LeetCode.Test;

public class _0136_SingleNumber_Test
{
    [Theory]
    [InlineData(new[] { 2, 2, 1 }, 1)]
    [InlineData(new[] { 4,1,2,1,2 }, 4)]
    [InlineData(new[] { 1 }, 1)]
    public void IsPalindrome(int[] nums, int expected)
    {
        var sut = new _0136_SingleNumber();
        var actual = sut.SingleNumber(nums);
        Assert.Equal(expected, actual);
    }
}
