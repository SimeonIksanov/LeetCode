namespace LeetCode.Test;

public static class TreeNodeExtensions
{
    public static TreeNode ToTree(this object[] values)
    {
        if (values.Length == 0) return null!;

        var root = BuildTree(values, 0);
        return root;
    }

    public static object[] ToArray(this TreeNode root)
    {
        var list = new List<object>();
        if (root is null) return list.ToArray();
        ToArrayReqursive(root, list, 0);
        return list.ToArray();
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

    private static void ToArrayReqursive(TreeNode root, List<object> list, int index)
    {
        if (root is null) return;

        while (index >= list.Count)
            list.Add(null!);
        list[index] = root.val;
        ToArrayReqursive(root.left, list, index * 2 + 1);
        ToArrayReqursive(root.right, list, index * 2 + 2);
    }
}
