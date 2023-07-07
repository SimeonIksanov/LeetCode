namespace LeetCode.Test;

public class _0373_FindKPairsWithSmallestSums_Test
{
    [Theory]
    [MemberData(nameof(TestDataProvider))]
    public void KSmallestPairs(int[] nums1, int[]nums2, int k, int[][] expected)
    {
        var sut = new _0373_FindKPairsWithSmallestSums();

        var actual = sut.KSmallestPairs(nums1, nums2, k);

        for (var i = 0; i < actual.Count; i++)
        {
            Assert.Equal(expected[i], actual[i]);
        }
        Assert.Equal(expected.Length, actual.Count);
    }

    public static IEnumerable<object[]> TestDataProvider()
    {
        yield return new object[]
        {
            new[] { 1, 7, 11 },
            new[] { 2, 4, 6 },
            3,
            new[] { new [] { 1, 2 }, new [] { 1, 4 }, new [] { 1, 6 } }
        };
        
        yield return new object[]
        {
            new[] { 1, 1,2 },
            new[] { 1,2,3 },
            2,
            new[] { new [] { 1, 1 }, new [] { 1, 1 } }
        };
        
        yield return new object[]
        {
            new[] { 1,2 },
            new[] { 3 },
            3,
            new[] { new [] { 1, 3 }, new [] { 2, 3 } }
        };
        
        yield return new object[]
        {
            new[] { 1, 2, 10 },
            new[] { 3, 6, 13 },
            4,
            new[] { new [] { 1, 3 }, new [] { 2, 3 }, new [] { 1, 6 }, new [] { 2, 6 }  }
        };
        
        yield return new object[]
        {
            new[] { 3, 6, 13 },
            new[] { 1, 2, 10 },
            4,
            new[] { new [] { 3, 1 }, new [] { 3, 2 }, new [] { 6, 1 }, new [] { 6, 2 }  }
        };
        
        yield return new object[]
        {
            new[] { 1,2,4,5,6 },
            new[] { 3,5,7,9 },
            3,
            new[] { new [] { 1,3 }, new [] { 2,3 }, new [] { 1, 5 }  }
        };
        
        yield return new object[]
        {
            new[] { 1 },
            new[] { 3,5,6,7,8, 100 },
            4,
            new[] { new [] { 1,3 }, new [] { 1,5 }, new [] { 1, 6 }, new [] { 1, 7 }  }
        };
        
        yield return new object[]
        {
            new[] { 1, 1, 2 },
            new[] { 1, 2, 3 },
            10,
            new[]
            {
                new[] { 1, 1 }, new[] { 1, 1 }, new[] { 1, 2 }, new[] { 1, 2 }, new[] { 2, 1 },
                new[] { 1, 3 }, new[] { 2,2 }, new[] { 1, 3 },  new[] { 2, 3 }
            }

        };
        
        yield return new object[]
        {
            new[] { -10,-4,0,0,6 },
            new[] { 3,5,6,7,8,100 },
            10,
            new[]
            {
                new [] { -10,3 }, new [] { -10,5 }, new [] { -10, 6 }, new [] { -10, 7 }, new [] { -10, 8 },
                new [] { -4, 3 }, new [] { -4, 5 }, new [] { -4, 6 }, new [] { 0, 3 }, new [] { -4, 7 }
            }
        };
    }
}
