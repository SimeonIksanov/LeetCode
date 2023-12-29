namespace LeetCode;

public class _0141_LinkedListCycle
{
    public bool HasCycle(ListNode head) {
        if (head is null) return false;
        var slow = head;
        var fast = head.next;

        while (fast is not null && slow is not null && fast != slow)
        {
            fast = fast.next?.next ?? null;
            slow = slow.next;
        }

        return fast == slow;
    }
}
