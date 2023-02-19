using RamanM.HackerRank.Algorithms.Warmup.AVeryBigSum;

namespace RamanM.HackerRank.Tests.Algorithms.Warmup.AVeryBigSum;

[Collection(nameof(SolutionTests))]
public class SolutionTests : ConsoleTest
{
    [Fact]
    public void Main_Sample_ReturnsOutput()
    {
        // Arrange
        string nl = Environment.NewLine;
        var stdin = $"5{nl}1000000001 1000000002 1000000003 1000000004 1000000005";
        var output = "5000000015" + nl;
        var outputPath = SetupOutput();

        // Act
        Act(() => Solution.Main(Array.Empty<string>()),
            stdin);

        // Assert
        var actual = Actual(outputPath);
        Assert.Equal(output, actual);
    }
}
