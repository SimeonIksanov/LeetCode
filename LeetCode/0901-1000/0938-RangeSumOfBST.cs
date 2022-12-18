// Link: https://leetcode.com/problems/range-sum-of-bst/

namespace LeetCode;

public class _0938_RangeSumOfBST_Queue
{
    private readonly Queue<TreeNode> _queue = new();

    public int RangeSumBST(TreeNode root, int low, int high)
    {
        if (root is null) return 0;
        int rangeSum = 0;

        _queue.Enqueue(root);

        while (_queue.Count > 0)
        {
            TreeNode node = _queue.Dequeue();
            if (IsInRange(node.val, low, high))
            {
                rangeSum += node.val;
            }
            EnqueueChildNodes(node, low, high);
        }

        return rangeSum;
    }

    private static bool IsInRange(int value, int low, int high)
        => low <= value && value <= high;

    private void EnqueueChildNodes(TreeNode node, int low, int high)
    {
        if (node.val > low && node.left is not null)
            _queue.Enqueue(node.left);

        if (node.val < high && node.right is not null)
            _queue.Enqueue(node.right);
    }
}

public class _0938_RangeSumOfBST_Recursively
{
    public int RangeSumBST(TreeNode root, int low, int high)
    {
        if (root is null) return 0;
        var self = IsInRange(root.val, low, high) ? root.val : 0;
        var left = root.val > low ? RangeSumBST(root.left, low, high) : 0;
        var right = root.val < high ? RangeSumBST(root.right, low, high) : 0;
        return self + left + right;
    }

    private static bool IsInRange(int value, int low, int high) => low <= value && value <= high;
}
