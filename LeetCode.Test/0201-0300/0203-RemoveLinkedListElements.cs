namespace LeetCode.Test;

public class _0203_RemoveLinkedListElements_Test
{
    [Theory]
    [InlineData(new[] { 1, 2, 6, 3, 4, 5, 6 }, 6, new[] { 1, 2, 3, 4, 5 })]
    public void RemoveElements(int[] headArray, int val, int[] expectedArray)
    {
        var sut = new _0203_RemoveLinkedListElements();
        var actual = sut.RemoveElements(headArray.ToListNode(), val);
        Assert.Equal(expectedArray, actual.ToArray());
    }
}
