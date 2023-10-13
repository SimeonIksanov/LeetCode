// Link: https://leetcode.com/problems/symmetric-tree/

namespace LeetCode.Test;

public class _0101_SymmetricTree
{

    public bool IsSymmetric(TreeNode root)
        => IsMirror(root.left, root.right);

    private bool IsMirror(TreeNode p, TreeNode q)
    {
        return (p == null && q == null)
            || (p != null && q != null
                && p.val == q.val
                && IsMirror(p.left, q.right)
                && IsMirror(p.right, q.left));
    }
}
