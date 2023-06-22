// Link https://leetcode.com/problems/remove-duplicates-from-sorted-array/

namespace LeetCode;

public class _0026_RemoveDuplicatesFromSortedArray
{
    public int RemoveDuplicates(int[] nums)
    {
        int count = 0;
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] == nums[i - 1])
            {
                count++;
            }
            else
            {
                nums[i - count] = nums[i];
            }
        }

        return nums.Length - count;
    }
}
