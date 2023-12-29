using Microsoft.VisualBasic;

namespace LeetCode.Test;

public class _0141_LinkedListCycle_Test
{
    [Theory]
    [InlineData(new int[] { 3, 2, 0, -4 }, 1, true)]
    [InlineData(new int[] { 1, 2 }, 0, true)]
    [InlineData(new int[] { 1 }, -1, false)]
    [InlineData(new int[] { }, -1, false)]
    [InlineData(new int[] { 1, 2 }, -1, false)]
    public void HasCycle(int[] list, int pos, bool expected)
    {
        var listNode = list.ToListNode();
        SetupCycle(listNode, pos);

        var sut = new _0141_LinkedListCycle();
        var actual = sut.HasCycle(listNode);
        Assert.Equal(expected, actual);
    }

    private void SetupCycle(ListNode node, int pos)
    {
        if (node is null) return;
        int counter = 0;
        ListNode cycleStart = null!, prev = null!;
        while (node != null)
        {
            if (pos == counter)
                cycleStart = node;
            prev = node;
            node = node.next;
            counter++;
        }
        prev.next = cycleStart;
    }
}
