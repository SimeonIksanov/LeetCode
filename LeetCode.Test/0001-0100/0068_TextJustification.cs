namespace LeetCode.Test;

public class _0068_TextJustification_Test
{
    [Theory]
    [MemberData(nameof(ProvideTestData))]
    public void AddBinary(string[] words, int maxWidth, string[] expected)
    {
        var sut = new _0068_TextJustification();

        var actual = sut.FullJustify(words, maxWidth);

        Assert.Equal(expected, actual);
    }

    public static IEnumerable<object[]> ProvideTestData()
    {
        yield return new object[]
        {
            new[] {"What", "must", "be", "acknowledgment", "shall", "be"},
            16,
            new[] {"What   must   be",
                   "acknowledgment  ",
                   "shall be        "}
        };

        yield return new object[]
        {
            new[] {"Science","is","what","we","understand","well","enough","to","explain","to","a","computer.","Art","is","everything","else","we","do"},
            20,
            new[] {"Science  is  what we",
                   "understand      well",
                   "enough to explain to",
                   "a  computer.  Art is",
                   "everything  else  we",
                   "do                  "}
        };
    }
}
