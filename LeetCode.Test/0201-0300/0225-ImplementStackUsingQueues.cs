namespace LeetCode.Test;

public class _0225_ImplementStackUsingQueues_Test
{
    [Theory]
    [InlineData(true, new[] { "push", "push", "top", "pop", "empty" })]
    public void _0225_ImplementStackUsingQueues(bool expected, string[] commands)
    {
        // Arrange
        var sut = new _0225_ImplementStackUsingQueues.MyStack();
        int popResult = -1, topResult = -1, pushValue = 1;
        bool emptyResult = true;

        // Act
        for (int i = 0; i < commands.Length; i++)
        {
            switch (commands[i])
            {
                case "push":
                    sut.Push(pushValue++);
                    break;
                case "top":
                    topResult = sut.Top();
                    break;
                case "pop":
                    popResult = sut.Pop();
                    break;
                case "empty":
                    emptyResult = sut.Empty();
                    break;
                default:
                    throw new NotImplementedException();
            };

        }
        // Assert
        Assert.Equal(2, topResult);
        Assert.Equal(2, popResult);
        Assert.False(emptyResult);
    }
}
