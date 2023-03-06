using RamanM.HackerRank.DataStructures.Arrays.ArraysDS;

namespace RamanM.HackerRank.Tests.DataStructures.Arrays.ArraysDS;

[Collection(nameof(Console))]
public class SolutionTests : ConsoleTest
{
    [Fact]
    public void Main_Example_ReturnsReversedArray()
    {
        // Arrange
        var stdin = $"3{nl}1 2 3";
        var reversed = "3 2 1" + nl;

        // Act
        var actual = ActOnOutput(() => Solution.Main(Array.Empty<string>()), stdin);

        // Assert
        Assert.Equal(reversed, actual);
    }

    [Fact]
    public void Main_Sample_ReturnsReversedArray()
    {
        // Arrange
        var stdin = $"4{nl}1 4 3 2";
        var reversed = "2 3 4 1" + nl;

        // Act
        var actual = ActOnOutput(() => Solution.Main(Array.Empty<string>()), stdin);

        // Assert
        Assert.Equal(reversed, actual);
    }
}
