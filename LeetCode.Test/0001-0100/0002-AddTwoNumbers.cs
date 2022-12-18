using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCode.Test;

public class _0002_AddTwoNumbers_Test
{
    [Fact]
    public void AddTwoNumbers_NotEmptyLinkedLists_ReturnsSum()
    {
        // Arrange
        var l1 = CreateLinkedListFromArray(new int[] { 2, 4, 3 });
        var l2 = CreateLinkedListFromArray(new int[] { 5, 6, 4 });
        var expected = CreateLinkedListFromArray(new int[] { 7, 0, 8 });
        var solution = new _0002_AddTwoNumbers();

        // Act
        var actual = solution.AddTwoNumbers(l1, l2);

        // Assert
        Assert.NotNull(actual);
        while (expected.next != null && actual.next != null)
        {
            Assert.Equal(expected.val, actual.val);
            expected = expected.next;
            actual = actual.next;
        }
        Assert.Null(expected.next);
        Assert.Null(actual.next);
    }

    private ListNode CreateLinkedListFromArray(int[] array)
    {
        if (array == null || array.Length == 0) return null;

        ListNode root = new ListNode(array[0]);
        ListNode last = root;

        foreach (int item in array.Skip(1))
        {
            last.next = new ListNode(item);
            last = last.next;
        }
        return root;
    }
}
