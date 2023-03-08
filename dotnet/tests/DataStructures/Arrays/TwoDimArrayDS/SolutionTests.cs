using RamanM.HackerRank.DataStructures.Arrays.TwoDimArrayDS;

namespace RamanM.HackerRank.Tests.DataStructures.Arrays.TwoDimArrayDS;

[Collection(nameof(Console))]
public class SolutionTests : ConsoleTest
{
    [Fact]
    public void Main_Example0_ReturnsSeven()
    {
        // Arrange
        var stdin = @"1 1 1 0 0 0
0 1 0 0 0 0
1 1 1 0 0 0
0 0 0 0 0 0
0 0 0 0 0 0
0 0 0 0 0 0";
        var seven = "7" + nl;

        // Act
        var actual = ActOnOutput(() => Solution.Main(Array.Empty<string>()), stdin);

        // Assert
        Assert.Equal(seven, actual);
    }

    [Fact]
    public void Main_Example_ReturnsTwentyEight()
    {
        // Arrange
        var stdin = @"-9 -9 -9 1 1 1
0 -9 0 4 3 2
-9 -9 -9 1 2 3
0 0 8 6 6 0
0 0 0 -2 0 0
0 0 1 2 4 0";
        var twentyEight = "28" + nl;

        // Act
        var actual = ActOnOutput(() => Solution.Main(Array.Empty<string>()), stdin);

        // Assert
        Assert.Equal(twentyEight, actual);
    }


    [Fact]
    public void Main_Sample_ReturnsNineteen()
    {
        // Arrange
        var stdin = @"1 1 1 0 0 0
0 1 0 0 0 0
1 1 1 0 0 0
0 0 2 4 4 0
0 0 0 2 0 0
0 0 1 2 4 0";
        var nineteen = "19" + nl;

        // Act
        var actual = ActOnOutput(() => Solution.Main(Array.Empty<string>()), stdin);

        // Assert
        Assert.Equal(nineteen, actual);
    }

    [Fact]
    public void Main_TestCase3_ReturnsMinusSix()
    {
        // Arrange
        var stdin = @"-1 -1 0 -9 -2 -2
-2 -1 -6 -8 -2 -5
-1 -1 -1 -2 -3 -4
-1 -9 -2 -4 -4 -5
-7 -3 -3 -2 -9 -9
-1 -3 -1 -2 -4 -5";
        var minusSix = "-6" + nl;

        // Act
        var actual = ActOnOutput(() => Solution.Main(Array.Empty<string>()), stdin);

        // Assert
        Assert.Equal(minusSix, actual);
    }
}
