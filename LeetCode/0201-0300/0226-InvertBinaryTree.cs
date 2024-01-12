namespace LeetCode;

public class _0226_InvertBinaryTree
{
    public TreeNode InvertTree(TreeNode root)
    {
        if (root is null) return null;

        var t = root.left;
        root.left = root.right;
        root.right = t;
        InvertTree(root.left);
        InvertTree(root.right);

        return root;
    }
}
