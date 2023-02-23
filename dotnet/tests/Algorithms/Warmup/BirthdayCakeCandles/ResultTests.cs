using RamanM.HackerRank.Algorithms.Warmup.BirthdayCakeCandles;

namespace RamanM.HackerRank.Tests.Algorithms.Warmup.BirthdayCakeCandles;

public class ResultTests
{
    [Fact]
    public void BirthdayCakeCandles_Example_ReturnsTwo()
    {
        // Arrange
        List<int> candles = new List<int> { 4, 4, 1, 3 };
        const int two = 2;

        // Act
        int actual = Result.birthdayCakeCandles(candles);

        // Assert
        Assert.Equal(two, actual);
    }

    [Fact]
    public void BirthdayCakeCandles_Sample_ReturnsTwo()
    {
        // Arrange
        List<int> candles = new List<int> { 3, 2, 1, 3 };
        const int two = 2;

        // Act
        int actual = Result.birthdayCakeCandles(candles);

        // Assert
        Assert.Equal(two, actual);
    }
}
