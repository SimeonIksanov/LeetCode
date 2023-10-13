// Link: https://leetcode.com/problems/minimum-number-of-operations-to-make-array-continuous/

namespace LeetCode;

public class _2009_Minimum_Number_of_Operations_to_Make_Array_Continuous
{
    public int MinOperations(int[] nums)
    {
        var sorted = nums.Distinct().Order().ToArray();
        int ans = nums.Length;

        for (int i = 0, j = 0; i < sorted.Length; i++)
        {
            while (j < sorted.Length && sorted[i] + nums.Length - 1 >= sorted[j])
            { j++; }
            ans = Math.Min(ans, nums.Length - (j - i));
        }
        return ans;
    }
}
