
namespace LeetCode;

public class _1704_DetermineIfStringHalvesAreAlike
{
    private static readonly HashSet<char> _vowels = new HashSet<char>(new[] { 'a', 'e', 'i', 'o', 'u' });
    public bool HalvesAreAlike(string s)
    {
        int mid = s.Length / 2;
        return s[..mid].Count(isVowels) == s[mid..].Count(isVowels);
    }

    private bool isVowels(char v) => _vowels.Contains(char.ToLower(v));
}
