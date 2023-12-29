namespace LeetCode;

public class _0110_BalancedBinaryTree
{
    private bool _isBalanced = true;
    public bool IsBalanced(TreeNode root)
    {
        Traverse(root);
        return _isBalanced;
    }

    private int Traverse(TreeNode root)
    {
        if (root is null) return 0;
        var left = Traverse(root.left);
        var right = Traverse(root.right);
        if (Math.Abs(left - right) > 1) _isBalanced = false;
        return 1 + Math.Max(left, right);
    }
}
