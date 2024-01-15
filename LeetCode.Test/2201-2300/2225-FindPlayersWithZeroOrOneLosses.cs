namespace LeetCode.Test;

public class _2225_FindPlayersWithZeroOrOneLosses_Test
{
    public _2225_FindPlayersWithZeroOrOneLosses UnitUnderTest = new();

    [Theory]
    [MemberData(nameof(TestData))]
    public void FindWinners(int[][] matches, int[][] expected)
    {
        Assert.Equal(expected, UnitUnderTest.FindWinners(matches));
    }

    public static IEnumerable<object[]> TestData()
    {
        yield return new object[] {
            new int[][] { [1, 3], [2, 3], [3, 6], [5, 6], [5, 7], [4, 5], [4, 8], [4, 9], [10, 4], [10, 9] },
            new int[][] { [1, 2, 10], [4, 5, 7, 8] }
        };

        yield return new object[] {
            new int[][] { [2,3],[1,3],[5,4],[6,4] },
            new int[][] { [1, 2, 5, 6], [] }
        };
    }
}
