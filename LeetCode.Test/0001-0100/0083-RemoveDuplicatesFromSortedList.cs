namespace LeetCode.Test;

public class _0083_RemoveDuplicatesFromSortedList_Test
{
    [Theory]
    [MemberData(nameof(TestDataProvider))]
    public void DeleteDublicates(ListNode head, ListNode expected)
    {
        var sut = new _0083_RemoveDuplicatesFromSortedList();

        var actual = sut.DeleteDuplicates(head);

        while(expected != null && actual != null)
        {
            Assert.Equal(expected.val, actual.val);
            expected = expected.next;
            actual = actual.next;
        }
        Assert.Equal(expected, actual);
    }

    public static IEnumerable<Object[]> TestDataProvider()
    {
        ListNode data, expected;
        
        data = new[] { 1, 1, 2 }.ToListNode();
        expected = new[] { 1, 2 }.ToListNode();
        yield return new object[] { data, expected };
        //
        data = new[] { 1,1,2,3,3 }.ToListNode();
        expected = new[] { 1, 2, 3 }.ToListNode();
        yield return new object[] { data, expected };
    }
}
