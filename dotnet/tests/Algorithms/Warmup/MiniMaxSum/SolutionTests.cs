using RamanM.HackerRank.Algorithms.Warmup.MiniMaxSum;

namespace RamanM.HackerRank.Tests.Algorithms.Warmup.MiniMaxSum;

[Collection(nameof(Console))]
public class SolutionTests : ConsoleTest
{
    [Fact]
    public void Main_Example_PrintsSums()
    {
        // Arrange
        var stdin = Encoding.ASCII.GetBytes("1 3 5 7 9");
        var sums = "16 24";

        // Act
        var actual = Act(() => Solution.Main(Array.Empty<string>()), stdin);

        // Assert
        Assert.Equal(sums, actual);
    }

    [Fact]
    public void Main_Sample_PrintsSums()
    {
        // Arrange
        var stdin = Encoding.ASCII.GetBytes("1 2 3 4 5");
        var sums = "10 14";

        // Act
        var actual = Act(() => Solution.Main(Array.Empty<string>()), stdin);

        // Assert
        Assert.Equal(sums, actual);
    }
}
