namespace LeetCode;

public class _0111_MinimumDepthOfBinaryTree
{
    public int MinDepth(TreeNode root)
    {
        if (root is null) return 0;
        if (root.left is null && root.right is null) return 1;

        return root.left is null
            ? root.right is null
                ? 0
                : 1+MinDepth(root.right)
            : root.right is null
                ? 1+MinDepth(root.left)
                : Math.Min(1+MinDepth(root.left), 1+MinDepth(root.right));
    }
}
