namespace LeetCode;

public class _1657_DetermineIfTwoStringsAreClose
{
    public bool CloseStrings(string word1, string word2)
    {
        var d1 = CharsCount(word1);
        var d2 = CharsCount(word2);
        return d1.SequenceEqual(d2) && SetsEqual(word1, word2);
    }

    private int[] CharsCount(string s)
    {
        var dict = new Dictionary<char, int>();
        foreach (var ch in s)
        {
            if (!dict.TryAdd(ch, 1))
                dict[ch]++;
        }
        var array = dict.Values.Order().ToArray();
        return array;
    }

    private bool SetsEqual(string word1, string word2)
    {
        var s1 = new HashSet<char>(word1);
        var s2 = new HashSet<char>(word2);
        return s1.SetEquals(s2);
    }
}
