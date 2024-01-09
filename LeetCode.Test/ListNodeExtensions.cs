namespace LeetCode.Test;

public static class ListNodeExtensions
{
    public static ListNode ToListNode(this int[] values)
    {
        var list = new ListNode(-1);
        var head = list;
        foreach (var value in values)
        {
            list.next = new ListNode(value);
            list = list.next;
        }
        return head.next;
    }

    public static int[] ToArray(this ListNode list)
    {
        var listArray = new List<int>();
        while (list is not null)
        {
            listArray.Add(list.val);
            list = list.next;
        }
        return listArray.ToArray();
    }
}
