namespace LeetCode.Test;

public class _0872_Leaf_SimilarTrees_Test
{
    [Theory]
    [InlineData(new object[] { 3, 5, 1, 6, 2, 9, 8, null, null, 7, 4 }, new object[] { 3, 5, 1, 6, 7, 4, 2, null, null, null, null, null, null, 9, 8 }, true)]
    [InlineData(new object[] { 1, 2, 3 }, new object[] { 1, 3, 2 }, false)]
    public void LeafSimilar(object[] root1, object[] root2, bool expected)
    {
        var sut = new _0872_Leaf_SimilarTrees();
        var actual = sut.LeafSimilar(root1.ToTree(), root2.ToTree());
        Assert.Equal(expected, actual);
    }
}
