using RamanM.HackerRank.Algorithms.Implementation.RepeatedString;

namespace RamanM.HackerRank.Tests.Algorithms.Implementation.RepeatedString;

[Collection(nameof(Console))]
public class SolutionTests : ConsoleTest
{
    [Fact]
    public void Main_Example_ReturnsFour()
    {
        // Arrange
        var stdin = $"abcac{nl}10";
        var four = "4" + nl;

        // Act
        var actual = ActOnOutput(() => Solution.Main(Array.Empty<string>()), stdin);

        // Assert
        Assert.Equal(four, actual);
    }

    [Fact]
    public void Main_Sample0_ReturnsSeven()
    {
        // Arrange
        var stdin = $"aba{nl}10";
        var seven = "7" + nl;

        // Act
        var actual = ActOnOutput(() => Solution.Main(Array.Empty<string>()), stdin);

        // Assert
        Assert.Equal(seven, actual);
    }

    [Fact]
    public void Main_Sample1_ReturnsTrillion()
    {
        // Arrange
        var stdin = $"a{nl}1000000000000";
        var trillion = "1000000000000" + nl;

        // Act
        var actual = ActOnOutput(() => Solution.Main(Array.Empty<string>()), stdin);

        // Assert
        Assert.Equal(trillion, actual);
    }
}
