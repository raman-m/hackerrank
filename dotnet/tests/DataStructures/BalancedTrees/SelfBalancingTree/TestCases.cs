using RamanM.HackerRank.DataStructures.BalancedTrees.SelfBalancingTree;

namespace RamanM.HackerRank.Tests.DataStructures.BalancedTrees.SelfBalancingTree;

[Collection(nameof(Console))]
public class TestCases : TestCase
{
    [Theory]
    [InlineData("00")]
    [InlineData("06")]
    public void Solution_Main_TestCaseXX(string code)
    {
        // Arrange
        var expected = Setup(code);

        // Act
        var actual = Act(() => Solution.Main(Array.Empty<string>()), true);

        // Assert
        Assert.Equal(expected, actual);
    }
}
