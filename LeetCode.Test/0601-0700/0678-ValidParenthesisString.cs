namespace LeetCode.Test;

public class _0678_ValidParenthesisString_Test
{
    [Theory]
    [InlineData("()", true)]
    [InlineData("*)", true)]
    [InlineData("(((((*(((((*)*(**)))))))))))((((*)))))(((**(*)))(*)", true)]
    [InlineData("(*)", true)]
    [InlineData("()*", true)]
    [InlineData("*()", true)]
    [InlineData("(*))", true)]
    [InlineData("(**)", true)]
    [InlineData("(*(*))", true)]
    [InlineData("(*(*)*)", true)]
    [InlineData("(*()", true)]
    [InlineData("((((()(()()()*()(((((*)()*(**(())))))(())()())(((())())())))))))(((((())*)))()))(()((*()*(*)))(*)()", true)]
    [InlineData("**************************************************))))))))))))))))))))))))))))))))))))))))))))))))))", true)]
    [InlineData("((*", false)]
    [InlineData(")(", false)]
    [InlineData("(", false)]
    [InlineData(")", false)]
    [InlineData("(((((()*)(*)*))())())(()())())))((**)))))(()())()", false)]
    [InlineData("(((((*(()((((*((**(((()()*)()()()*((((**)())*)*)))))))(())(()))())((*()()(((()((()*(())*(()**)()(())", false)]
    [InlineData("*************************************************************************************************((*", false)]
    public void CheckString(string s, bool expected)
    {
        // Arrange
        var solution = new _0678_ValidParenthesisString();

        // Act
        var actual = solution.CheckValidString(s);

        // Assert
        Assert.Equal(expected, actual);
    }
}
