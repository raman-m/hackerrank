using RamanM.HackerRank.Algorithms.Warmup.MiniMaxSum;

namespace RamanM.HackerRank.Tests.Algorithms.Warmup.MiniMaxSum;

[Collection(nameof(Console))]
public class ResultTests : ConsoleTest
{
    [Fact]
    public void MiniMaxSum_Example_PrintsSums()
    {
        // Arrange
        const int n = 5;
        var arr = new List<int>(n) { 1, 3, 5, 7, 9 };
        string minMax = "16 24";

        // Act
        var actual = Act(() => Result.miniMaxSum(arr));

        // Assert
        Assert.Equal(minMax, actual);
    }

    [Fact]
    public void MiniMaxSum_Sample_PrintsSums()
    {
        // Arrange
        const int n = 5;
        var arr = new List<int>(n) { 1, 2, 3, 4, 5 };
        string minMax = "10 14";

        // Act
        var actual = Act(() => Result.miniMaxSum(arr));

        // Assert
        Assert.Equal(minMax, actual);
    }
}
