
namespace LeetCode;

public class _0160_IntersectionOfTwoLinkedLists
{
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
    {
        int a = GetLength(headA), b = GetLength(headB);
        ListNode shortList, longList;
        if (a > b)
        {
            longList = headA;
            shortList = headB;
            (a, b) = (b, a);
        }
        else
        {
            shortList = headA;
            longList = headB;
        }

        while (b-- > a)
            longList = longList.next;

        // now lengths are equal
        while (longList != shortList && longList is not null)
        {
            longList = longList.next;
            shortList = shortList.next;
        }
        return longList == shortList ? longList : null;
    }

    private int GetLength(ListNode head)
    {
        int counter = 0;
        while (head is not null)
        {
            head = head.next;
            counter++;
        }
        return counter;
    }
}
