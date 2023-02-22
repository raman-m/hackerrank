using RamanM.HackerRank.Algorithms.Warmup.Staircase;

namespace RamanM.HackerRank.Tests.Algorithms.Warmup.Staircase;

[Collection(nameof(Console))]
public class SolutionTests : ConsoleTest
{
    [Fact]
    public void Main_Example_PrintsStaircase()
    {
        // Arrange
        var stdin = Encoding.ASCII.GetBytes("4");
        var staircase4x4 = $"   #{nl}  ##{nl} ###{nl}####";

        // Act
        var actual = Act(() => Solution.Main(Array.Empty<string>()), stdin);

        // Assert
        Assert.Equal(staircase4x4, actual);
    }

    [Fact]
    public void Main_Sample_PrintsStaircase()
    {
        // Arrange
        var stdin = Encoding.ASCII.GetBytes("6");
        var staircase6x6 = $"     #{nl}    ##{nl}   ###{nl}  ####{nl} #####{nl}######";

        // Act
        var actual = Act(() => Solution.Main(Array.Empty<string>()), stdin);

        // Assert
        Assert.Equal(staircase6x6, actual);
    }
}
