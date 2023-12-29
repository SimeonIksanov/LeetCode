namespace LeetCode.Test;

public static class TreeNodeExtensions
{
    public static TreeNode? ToTreeNode(this object[] items, int index = 0)
    {
        if (items is null|| index >= items.Length || items[index] is null) return null;

        var node = new TreeNode((int)items[index])
        {
            left = items.ToTreeNode(index * 2 + 1),
            right = items.ToTreeNode(index * 2 + 2),
        };

        return node;
    }
}
