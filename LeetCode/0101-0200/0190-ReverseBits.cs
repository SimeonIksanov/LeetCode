namespace LeetCode;

public class _0190_ReverseBits
{
    public uint ReverseBits(uint n)
    {
        uint retValue = 0;
        int shiftCount = 0;
        while (uint.PopCount(n) > 0)
        {
            retValue <<= 1;
            retValue = retValue | (n & 1);
            n >>= 1;
            shiftCount++;
        }
        if (shiftCount < 32)
            retValue <<= 32 - shiftCount;
        return retValue;
    }
}
