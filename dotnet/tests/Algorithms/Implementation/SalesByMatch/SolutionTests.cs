using RamanM.HackerRank.Algorithms.Implementation.SalesByMatch;

namespace RamanM.HackerRank.Tests.Algorithms.Implementation.SalesByMatch;

[Collection(nameof(Console))]
public class SolutionTests : ConsoleTest
{
    [Fact]
    public void Main_Example_ReturnsTwoPairs()
    {
        // Arrange
        var stdin = $"7{nl}1 2 1 2 1 3 2";
        var expected = "2" + nl;

        // Act TODO Implement call of private class via reflection
        var actual = ActOnOutput(() => Solution.Main(Array.Empty<string>()), stdin);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Main_Sample_ReturnsThreePairs()
    {
        // Arrange
        var stdin = $"9{nl}10 20 20 10 10 30 50 10 20";
        var expected = "3" + nl;

        // Act TODO Implement call of private class via reflection
        var actual = ActOnOutput(() => Solution.Main(Array.Empty<string>()), stdin);

        // Assert
        Assert.Equal(expected, actual);
    }
}
