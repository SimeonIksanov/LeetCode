// Link https://leetcode.com/problems/find-k-pairs-with-smallest-sums/

using System.Collections;

namespace LeetCode;

public class _0373_FindKPairsWithSmallestSums
{
    public IList<IList<int>> KSmallestPairs(int[] nums1, int[] nums2, int k)
    {
        var retValue = new List<IList<int>>();
        var queue = new PriorityQueue<Pair, int>();

        var n = nums1.Length;
        var m = nums2.Length;
        for (int i = 0; i < Math.Min(k, n); i++)
        {
            queue.Enqueue(
                new Pair(nums1[i], nums2[0], 0),
                nums1[i] + nums2[0]);
        }

        while (k-- > 0 && queue.Count > 0)
        {
            var pair = queue.Dequeue();
            retValue.Add(new List<int> { pair.First, pair.Second });

            if (pair.SecondIndex + 1 < m)
                queue.Enqueue(
                    new Pair(pair.First, nums2[pair.SecondIndex + 1], pair.SecondIndex + 1),
                    pair.First + nums2[pair.SecondIndex + 1]);
        }

        return retValue;
    }
}

class Pair
{
    public Pair(int first, int second, int secondIndex)
    {
        First = first;
        Second = second;
        SecondIndex = secondIndex;
    }
    
    public int First { get; }
    public int Second { get; }
    public int SecondIndex { get; }
}
