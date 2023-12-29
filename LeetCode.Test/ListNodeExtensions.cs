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
}

public static class TreeNodeExtensions
{
    public static TreeNode ToTree(this object[] values)
    {
        if (values.Length == 0) return null!;

        var root = BuildTree(values, 0);
        return root;
    }

    private static TreeNode BuildTree(object[] values, int index)
    {
        if (values.Length == 0 || index >= values.Length)
            return null!;

        var node = values[index] != null ? new TreeNode((int)values[index],
                                BuildTree(values, 2 * index + 1),
                                BuildTree(values, 2 * index + 2))
                                : null;
        return node!;
    }
}
