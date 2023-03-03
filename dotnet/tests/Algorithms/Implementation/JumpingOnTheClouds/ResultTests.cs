using RamanM.HackerRank.Algorithms.Implementation.JumpingOnTheClouds;

namespace RamanM.HackerRank.Tests.Algorithms.Implementation.JumpingOnTheClouds;

public class ResultTests
{
    [Fact]
    public void JumpingOnClouds_Example_ReturnsThree()
    {
        // Arrange
        const int n = 7;
        var clouds = new List<int>(n) { 0, 1, 0, 0, 0, 1, 0 };
        const int three = 3;

        // Act
        int actual = Result.jumpingOnClouds(clouds);

        // Assert
        Assert.Equal(three, actual);
    }

    [Fact]
    public void JumpingOnClouds_Sample0_ReturnsFour()
    {
        // Arrange
        const int n = 7;
        var clouds = new List<int>(n) { 0, 0, 1, 0, 0, 1, 0 };
        const int four = 4;

        // Act
        int actual = Result.jumpingOnClouds(clouds);

        // Assert
        Assert.Equal(four, actual);
    }

    [Fact]
    public void JumpingOnClouds_Sample1_ReturnsThree()
    {
        // Arrange
        const int n = 6;
        var clouds = new List<int>(n) { 0, 0, 0, 0, 1, 0 };
        const int three = 3;

        // Act
        int actual = Result.jumpingOnClouds(clouds);

        // Assert
        Assert.Equal(three, actual);
    }
}
