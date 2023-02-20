using RamanM.HackerRank.Algorithms.Warmup.DiagonalDifference;

namespace RamanM.HackerRank.Tests.Algorithms.Warmup.DiagonalDifference;

public class ResultTests
{
    [Fact]
    public void DiagonalDifference_Example_ReturnsMatrixModule()
    {
        // Arrange
        var arr = new List<List<int>>
        {
            new List<int> { 1, 2, 3 },
            new List<int> { 4, 5, 6 },
            new List<int> { 9, 8, 9 },
        };
        const int matrixModule = 2;

        // Act
        var actual = Result.diagonalDifference(arr);

        // Assert
        Assert.Equal(matrixModule, actual);
    }

    [Fact]
    public void DiagonalDifference_Sample_ReturnsMatrixModule()
    {
        // Arrange
        var arr = new List<List<int>>
        {
            new List<int> { 11, 2, 4 },
            new List<int> { 4, 5, 6 },
            new List<int> { 10, 8, -12 },
        };
        const int matrixModule = 15;

        // Act
        var actual = Result.diagonalDifference(arr);

        // Assert
        Assert.Equal(matrixModule, actual);
    }
}
