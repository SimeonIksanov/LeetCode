namespace LeetCode;

public class _0222_CountCompleteTreeNodes
{
    public int CountNodes(TreeNode root)
    {
        var leftHeight = TreeHeight(root, x => x.left);
        var rightHeight = TreeHeight(root, x => x.right);

        if (leftHeight == rightHeight)
            return (int)Math.Pow(2, leftHeight) - 1;

        return 1 + CountNodes(root.left) + CountNodes(root.right);
    }

    private int TreeHeight(TreeNode root)
    {
        if (root is null) return 0;
        int total = 1;
        while (root is not null)
        {
            root = root.left;
            total++;
        }
        return total - 1;
    }

    private int TreeHeight(TreeNode root, Func<TreeNode, TreeNode> func)
    {
        if (root is null) return 0;
        int total = 1;
        while (root is not null)
        {
            root = func(root);
            total++;
        }
        return total - 1;
    }
}
