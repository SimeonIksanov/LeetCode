namespace LeetCode;

public class _0205_IsomorphicStrings
{
    Dictionary<char, char> _map = new();
    Dictionary<char, char> _rmap = new();
    public bool IsIsomorphic(string s, string t)
    {
        for (int i = 0; i < s.Length; i++)
        {
            if ((_map.ContainsKey(t[i]) && !_rmap.ContainsKey(s[i]))
                || !_map.ContainsKey(t[i]) && _rmap.ContainsKey(s[i]))
                return false;
            if (_map.ContainsKey(t[i]) && _rmap.ContainsKey(s[i]))
            {
                if (s[i] == _map[t[i]] && t[i] == _rmap[s[i]])
                    continue;
                else
                    return false;
            }
            else
            {
                _map.Add(t[i], s[i]);
                _rmap.Add(s[i], t[i]);
            }
        }
        return true;
    }
}
