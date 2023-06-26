// Link https://leetcode.com/problems/remove-element/

namespace LeetCode;

public class _0027_RemoveElement
{
    public int RemoveElement(int[] nums, int val)
    {
        int indexA = 0, indexB = nums.Length - 1;
        int count = 0;
        while (indexA <= indexB)
        {
            if (nums[indexA] != val)
            {
                indexA++;
            }
            else
            {
                count++;
                while (nums[indexB] == val && indexA < indexB) { indexB--; count++; }
                nums[indexA] = nums[indexB];
                indexB--;
            }
        }

        return nums.Length - count;
    }
}
