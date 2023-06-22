// Link https://leetcode.com/problems/search-insert-position/

namespace LeetCode;

public class _0035_SearchInsertPosition
{
    public int SearchInsert(int[] nums, int target)
    {
        int start = 0, end = nums.Length - 1;

        while (start != end)
        {
            var mid = (start + end) / 2;

            if (nums[mid] < target)
            {
                start = mid + 1;
            }
            else if (target < nums[mid])
            {
                end = mid;
            }
            else
            {
                return mid;
            }
        }
        if (nums[start] < target) { return start + 1; }
        return start;
    }
}
