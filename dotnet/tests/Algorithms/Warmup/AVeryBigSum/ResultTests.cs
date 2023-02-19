using RamanM.HackerRank.Algorithms.Warmup.AVeryBigSum;

namespace RamanM.HackerRank.Tests.Algorithms.Warmup.AVeryBigSum;

public class ResultTests
{
    [Fact]
    public void AVeryBigSum_Sample_ReturnsOutput()
    {
        // Arrange
        const int n = 5;
        var ar = new List<long>(n) { 1000000001, 1000000002, 1000000003, 1000000004, 1000000005 };
        long output = 5000000015;

        // Act
        long actual = Result.aVeryBigSum(ar);

        // Assert
        Assert.Equal(output, actual);
    }
}
