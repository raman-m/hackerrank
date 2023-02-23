using RamanM.HackerRank.Algorithms.Warmup.BirthdayCakeCandles;

namespace RamanM.HackerRank.Tests.Algorithms.Warmup.BirthdayCakeCandles;

[Collection(nameof(Console))]
public class SolutionTests : ConsoleTest
{
    [Fact]
    public void Main_Example_ReturnsTwo()
    {
        // Arrange
        var stdin = $"4{nl}4 4 1 3";
        var two = "2" + nl;

        // Act
        var actual = ActOnOutput(() => Solution.Main(Array.Empty<string>()), stdin);

        // Assert
        Assert.Equal(two, actual);
    }

    [Fact]
    public void Main_Sample_ReturnsTwo()
    {
        // Arrange
        var stdin = $"4{nl}3 2 1 3";
        var two = "2" + nl;

        // Act
        var actual = ActOnOutput(() => Solution.Main(Array.Empty<string>()), stdin);

        // Assert
        Assert.Equal(two, actual);
    }
}
