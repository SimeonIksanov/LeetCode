namespace LeetCode;

public class _0872_Leaf_SimilarTrees
{
    public bool LeafSimilar(TreeNode root1, TreeNode root2)
    {
        return Traverse(root1).SequenceEqual(Traverse(root2));
    }

    private IEnumerable<int> Traverse(TreeNode root)
    {
        if (root is null) yield break;

        Stack<TreeNode> stack = new();
        stack.Push(root);

        while (stack.Count > 0)
        {
            var node = stack.Pop();
            if (node is null) continue;
            if (node.left is not null)
                stack.Push(node.left);
            if (node.right is not null)
                stack.Push(node.right);
            if (node.left is null && node.right is null)
                yield return node.val;
        }
        yield break;
    }
}
