using RamanM.HackerRank.DataStructures.Trees.TreePreorderTraversal;

namespace RamanM.HackerRank.Tests.DataStructures.Trees.TreePreorderTraversal;

[Collection(nameof(Console))]
public class SolutionTests : ConsoleTest
{
    [Fact]
    public void PreOrder_Sample_PrintsTree()
    {
        // Arrange
        var root = new Node(1);
        var n2 = new Node(2);
        root.right = n2;

        var n5 = new Node(5);
        n2.right = n5;

        var n3 = new Node(3);
        n5.left = n3;

        var n4 = new Node(4);
        n3.right = n4;

        var n6 = new Node(6);
        n5.right = n6;

        var tree = "1 2 5 3 4 6 ";

        // Act
        var actual = Act(() => Solution.preOrder(root));

        // Assert
        Assert.Equal(tree, actual);
    }

    [Fact]
    public void Main_Sample_PrintsTree()
    {
        // Arrange
        var stdin = Encoding.ASCII.GetBytes($"6{nl}1 2 5 3 6 4");
        var printed = "1 2 5 3 4 6 ";

        // Act
        var actual = Act(() => Solution.Main(Array.Empty<string>()), stdin);

        // Assert
        Assert.Equal(printed, actual);
    }
}
