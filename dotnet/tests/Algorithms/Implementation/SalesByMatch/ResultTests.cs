using RamanM.HackerRank.Algorithms.Implementation.SalesByMatch;

namespace RamanM.HackerRank.Tests.Algorithms.Implementation.SalesByMatch;

public class ResultTests
{
    [Fact]
    public void SockMerchant_Example_ReturnsTwoPairs()
    {
        // Arrange
        const int n = 7;
        var ar = new List<int>(n) { 1, 2, 1, 2, 1, 3, 2 };
        const int two = 2;

        // Act TODO Implement call of private class via reflection
        var actual = Result.sockMerchant(n, ar);

        // Assert
        Assert.Equal(two, actual);
    }

    [Fact]
    public void SockMerchant_Sample_ReturnsThreePairs()
    {
        // Arrange
        const int n = 9;
        var ar = new List<int>(n) { 10, 20, 20, 10, 10, 30, 50, 10, 20 };
        const int three = 3;

        // Act TODO Implement call of private class via reflection
        var actual = Result.sockMerchant(n, ar);

        // Assert
        Assert.Equal(three, actual);
    }
}
