// Link: https://leetcode.com/problems/median-of-two-sorted-arrays/

namespace LeetCode;

public class _0004_MedianOfTwoSortedArrays
{
    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        if (nums1.Length == 0)
            return FindMedian(nums2);
        if (nums2.Length == 0)
            return FindMedian(nums1);

        if (nums1.Length > nums2.Length) Swap(ref nums1, ref nums2);

        int halfSize = (nums1.Length + nums2.Length + 1) / 2;
        int nums1MinContribution = 0;
        int nums1MaxContribution = nums1.Length;

        while (nums1MinContribution <= nums1MaxContribution)
        {
            int num1Contribution = (int)Math.Round((nums1MinContribution + nums1MaxContribution) / 2d);
            int num2Contribution = halfSize - num1Contribution;

            if (num1Contribution > 0 && nums1[num1Contribution - 1] > nums2[num2Contribution])
                nums1MaxContribution = num1Contribution - 1;
            else if (num1Contribution < nums1.Length && nums2[num2Contribution - 1] > nums1[num1Contribution])
                nums1MinContribution = num1Contribution + 1;
            else
            {
                // here I got correct contibution by both arrays
                int lastElementOfLeftHalf;
                if (num1Contribution == 0)
                    lastElementOfLeftHalf = nums2[num2Contribution - 1];
                else if (num2Contribution == 0)
                    lastElementOfLeftHalf = nums1[num1Contribution - 1];
                else
                    lastElementOfLeftHalf = Math.Max(nums1[num1Contribution - 1], nums2[num2Contribution - 1]);

                if ((nums1.Length + nums2.Length) % 2 != 0)
                    return lastElementOfLeftHalf;

                int firstElementOfRightHalf;
                if (num1Contribution == nums1.Length)
                    firstElementOfRightHalf = nums2[num2Contribution];
                else if (num2Contribution == nums2.Length)
                    firstElementOfRightHalf = nums1[num1Contribution];
                else
                    firstElementOfRightHalf = Math.Min(nums1[num1Contribution], nums2[num2Contribution]);

                return (lastElementOfLeftHalf + firstElementOfRightHalf) / 2d;
            }
        }
        return -1;
    }

    private static double FindMedian(int[] nums)
    {
        if (nums.Length % 2 == 0)
            return (nums[nums.Length / 2 - 1] + nums[nums.Length / 2]) / 2d;
        return nums[nums.Length / 2];
    }

    private static void Swap(ref int[] a, ref int[] b)
    {
        int[] t = a;
        a = b;
        b = t;
    }
}
