namespace LeetCode;

public class _0136_SingleNumber
{
    public int SingleNumber(int[] nums) {
        int num = 0;
        for (int i = 0; i < nums.Length; i++)
            num ^= nums[i];

        return num;
    }
}
