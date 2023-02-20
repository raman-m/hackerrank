using RamanM.HackerRank.Algorithms.Warmup.DiagonalDifference;

namespace RamanM.HackerRank.Tests.Algorithms.Warmup.DiagonalDifference;

[Collection(nameof(SolutionTests))]
public class SolutionTests : ConsoleTest
{
    private readonly string nl = Environment.NewLine;

    [Fact]
    public void Main_Example_ReturnsMatrixModule()
    {
        // Arrange
        var stdin = $"3{nl}1 2 3{nl}4 5 6{nl}9 8 9";
        var output = "2" + nl;
        var outputPath = SetupOutput();

        // Act
        Act(() => Solution.Main(Array.Empty<string>()),
            stdin);

        // Assert
        var actual = Actual(outputPath);
        Assert.Equal(output, actual);
    }

    [Fact]
    public void Main_Sample_ReturnsMatrixModule()
    {
        // Arrange
        var stdin = $"3{nl}11 2 4{nl}4 5 6{nl}10 8 -12";
        var output = "15" + nl;
        var outputPath = SetupOutput();

        // Act
        Act(() => Solution.Main(Array.Empty<string>()),
            stdin);

        // Assert
        var actual = Actual(outputPath);
        Assert.Equal(output, actual);
    }
}
