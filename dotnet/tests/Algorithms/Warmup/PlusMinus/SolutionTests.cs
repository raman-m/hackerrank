using RamanM.HackerRank.Algorithms.Warmup.PlusMinus;

namespace RamanM.HackerRank.Tests.Algorithms.Warmup.PlusMinus;

[Collection(nameof(Console))]
public class SolutionTests : ConsoleTest
{
    [Fact]
    public void Main_Example_PrintsRatios()
    {
        // Arrange
        var stdin = Encoding.ASCII.GetBytes($"5{nl}1 1 0 -1 -1");
        var ratios = $"0.400000{nl}0.400000{nl}0.200000";

        // Act
        var actual = Act(() => Solution.Main(Array.Empty<string>()), stdin);

        // Assert
        Assert.Equal(ratios, actual);
    }

    [Fact]
    public void Main_Sample_PrintsRatios()
    {
        // Arrange
        var stdin = Encoding.ASCII.GetBytes($"6{nl}-4 3 -9 0 4 1");
        var ratios = $"0.500000{nl}0.333333{nl}0.166667";

        // Act
        var actual = Act(() => Solution.Main(Array.Empty<string>()), stdin);

        // Assert
        Assert.Equal(ratios, actual);
    }
}
