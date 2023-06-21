//Link https://leetcode.com/problems/merge-two-sorted-lists/

using static System.Net.Mime.MediaTypeNames;

namespace LeetCode;

public class _0021_MergeTwoSortedLists
{
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        ListNode head, tail, tmp = new ListNode(-1);
        head = tmp;
        tail = head;
        while (list1 != null && list2 != null)
        {
            if (list1.val > list2.val)
            {
                tail.next = list2;
                list2 = list2.next;
            }
            else
            {
                tail.next = list1;
                list1 = list1.next;
            }
            tail = tail.next;
        }

        tail.next = list1 != null ? list1 : list2;

        return head.next;
    }

    public class ListNode
    {
        public int val;
        public ListNode next;

        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
}

