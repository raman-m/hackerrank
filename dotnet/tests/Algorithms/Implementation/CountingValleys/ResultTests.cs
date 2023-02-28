using RamanM.HackerRank.Algorithms.Implementation.CountingValleys;

namespace RamanM.HackerRank.Tests.Algorithms.Implementation.CountingValleys;

public class ResultTests
{
    [Fact]
    public void CountingValleys_Example_ReturnsOneValley()
    {
        //  Act
        const int steps = 8;
        const string path = "DDUUUUDD";
        const int oneValley = 1;

        // Arrange
        int actual = Result.countingValleys(steps, path);

        // Assert
        Assert.Equal(oneValley, actual);
    }

    [Fact]
    public void CountingValleys_Sample_ReturnsOneValley()
    {
        //  Act
        const int steps = 8;
        const string path = "UDDDUDUU";
        const int oneValley = 1;

        // Arrange
        int actual = Result.countingValleys(steps, path);

        // Assert
        Assert.Equal(oneValley, actual);
    }

    [Fact]
    public void CountingValleys_MountainOnly_ReturnsNoValleys()
    {
        //  Act
        const int steps = 2;
        const string path = "UD";
        const int noValleys = 0;

        // Arrange
        int actual = Result.countingValleys(steps, path);

        // Assert
        Assert.Equal(noValleys, actual);
    }

    [Fact]
    public void CountingValleys_OneValleyOnly_ReturnsOneValley()
    {
        //  Act
        const int steps = 2;
        const string path = "DU";
        const int oneValley = 1;

        // Arrange
        int actual = Result.countingValleys(steps, path);

        // Assert
        Assert.Equal(oneValley, actual);
    }
}
