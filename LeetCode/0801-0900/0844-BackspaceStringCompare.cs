namespace LeetCode;

public class _0844_BackspaceStringCompare
{
    public bool BackspaceCompare(string s, string t) {
        int index1 = s.Length - 1, index2 = t.Length - 1;
        int nIndex1, nIndex2;
        while (index1 >= 0 || index2 >= 0)
        {
            if (TryGetNextChar(s, index1, out var ch1, out nIndex1) == TryGetNextChar(t, index2, out var ch2, out nIndex2))
            {
                if (ch1 != ch2)
                    return false;
            }
            else
            {
                return false;
            }
            index1 = nIndex1-1;
            index2 = nIndex2-1;
        }
        return index1 == index2;
    }

    private bool TryGetNextChar(string str, int index, out char ch, out int newIndex)
    {
        int backspaceCount = 0;
        while (index >= 0)
        {
            if (str[index] == '#')
                backspaceCount++;
            else
                if (backspaceCount > 0)
                    backspaceCount--;
                else
                {
                    ch = str[index];
                    newIndex = index;
                    return true;
                }
            index--;
        }
        newIndex = index;
        ch = char.MinValue;
        return false;
    }
}