// Link: https://leetcode.com/problems/merge-sorted-array/

namespace LeetCode;

public class _0088_MergeSortedArray
{
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        var end = m + n - 1;
        var end1 = m - 1;
        var end2 = n - 1;

        while (end2 >= 0)
        {
            if (end1 >= 0 && nums1[end1] > nums2[end2])
                nums1[end--] = nums1[end1--];
            else
                nums1[end--] = nums2[end2--];
        }
    }
}
