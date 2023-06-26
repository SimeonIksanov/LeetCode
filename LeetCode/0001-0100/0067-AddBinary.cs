// Link https://leetcode.com/problems/plus-one/

using static System.Net.Mime.MediaTypeNames;

namespace LeetCode;

public class _0067_AddBinary
{
    public string AddBinary(string a, string b)
    {
        var aa = ToIntArray(a);
        var bb = ToIntArray(b);
        int i = aa.Length - 1, j = bb.Length - 1, nl = Math.Max(aa.Length, bb.Length);
        int x = nl - 1;
        int[] retVal = new int[nl];

        int carry = 0;
        for (; i >= 0 || j >= 0; i--, j--)
        {
            var sum = (i >= 0 ? aa[i] : 0) + (j >= 0 ? bb[j] : 0) + carry;
            retVal[x--] = sum % 2;
            carry = sum / 2;
        }

        return carry == 0
            ? string.Join("", retVal)
            : string.Format("1{0}", string.Join("", retVal));
    }

    private int[] ToIntArray(string str)
    {
        return str.Select(x => x - 48).ToArray();
    }
}
