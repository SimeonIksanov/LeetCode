

namespace LeetCode;

public class _1347_MinimumNumberOfStepsToMakeTwoStringsAnagram
{
    public int MinSteps(string s, string t)
    {
        Dictionary<char, int> s_dict = CountChars(s);
        Dictionary<char, int> t_dict = CountChars(t);
        int total = 0;
        foreach (var kv in s_dict)
        {
            var countInT = t_dict.ContainsKey(kv.Key) ? t_dict[kv.Key] : 0;
            if (kv.Value > countInT)
                total += kv.Value - countInT;
        }
        return total;
    }

    private Dictionary<char, int> CountChars(string s)
    {
        var t = new Dictionary<char, int>();
        foreach (var item in s)
        {
            if (!t.TryAdd(item, 1))
            {
                t[item]++;
            }
        }
        return t;
    }
}
