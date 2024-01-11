
namespace LeetCode;

public class _1026_MaximumDifferenceBetweenNodeAndAncestor
{
    private int _max = 0;
    public int MaxAncestorDiff(TreeNode root)
    {
        Traverse(root, root.val, root.val);
        return _max;
    }
    private void Traverse(TreeNode root, int min, int max)
    {
        if (root is null)
        {
            _max = Math.Max(_max, Math.Abs(max - min));
            return;
        }
        min = Math.Min(root.val, min);
        max = Math.Max(root.val, max);
        Traverse(root.left, min, max);
        Traverse(root.right, min, max);
    }
}
