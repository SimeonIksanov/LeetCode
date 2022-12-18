// Link: https://leetcode.com/problems/add-two-numbers/

namespace LeetCode;

public class _0002_AddTwoNumbers
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        ListNode resultHead = new ListNode();
        ListNode cur = resultHead;
        int carry = 0;
        while (l1 != null || l2 != null)
        {
            int sum = carry + (l1?.val ?? 0) + (l2?.val ?? 0);
            cur.next = new ListNode(sum % 10);
            cur = cur.next;
            carry = sum / 10;

            l1 = l1?.next;
            l2 = l2?.next;
        }
        if (carry == 1)
            cur.next = new ListNode(1);

        return resultHead.next;
    }
}
