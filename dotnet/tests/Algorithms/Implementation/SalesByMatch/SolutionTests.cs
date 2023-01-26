using RamanM.HackerRank.Algorithms.Implementation.SalesByMatch;

namespace RamanM.HackerRank.Tests.Algorithms.Implementation.SalesByMatch;

public class SolutionTests : UnitTest
{
    [Fact]
    public void Main_Example_ReturnsTwoPairs()
    {
        // Arrange
        var stdin = "7\r\n1 2 1 2 1 3 2";
        var expected = "2";

        // Act TODO Implement call of private class via reflection
        var actual = ActInConsoleReader(
            () => Solution.Main(Array.Empty<string>()),
            stdin, typeof(SolutionTests).Namespace, nameof(Main_Example_ReturnsTwoPairs));

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Main_Sample_ReturnsThreePairs()
    {
        // Arrange
        var stdin = "9\r\n10 20 20 10 10 30 50 10 20";
        var expected = "3";

        // Act TODO Implement call of private class via reflection
        var actual = ActInConsoleReader(
            () => Solution.Main(Array.Empty<string>()),
            stdin, typeof(SolutionTests).Namespace, nameof(Main_Sample_ReturnsThreePairs));

        // Assert
        Assert.Equal(expected, actual);
    }
}
