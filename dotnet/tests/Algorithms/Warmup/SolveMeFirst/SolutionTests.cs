using RamanM.HackerRank.Algorithms.Warmup.SolveMeFirst;

namespace RamanM.HackerRank.Tests.Algorithms.Warmup.SolveMeFirst;

public class SolutionTests
{
    [Fact]
    public void SolveMeFirst_PositiveNumbers_ReturnsPositiveSum()
    {
        var actual = Solution.solveMeFirst(1, 3);

        Assert.True(actual > 0);
        Assert.Equal(4, actual);
    }

    [Fact]
    public void SolveMeFirst_NegativeNumbers_ReturnsNegativeSum()
    {
        var actual = Solution.solveMeFirst(-1, -3);

        Assert.True(actual < 0);
        Assert.Equal(-4, actual);
    }

    [Fact]
    public void SolveMeFirst_SomeNumbers_ReturnsSum()
    {
        // Arrange
        var numbers = new int[]
        {
            DateTime.Now.Second,
            DateTime.Now.Millisecond / 100
        };
        int expected = numbers.Sum();

        // Act
        var actual = Solution.solveMeFirst(numbers.First(), numbers.Last());

        // Assert
        Assert.Equal(expected, actual);
    }
}
