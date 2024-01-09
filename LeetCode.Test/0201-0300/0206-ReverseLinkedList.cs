namespace LeetCode.Test;

public class _0206_ReverseLinkedList_Test
{
    [Theory]
    [InlineData(new[] { 1, 2, 3, 4, 5 }, new[] { 5, 4, 3, 2, 1 })]
    [InlineData(new[] { 1, 2 }, new[] { 2, 1 })]
    [InlineData(new int[0], new int[0])]
    public void ReverseList(int[] listAsArray, int[] expectedListAsArray)
    {
        var sut = new _0206_ReverseLinkedList();
        var actual = sut.ReverseList(listAsArray.ToListNode());
        Assert.Equal(expectedListAsArray, actual.ToArray());
    }
}
