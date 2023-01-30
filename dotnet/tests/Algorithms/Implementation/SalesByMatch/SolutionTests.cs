using RamanM.HackerRank.Algorithms.Implementation.SalesByMatch;

namespace RamanM.HackerRank.Tests.Algorithms.Implementation.SalesByMatch;

public class SolutionTests : ConsoleTest
{
    [Fact]
    public void Main_Example_ReturnsTwoPairs()
    {
        // Arrange
        string nl = Environment.NewLine;
        var stdin = $"7{nl}1 2 1 2 1 3 2";
        var expected = "2" + nl;
        var outputPath = SetupOutput();

        // Act TODO Implement call of private class via reflection
        Act(() => Solution.Main(Array.Empty<string>()),
            stdin);

        // Assert
        var actual = Actual(outputPath);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Main_Sample_ReturnsThreePairs()
    {
        // Arrange
        string nl = Environment.NewLine;
        var stdin = $"9{nl}10 20 20 10 10 30 50 10 20";
        var expected = "3" + nl;
        var outputPath = SetupOutput();

        // Act TODO Implement call of private class via reflection
        Act(() => Solution.Main(Array.Empty<string>()),
            stdin);

        // Assert
        var actual = Actual(outputPath);
        Assert.Equal(expected, actual);
    }
}
