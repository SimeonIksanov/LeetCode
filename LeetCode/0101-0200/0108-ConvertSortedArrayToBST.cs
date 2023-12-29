
using LeetCode;

public class _0108_ConvertSortedArrayToBST
{
    public TreeNode SortedArrayToBST(int[] nums) {
        if (nums is null || nums.Length == 0)
            return null;

        return ToTree(nums, 0, nums.Length-1);
    }

    private TreeNode ToTree(int[] nums, int start, int end)
    {
        if (start < 0 || start >= nums.Length || end >= nums.Length || end < 0 || end < start)
            return null;
        
        int middle = (start + end) / 2;
        var tree = new TreeNode(nums[middle],
                                ToTree(nums, start, middle - 1),
                                ToTree(nums, middle + 1, end));
        return tree;
    }
}