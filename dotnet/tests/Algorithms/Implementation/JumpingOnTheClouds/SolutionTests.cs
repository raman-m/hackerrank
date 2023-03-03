using RamanM.HackerRank.Algorithms.Implementation.JumpingOnTheClouds;

namespace RamanM.HackerRank.Tests.Algorithms.Implementation.JumpingOnTheClouds;

[Collection(nameof(Console))]
public class SolutionTests : ConsoleTest
{
    [Fact]
    public void Main_Example_ReturnsThree()
    {
        // Arrange
        var stdin = $"7{nl}0 1 0 0 0 1 0";
        var three = "3" + nl;

        // Act
        var actual = ActOnOutput(() => Solution.Main(Array.Empty<string>()), stdin);

        // Assert
        Assert.Equal(three, actual);
    }

    [Fact]
    public void Main_Sample0_ReturnsFour()
    {
        // Arrange
        var stdin = $"7{nl}0 0 1 0 0 1 0";
        var four = "4" + nl;

        // Act
        var actual = ActOnOutput(() => Solution.Main(Array.Empty<string>()), stdin);

        // Assert
        Assert.Equal(four, actual);
    }

    [Fact]
    public void Main_Sample1_ReturnsThree()
    {
        // Arrange
        var stdin = $"6{nl}0 0 0 0 1 0";
        var three = "3" + nl;

        // Act
        var actual = ActOnOutput(() => Solution.Main(Array.Empty<string>()), stdin);

        // Assert
        Assert.Equal(three, actual);
    }
}
