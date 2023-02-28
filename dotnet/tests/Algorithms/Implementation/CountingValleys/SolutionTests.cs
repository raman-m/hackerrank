using RamanM.HackerRank.Algorithms.Implementation.CountingValleys;

namespace RamanM.HackerRank.Tests.Algorithms.Implementation.CountingValleys;

[Collection(nameof(Console))]
public class SolutionTests : ConsoleTest
{
    [Fact]
    public void Main_Example_ReturnsOneValley()
    {
        // Arrange
        var stdin = $"8{nl}DDUUUUDD";
        var oneValley = "1" + nl;

        // Arrange
        var actual = ActOnOutput(() => Solution.Main(Array.Empty<string>()), stdin);

        // Assert
        Assert.Equal(oneValley, actual);
    }

    [Fact]
    public void Main_Sample_ReturnsOneValley()
    {
        // Arrange
        var stdin = $"8{nl}UDDDUDUU";
        var oneValley = "1" + nl;

        // Act
        var actual = ActOnOutput(() => Solution.Main(Array.Empty<string>()), stdin);

        // Assert
        Assert.Equal(oneValley, actual);
    }
}
