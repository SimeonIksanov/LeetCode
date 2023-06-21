// Link https://leetcode.com/problems/longest-common-prefix/

namespace LeetCode;

public class _0014_LongestCommonPrefix
{
    public string LongestCommonPrefix(string[] strs)
    {
        if (strs.Length == 0) return "";
        if (strs.Length == 1) return strs[0];

        Array.Sort(strs);
        var pair = strs[0]
            .Zip(strs[strs.Length - 1])
            .TakeWhile(tuple => tuple.First.Equals(tuple.Second))
            .Select(tuple => tuple.First);
        return string.Join("", pair);
    }
}

