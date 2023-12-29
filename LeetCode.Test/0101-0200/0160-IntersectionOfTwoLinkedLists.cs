namespace LeetCode.Test;

public class _0160_IntersectionOfTwoLinkedLists_Test
{
    [Theory]
    [InlineData(8, new[] { 4, 1, 8, 4, 5 }, new[] { 5, 6, 1, 8, 4, 5 }, 2, 3)]
    [InlineData(2, new[] { 1, 9, 1, 2, 4 }, new[] { 3, 2, 4 }, 3, 1)]
    [InlineData(0, new[] { 2, 6, 4 }, new[] { 1, 5 }, 3, 2)]
    public void GetIntersectionNode(
        int intersectVal,
        int[] arrayA,
        int[] arrayB,
        int skipA,
        int skipB)
    {
        // Arrange
        ListNode headA = arrayA.ToListNode();
        ListNode headB = arrayB.ToListNode();
        SetupListNodes(headA, headB, skipA, skipB, intersectVal);

        var sut = new _0160_IntersectionOfTwoLinkedLists();

        // Act
        var actual = sut.GetIntersectionNode(headA, headB);

        // Assert
        if (intersectVal == 0)
        {
            Assert.Null(actual);
        }
        else
        {
            while (skipB > 0)
            {
                headB = headB.next;
                skipB--;
            }
            Assert.Equal(headB, actual);
        }
    }

    private void SetupListNodes(
        ListNode headA,
        ListNode headB,
        int skipA,
        int skipB,
        int intersectVal)
    {
        if (intersectVal == 0) return;

        while (skipA-- > 1) { headA = headA.next; }
        while (skipB-- > 1) { headB = headB.next; }
        headA.next = headB.next;
    }
}
