namespace LeetCode;

public class _2225_FindPlayersWithZeroOrOneLosses
{
    public IList<IList<int>> FindWinners(int[][] matches)
    {
        var lostCount = new Dictionary<int, int>();
        foreach (var match in matches)
        {
            if (!lostCount.ContainsKey(match[0]))
                lostCount.Add(match[0], 0);
            if (!lostCount.ContainsKey(match[1]))
                lostCount.Add(match[1], 1);
            else
                lostCount[match[1]]++;
        }
        return new int[][]{
            lostCount.Where(kv => kv.Value == 0).Select(kv=>kv.Key).Order().ToArray(),
            lostCount.Where(kv=>kv.Value == 1).Select(kv=>kv.Key).Order().ToArray()
        };
    }
}
