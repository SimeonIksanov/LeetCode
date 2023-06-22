// Link https://leetcode.com/problems/majority-element/

namespace LeetCode;

public class _0169_MajorityElement
{
    public int MajorityElement(int[] nums)
    {
        var element = new Element() { Value = nums[0], Count = 1 };

        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] == element.Value)
            {
                element.Count++;
                continue;
            }

            if (element.Count > 0)
            {
                element.Count--;
                continue;
            }
            else
            {
                element.Value = nums[i];
                element.Count = 1;
            }
        }

        return element.Value;
    }

    internal struct Element
    {
        public int Value;
        public int Count;
    }
}

