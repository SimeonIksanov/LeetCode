using System.Security.Cryptography.X509Certificates;

namespace LeetCode;

public class _0219_ContainsDuplicate2
{
    private static HashSet<int> hashset = new HashSet<int>((int)10E5);
    public bool ContainsNearbyDuplicate(int[] nums, int k)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            if (hashset.Contains(nums[i]))
                return true;

            hashset.Add(nums[i]);
            if (i - k >= 0)
                hashset.Remove(nums[i - k]);
        }
        return false;
    }

    // public bool ContainsNearbyDuplicate(int[] nums, int k)
    // {
    //     return nums.Select((item, index) => (item, index))
    //         .GroupBy(t => t.item, e => e.index)
    //         .Where(item => item.Count() > 1)
    //         .Any(group => group.Zip(group.Skip(1)).Any(e => Math.Abs(e.First - e.Second) <= k));
    // }
}
