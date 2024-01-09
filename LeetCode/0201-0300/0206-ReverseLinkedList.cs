namespace LeetCode;

public class _0206_ReverseLinkedList
{
    public ListNode ReverseList(ListNode srcHead)
    {
        ListNode dstHead = null, srcNext, dstPrev;
        while (srcHead is not null)
        {
            dstPrev = dstHead;
            srcNext = srcHead.next;

            srcHead.next = dstPrev;
            dstHead = srcHead;
            srcHead = srcNext;
        }
        return dstHead;
    }
}
