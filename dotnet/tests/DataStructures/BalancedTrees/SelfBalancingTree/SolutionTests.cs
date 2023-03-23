using RamanM.HackerRank.DataStructures.BalancedTrees.SelfBalancingTree;

namespace RamanM.HackerRank.Tests.DataStructures.BalancedTrees.SelfBalancingTree;

public class SolutionUnitTests
{
    [Fact]
    public void Height_LeafNode_ReturnsZero()
    {
        // Arrange
        var leaf = new Node(0);

        // Act
        int actual = Solution.Height(leaf);

        // Assert
        Assert.Equal(0, actual);
    }

    [Fact]
    public void Height_Example_ReturnsTwo()
    {
        // Arrange
        var root = LeftRightCaseUnbalancedTree();

        // Act
        int actual = Solution.Height(root);

        // Assert
        Assert.Equal(2, actual);
    }

    [Fact]
    public void Height_Example2_ReturnsTwo()
    {
        // Arrange
        var root = RightLeftCaseUnbalancedTree();

        // Act
        int actual = Solution.Height(root);

        // Assert
        Assert.Equal(2, actual);
    }

    [Fact]
    public void Height_Sample_ReturnsTwo()
    {
        // Arrange
        var root = SampleBalancedTree();

        // Act
        int actual = Solution.Height(root);

        // Assert
        Assert.Equal(2, actual);
    }

    [Fact]
    public void BalanceFactor_LeafNode_ReturnsZero()
    {
        // Arrange
        var leaf = new Node(0);

        // Act
        int actual = Solution.BalanceFactor(leaf);

        // Assert
        Assert.Equal(0, actual);
    }

    [Fact]
    public void BalanceFactor_Example_ReturnsTwo()
    {
        // Arrange
        var root = LeftRightCaseUnbalancedTree();

        // Act
        int actual = Solution.BalanceFactor(root);

        // Assert
        Assert.Equal(2, actual); 
    }

    [Fact]
    public void BalanceFactor_Example2_ReturnsMinusTwo()
    {
        // Arrange
        var root = RightLeftCaseUnbalancedTree();

        // Act
        int actual = Solution.BalanceFactor(root);

        // Assert
        Assert.Equal(-2, actual);
    }

    [Fact]
    public void BalanceFactor_Sample_ReturnsMinusOne()
    {
        // Arrange
        var root = SampleBalancedTree();

        // Act
        int actual = Solution.BalanceFactor(root);

        // Assert
        Assert.Equal(-1, actual);
    }

    [Fact]
    public void Insert_ExampleOfLeftRightCase_GetsBalancedAndReturns4thNode()
    {
        // Arrange
        var root = LeftRightCaseUnbalancedTree();
        root.Left.Right = null;

        // Act
        var actual = Solution.Insert(root, 4);
        int actualBalanceFactor = Solution.BalanceFactor(actual);

        // Assert
        Assert.InRange(actualBalanceFactor, -1, 1);
        Assert.Equal(0, actualBalanceFactor);

        Assert.NotEqual(root, actual);
        Assert.Equal(4, actual.Value);
    }

    [Fact]
    public void Insert_ExampleOfRightLeftCase_GetsBalancedAndReturns4thNode()
    {
        // Arrange
        var root = RightLeftCaseUnbalancedTree();
        root.Right.Left = null;

        // Act
        var actual = Solution.Insert(root, 4);
        int actualBalanceFactor = Solution.BalanceFactor(actual);

        // Assert
        Assert.InRange(actualBalanceFactor, -1, 1);
        Assert.Equal(0, actualBalanceFactor);

        Assert.NotEqual(root, actual);
        Assert.Equal(4, actual.Value);
    }

    [Fact]
    public void Insert_SampleOfBalancedTree_GetsBalancedAndReturns3rdNode()
    {
        // Arrange
        var root = SampleBalancedTree();

        // Act
        var actual = Solution.Insert(root, 6);
        int actualBalanceFactor = Solution.BalanceFactor(actual);

        // Assert
        Assert.InRange(actualBalanceFactor, -1, 1);
        Assert.Equal(-1, actualBalanceFactor);

        Assert.Equal(3, actual.Value);
        var n5 = actual?.Right;
        Assert.NotNull(n5);
        Assert.Equal(5, n5.Value);
        var n6 = actual?.Right?.Right;
        Assert.NotNull(n6);
        Assert.Equal(6, n6.Value);
        var n4 = actual?.Right?.Left;
        Assert.NotNull(n4);
        Assert.Equal(4, n4.Value);
    }

    private Node LeftRightCaseUnbalancedTree()
    {
        var root = new Node(5);
        var n3 = new Node(3);
        n3.Right = new Node(4);
        root.Left = n3;
        return root;
    }

    private Node RightLeftCaseUnbalancedTree()
    {
        var root = new Node(3);
        var n5 = new Node(5);
        n5.Left = new Node(4);
        root.Right = n5;
        return root;
    }

    private Node SampleBalancedTree()
    {
        var root = new Node(3);
        root.Left = new Node(2);
        root.Right = new Node(4);
        root.Right.Right = new Node(5);
        return root;
    }
}

[Collection(nameof(Console))]
public class SolutionTests : ConsoleTest
{
    [Fact]
    public void Main_ExampleOfUnbalancedTree_GetsBalancedAndReturns4thNode()
    {
        // Arrange
        var stdin = Encoding.ASCII.GetBytes($"3{nl}5 3 4{nl}6");
        var printed = $"3(BF=0) 4(BF=-1) 5(BF=-1) 6(BF=0) {nl}4(BF=-1) 3(BF=0) 5(BF=-1) 6(BF=0) ";

        // Act
        var actual = Act(() => Solution.Main(Array.Empty<string>()), stdin);

        // Assert
        Assert.Equal(printed, actual);
    }

    [Fact]
    public void Main_SampleOfBalancedTree_GetsBalancedAndReturns3rdNode()
    {
        // Arrange
        var stdin = Encoding.ASCII.GetBytes($"4{nl}2 3 4 5{nl}6");
        var printed = $"2(BF=0) 3(BF=-1) 4(BF=0) 5(BF=0) 6(BF=0) {nl}3(BF=-1) 2(BF=0) 5(BF=0) 4(BF=0) 6(BF=0) ";

        // Act
        var actual = Act(() => Solution.Main(Array.Empty<string>()), stdin);

        // Assert
        Assert.Equal(printed, actual);
    }
}
