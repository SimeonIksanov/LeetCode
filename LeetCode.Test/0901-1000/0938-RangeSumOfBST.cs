namespace LeetCode.Test;

public class _0938_RangeSumOfBST_Test
{
    [Fact]
    public void RangeSumOfBST_withQueue_1()
    {
        // Arrange
        var solution = new _0938_RangeSumOfBST_Queue();
        var treeNode = new TreeNode()
        {
            val = 10,
            left = new TreeNode()
            {
                val = 5,
                left = new TreeNode() { val = 3 },
                right = new TreeNode() { val = 7 }
            },
            right = new TreeNode()
            {
                val = 15,
                right = new TreeNode() { val = 18 }
            }
        };

        // Act
        var actual = solution.RangeSumBST(treeNode, 7, 15);

        // Assert
        Assert.Equal(32, actual);
    }

    [Fact]
    public void RangeSumOfBST_withQueue_2()
    {
        // Arrange
        var solution = new _0938_RangeSumOfBST_Queue();
        var treeNode = new TreeNode()
        {
            val = 10,
            left = new TreeNode()
            {
                val = 5,
                left = new TreeNode()
                {
                    val = 3,
                    left = new TreeNode() { val = 1 }
                },
                right = new TreeNode()
                {
                    val = 7,
                    left = new TreeNode() { val = 6 }
                }
            },
            right = new TreeNode()
            {
                val = 15,
                right = new TreeNode() { val = 18 },
                left = new TreeNode() { val = 13 }
            }
        };

        // Act
        var actual = solution.RangeSumBST(treeNode, 6, 10);

        // Assert
        Assert.Equal(23, actual);
    }

    [Fact]
    public void RangeSumOfBST_withReqursion_1()
    {
        // Arrange
        var solution = new _0938_RangeSumOfBST_Recursively();
        var treeNode = new TreeNode()
        {
            val = 10,
            left = new TreeNode()
            {
                val = 5,
                left = new TreeNode() { val = 3 },
                right = new TreeNode() { val = 7 }
            },
            right = new TreeNode()
            {
                val = 15,
                right = new TreeNode() { val = 18 }
            }
        };

        // Act
        var actual = solution.RangeSumBST(treeNode, 7, 15);

        // Assert
        Assert.Equal(32, actual);
    }

    [Fact]
    public void RangeSumOfBST_withReqursion_2()
    {
        // Arrange
        var solution = new _0938_RangeSumOfBST_Recursively();
        var treeNode = new TreeNode()
        {
            val = 10,
            left = new TreeNode()
            {
                val = 5,
                left = new TreeNode()
                {
                    val = 3,
                    left = new TreeNode() { val = 1 }
                },
                right = new TreeNode()
                {
                    val = 7,
                    left = new TreeNode() { val = 6 }
                }
            },
            right = new TreeNode()
            {
                val = 15,
                right = new TreeNode() { val = 18 },
                left = new TreeNode() { val = 13 }
            }
        };

        // Act
        var actual = solution.RangeSumBST(treeNode, 6, 10);

        // Assert
        Assert.Equal(23, actual);
    }

}
