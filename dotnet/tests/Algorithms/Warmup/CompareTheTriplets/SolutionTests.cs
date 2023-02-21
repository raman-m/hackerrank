using RamanM.HackerRank.Algorithms.Warmup.CompareTheTriplets;

namespace RamanM.HackerRank.Tests.Algorithms.Warmup.CompareTheTriplets;

[Collection(nameof(Console))]
public class SolutionTests : ConsoleTest
{
    [Fact]
    public void Main_Example_ReturnsOneAndOne()
    {
        // Arrange
        var stdin = $"1 2 3{nl}3 2 1";
        var oneAndOne = "1 1" + nl;
        var outputPath = SetupOutput();

        // Act
        Act(() => Solution.Main(Array.Empty<string>()),
            stdin);

        // Assert
        var actual = Actual(outputPath);
        Assert.Equal(oneAndOne, actual);
    }

    [Fact]
    public void Main_Sample0_ReturnsOneAndOne()
    {
        // Arrange
        var stdin = $"5 6 7{nl}3 6 10";
        var oneAndOne = "1 1" + nl;
        var outputPath = SetupOutput();

        // Act
        Act(() => Solution.Main(Array.Empty<string>()),
            stdin);

        // Assert
        var actual = Actual(outputPath);
        Assert.Equal(oneAndOne, actual);
    }

    [Fact]
    public void Main_Sample1_ReturnsTwoAndOne()
    {
        // Arrange
        var stdin = $"17 28 30{nl}99 16 8";
        var twoAndOne = "2 1" + nl;
        var outputPath = SetupOutput();

        // Act
        Act(() => Solution.Main(Array.Empty<string>()),
            stdin);

        // Assert
        var actual = Actual(outputPath);
        Assert.Equal(twoAndOne, actual);
    }
}
