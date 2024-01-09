namespace LeetCode;

public class _0455_AssignCookies
{
    public int FindContentChildren(int[] greeds, int[] cookies)
    {
        int cookieIndex = 0, greedIndex = 0, totalContent = 0;
        Array.Sort(greeds);
        Array.Sort(cookies);

        while (greedIndex < greeds.Length && cookieIndex < cookies.Length)
        {
            if (greeds[greedIndex] > cookies[cookieIndex])
            {
                cookieIndex++;
                continue;
            }
            totalContent++;
            greedIndex++;
            cookieIndex++;
        }
        return totalContent;
    }
}
