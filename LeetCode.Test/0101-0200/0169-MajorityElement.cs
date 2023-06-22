namespace LeetCode.Test;

public class _0169_MajorityElement_Test
{
    [Theory]
    [InlineData(new[] { 3, 2, 3 }, 3)]
    [InlineData(new[] { 2, 2, 1, 1, 1, 2, 2 }, 2)]
    public void MajorityElement(int[] nums, int expected)
    {
        var sut = new _0169_MajorityElement();

        var actual = sut.MajorityElement(nums);

        Assert.Equal(expected, actual);
    }
}

