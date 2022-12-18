using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCode.Test;

public class _0709_ToLowerCase_Test
{
    [Theory]
    [InlineData("hello", "Hello")]
    [InlineData("here", "here")]
    [InlineData("lovely", "LOVELY")]
    public void ToLowerCase(string expected, string str)
    {
        // Arrange
        var solution = new _0709_ToLowerCase();

        // Act
        var actual = solution.ToLowerCase(str);

        // Assert
        Assert.Equal(expected, actual);
    }
}
