namespace LeetCode.Test;

public class _0021_MergeTwoSortedLists_Test
{
    [Theory]
    [MemberData(nameof(GetTestData))]
    public void MergeTwoLists(_0021_MergeTwoSortedLists.ListNode list1,
                              _0021_MergeTwoSortedLists.ListNode list2,
                              _0021_MergeTwoSortedLists.ListNode expected)
    {
        var sut = new _0021_MergeTwoSortedLists();

        var actual = sut.MergeTwoLists(list1, list2);

        while(expected != null && actual != null)
        {
            Assert.Equal(expected.val, actual.val);
            expected = expected.next;
            actual = actual.next;
        }
        Assert.Equal(expected, actual);
    }

    public static IEnumerable<object[]> GetTestData()
    {
        _0021_MergeTwoSortedLists.ListNode list1, list2, expected;

        list1 = BuildListNode(1, 2, 4);
        list2 = BuildListNode(1, 3, 4);
        expected = BuildListNode(1, 1, 2, 3, 4, 4);

        yield return new object[] { list1, list2, expected };

        list1 = null;
        list2 = null;
        expected = null;
        yield return new object[] { list1, list2, expected };

        list1 = null;
        list2 = BuildListNode(0);
        expected = BuildListNode(0);
        yield return new object[] { list1, list2, expected };
    }

    private static _0021_MergeTwoSortedLists.ListNode BuildListNode(params int[] values)
    {
        var list = new _0021_MergeTwoSortedLists.ListNode(-1);
        var head = list;
        foreach (var value in values)
        {
            list.next = new _0021_MergeTwoSortedLists.ListNode(value);
            list = list.next;
        }
        return head.next;
    }
}

