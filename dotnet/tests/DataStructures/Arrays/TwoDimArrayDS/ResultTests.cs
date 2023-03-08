using RamanM.HackerRank.DataStructures.Arrays.TwoDimArrayDS;

namespace RamanM.HackerRank.Tests.DataStructures.Arrays.TwoDimArrayDS;

public class ResultTests
{
    [Fact]
    public void HourglassSum_Example0_ReturnsSeven()
    {
        // Arrange
        const int n = 6;
        var arr = new List<List<int>>(n)
        {
            new List<int>(n) { 1, 1, 1, 0, 0, 0 },
            new List<int>(n) { 0, 1, 0, 0, 0, 0 },
            new List<int>(n) { 1, 1, 1, 0, 0, 0 },
            new List<int>(n) { 0, 0, 0, 0, 0, 0 },
            new List<int>(n) { 0, 0, 0, 0, 0, 0 },
            new List<int>(n) { 0, 0, 0, 0, 0, 0 },
        };
        const int seven = 7;

        // Act
        int actual = Result.hourglassSum(arr);

        // Assert
        Assert.Equal(seven, actual);
    }

    [Fact]
    public void HourglassSum_Example_ReturnsTwentyEight()
    {
        // Arrange
        const int n = 6;
        var arr = new List<List<int>>(n)
        {
            new List<int>(n) { -9, -9, -9,  1, 1, 1 },
            new List<int>(n) {  0, -9,  0,  4, 3, 2 },
            new List<int>(n) { -9, -9, -9,  1, 2, 3 },
            new List<int>(n) {  0,  0,  8,  6, 6, 0 },
            new List<int>(n) {  0,  0,  0, -2, 0, 0 },
            new List<int>(n) {  0,  0,  1,  2, 4, 0 },
        };
        const int twentyEight = 28;

        // Act
        int actual = Result.hourglassSum(arr);

        // Assert
        Assert.Equal(twentyEight, actual);
    }

    [Fact]
    public void HourglassSum_Sample_ReturnsNineteen()
    {
        // Arrange
        const int n = 6;
        var arr = new List<List<int>>(n)
        {
            new List<int>(n) { 1, 1, 1, 0, 0, 0 },
            new List<int>(n) { 0, 1, 0, 0, 0, 0 },
            new List<int>(n) { 1, 1, 1, 0, 0, 0 },
            new List<int>(n) { 0, 0, 2, 4, 4, 0 },
            new List<int>(n) { 0, 0, 0, 2, 0, 0 },
            new List<int>(n) { 0, 0, 1, 2, 4, 0 },
        };
        const int nineteen = 19;

        // Act
        int actual = Result.hourglassSum(arr);

        // Assert
        Assert.Equal(nineteen, actual);
    }
}
