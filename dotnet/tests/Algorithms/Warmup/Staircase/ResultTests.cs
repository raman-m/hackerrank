using RamanM.HackerRank.Algorithms.Warmup.Staircase;

namespace RamanM.HackerRank.Tests.Algorithms.Warmup.Staircase;

[Collection(nameof(Console))]
public class ResultTests : ConsoleTest
{
    [Fact]
    public void Staircase_Example_PrintsStaircase()
    {
        // Arrange
        const int n = 4;
        string staircase4x4 = $"   #{nl}  ##{nl} ###{nl}####";

        // Act
        var actual = Act(() => Result.staircase(n));

        // Assert
        Assert.Equal(staircase4x4, actual);
    }

    [Fact]
    public void Staircase_Sample_PrintsStaircase()
    {
        // Arrange
        const int n = 6;
        string staircase6x6 = $"     #{nl}    ##{nl}   ###{nl}  ####{nl} #####{nl}######";

        // Act
        var actual = Act(() => Result.staircase(n));

        // Assert
        Assert.Equal(staircase6x6, actual);
    }
}
