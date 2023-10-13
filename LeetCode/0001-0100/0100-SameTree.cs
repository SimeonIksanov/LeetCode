// Link: https://leetcode.com/problems/same-tree/

namespace LeetCode;

public class _0100_SameTree
{
    public bool IsSameTree(TreeNode p, TreeNode q)
    {
        return (p == null && q == null)
            || (p != null && q != null && p.val == q.val
                && IsSameTree(p.left, q.left)
                && IsSameTree(p.right, q.right));
    }
}
