// Link: https://leetcode.com/problems/two-sum/

namespace LeetCode;

public class _0001_TwoSum
{
    public int[] TwoSum(int[] nums, int target)
    {
        var dict = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (dict.TryGetValue(nums[i], out int value))
                return new int[] { i, value };

            dict.TryAdd(target - nums[i], i);
        }

        return null;
    }
}