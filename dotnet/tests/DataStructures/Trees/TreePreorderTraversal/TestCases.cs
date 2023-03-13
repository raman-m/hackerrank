using RamanM.HackerRank.DataStructures.Trees.TreePreorderTraversal;

namespace RamanM.HackerRank.Tests.DataStructures.Trees.TreePreorderTraversal;

[Collection(nameof(Console))]
public class TestCases : TestCase
{
    [Theory]
    [InlineData("00")]
    [InlineData("02")]
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
