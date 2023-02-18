using RamanM.HackerRank.Algorithms.Warmup.CompareTheTriplets;

namespace RamanM.HackerRank.Tests.Algorithms.Warmup.CompareTheTriplets;

public class ResultTests
{
    [Fact]
    public void CompareTriplets_Example_ReturnsOneAndOne()
    {
        // Arrange
        var a = new List<int>() { 1, 2, 3 }; // a = [1, 2, 3]
        var b = new List<int>() { 3, 2, 1 }; // b = [3, 2, 1]
        var oneAndOne = new List<int> { 1, 1 };

        // Act
        var actual = Result.compareTriplets(a, b);

        // Assert
        Assert.NotNull(actual);
        Assert.Equal(2, actual.Count);
        Assert.Equal(oneAndOne[0], actual[0]);
        Assert.Equal(oneAndOne[1], actual[1]);
    }

    [Fact]
    public void CompareTriplets_Sample0_ReturnsOneAndOne()
    {
        // Arrange
        var a = new List<int>() { 5, 6, 7 }; // a = [5 6 7]
        var b = new List<int>() { 3, 6, 10 }; // b = [3 6 10]
        var oneAndOne = new List<int> { 1, 1 };

        // Act
        var actual = Result.compareTriplets(a, b);

        // Assert
        Assert.NotNull(actual);
        Assert.Equal(2, actual.Count);
        Assert.Equal(oneAndOne[0], actual[0]);
        Assert.Equal(oneAndOne[1], actual[1]);
    }

    [Fact]
    public void CompareTriplets_Sample1_ReturnsTwoAndOne()
    {
        // Arrange
        var a = new List<int>() { 17, 28, 30 }; // a = [17 28 30]
        var b = new List<int>() { 99, 16, 8 }; // b = [99 16 8]
        var twoAndOne = new List<int> { 2, 1 };

        // Act
        var actual = Result.compareTriplets(a, b);

        // Assert
        Assert.NotNull(actual);
        Assert.Equal(2, actual.Count);
        Assert.Equal(twoAndOne[0], actual[0]);
        Assert.Equal(twoAndOne[1], actual[1]);
    }
}
