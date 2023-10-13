using System.Diagnostics;

namespace LeetCode.Test;

public class _0118_PascalsTriangle_Test
{
    [Theory]
    [MemberData(nameof(TestSamples))]
    public void TestGenerate(params object[] objects)
    {
#if DEBUG
        if (!Debugger.IsAttached) { Thread.Sleep(1000); }
#endif
        var expected = objects[1] as List<List<int>> ?? throw new ArgumentException();
        var sut = new _0118_PascalsTriangle();
        var actual = sut.Generate(Convert.ToInt32(objects[0]));

        Assert.Equal(expected, actual);
    }

    public static IEnumerable<object[]> TestSamples()
    {
        yield return new object[]
        {
            1,
            new List<List<int>>() {
                new List<int>() {1}
            }
        };
        yield return new object[]
        {
            2,
            new List<List<int>>() {
                new List<int>() {1},
                new List<int>() {1,1}
            }
        };
        yield return new object[]
        {
            3,
            new List<List<int>>() {
                new List<int>() {1},
                new List<int>() {1,1},
                new List<int>() {1,2,1},
            }
        };
        yield return new object[]
        {
            4,
            new List<List<int>>() {
                new List<int>() {1},
                new List<int>() {1,1},
                new List<int>() {1,2,1},
                new List<int>() {1,2,3,2,1},
            }
        };
        yield return new object[]
        {
            5,
            new List<List<int>>() {
                new List<int>() {1},
                new List<int>() {1,1},
                new List<int>() {1,2,1},
                new List<int>() {1,3,3,1},
                new List<int>() {1,4,6,4,1},
            }
        };
    }
}
