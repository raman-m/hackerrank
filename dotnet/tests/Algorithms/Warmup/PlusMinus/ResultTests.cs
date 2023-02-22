using RamanM.HackerRank.Algorithms.Warmup.PlusMinus;

namespace RamanM.HackerRank.Tests.Algorithms.Warmup.PlusMinus;

[Collection(nameof(Console))]
public class ResultTests : ConsoleTest
{
    [Fact]
    public void PlusMinus_Example_PrintsRatios()
    {
        // Arrange
        const int n = 5;
        var arr = new List<int>(n) { 1, 1, 0, -1, -1 };
        string ratios = $"0.400000{nl}0.400000{nl}0.200000";

        // Act
        var actual = Act(() => Result.plusMinus(arr));

        // Assert
        Assert.Equal(ratios, actual);
    }

    [Fact]
    public void PlusMinus_Sample_PrintsRatios()
    {
        // Arrange
        const int n = 6;
        var arr = new List<int>(n) { -4, 3, -9, 0, 4, 1 };
        string ratios = $"0.500000{nl}0.333333{nl}0.166667";

        // Act
        var actual = Act(() => Result.plusMinus(arr));

        // Assert
        Assert.Equal(ratios, actual);
    }
}
