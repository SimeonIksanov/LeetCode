//Link https://leetcode.com/problems/remove-duplicates-from-sorted-list/

namespace LeetCode;

public class _0083_RemoveDuplicatesFromSortedList
{
    public ListNode DeleteDuplicates(ListNode head)
    {
        if (head == null) return null;
        
        ListNode myHead = head, retValue = head;
        int prev = head.val;
        head = head.next;
        
        while (head != null)
        {
            if (prev != head.val)
            {
                retValue.next = head;
                prev = head.val;
                retValue = retValue.next;
            }
            head = head.next;
        }

        if (retValue != null)
            retValue.next = null;
        return myHead;
    }
}
