using RamanM.HackerRank.DataStructures.Arrays.ArraysDS;

namespace RamanM.HackerRank.Tests.DataStructures.Arrays.ArraysDS;

public class ResultTests
{
    [Fact]
    public void ReverseArray_Example_ReturnsReversedArray()
    {
        // Arrange
        const int N = 3;
        var A = new List<int>(N) { 1, 2, 3 };
        var reversed = new List<int>(N) { 3, 2, 1 };

        // Act
        var actual = Result.reverseArray(A);

        // Assert
        Assert.Equal(reversed, actual);
    }

    [Fact]
    public void ReverseArray_Sample_ReturnsReversedArray()
    {
        // Arrange
        const int N = 4;
        var A = new List<int>(N) { 1, 4, 3, 2 };
        var reversed = new List<int>(N) { 2, 3, 4, 1 };

        // Act
        var actual = Result.reverseArray(A);

        // Assert
        Assert.Equal(reversed, actual);
    }
}
