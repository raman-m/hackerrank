using RamanM.HackerRank.Algorithms.Warmup.SimpleArraySum;

namespace RamanM.HackerRank.Tests.Algorithms.Warmup.SimpleArraySum;

public class ResultTests
{
    [Fact]
    public void SimpleArraySum_Example_ReturnsSum()
    {
        // Arrange
        var ar = new List<int>() { 1, 2, 3 };
        const int six = 6;

        // Act
        var actual = Result.simpleArraySum(ar);

        // Assert
        Assert.Equal(six, actual);
    }

    [Fact]
    public void SimpleArraySum_Sample_ReturnsSum()
    {
        // Arrange
        const int n = 6;
        var ar = new List<int>(n) { 1, 2, 3, 4, 10, 11 };
        const int sum = 31;

        // Act TODO Implement call of private class via reflection
        var actual = Result.simpleArraySum(ar);

        // Assert
        Assert.Equal(sum, actual);
    }
}
