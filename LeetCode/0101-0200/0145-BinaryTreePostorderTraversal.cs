namespace LeetCode;

public class _0145_BinaryTreePostorderTraversal
{
    private readonly Stack<TreeNode> _stack = new Stack<TreeNode>();
    public IList<int> PostorderTraversal(TreeNode root)
    {
        var retValue = new List<int>();
        if (root is null) return retValue;

        while (true)
        {
            while (root is not null)
            {
                if (root.right is not null) _stack.Push(root.right);
                _stack.Push(root);
                root = root.left;
            }

            if (StackEmpty) break;
            root = _stack.Pop();

            if (root.right is not null && !StackEmpty && _stack.Peek() == root.right)
            {
                _ = _stack.Pop();
                _stack.Push(root);
                root = root.right;
            }
            else
            {
                retValue.Add(root.val);
                root = null;
            }

        }

        return retValue;
    }

    private bool StackEmpty => _stack.Count == 0;
}
