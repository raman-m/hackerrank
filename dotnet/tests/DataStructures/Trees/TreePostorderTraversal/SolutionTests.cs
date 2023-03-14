using RamanM.HackerRank.DataStructures.Trees.TreePostorderTraversal;

namespace RamanM.HackerRank.Tests.DataStructures.Trees.TreePostorderTraversal;

[Collection(nameof(Console))]
public class SolutionTests : ConsoleTest
{
    [Fact]
    public void PostOrder_Sample_PrintsTree()
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

        var printed = "4 3 6 5 2 1 ";

        // Act
        var actual = Act(() => Solution.postOrder(root));

        // Assert
        Assert.Equal(printed, actual);
    }

    [Fact]
    public void Main_Sample_PrintsTree()
    {
        // Arrange
        var stdin = Encoding.ASCII.GetBytes($"6{nl}1 2 5 3 6 4");
        var printed = "4 3 6 5 2 1 ";

        // Act
        var actual = Act(() => Solution.Main(Array.Empty<string>()), stdin);

        // Assert
        Assert.Equal(printed, actual);
    }
}
