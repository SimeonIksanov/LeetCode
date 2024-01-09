namespace LeetCode;

public class _0203_RemoveLinkedListElements
{
    public ListNode RemoveElements(ListNode head, int val)
    {
        var dummyHead = new ListNode(-1, head);
        ListNode cur = dummyHead.next, prev = dummyHead;
        while (cur is not null)
        {
            if (cur.val == val)
                prev.next = cur.next;
            else
            {
                prev = cur;
            }
            cur = cur.next;
        }
        return dummyHead.next;
    }
}
