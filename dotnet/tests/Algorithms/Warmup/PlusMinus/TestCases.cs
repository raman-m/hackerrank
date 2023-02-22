using RamanM.HackerRank.Algorithms.Warmup.PlusMinus;

namespace RamanM.HackerRank.Tests.Algorithms.Warmup.PlusMinus;

[Collection(nameof(Console))]
public class TestCases : TestCase
{
    [Theory]
    [InlineData("01")]
    [InlineData("11")]
    public void Solution_Main_TestCaseXX(string code)
    {
        // Arrange
        var expected = Setup(code);

        // Act
        var actual = Act(() => Solution.Main(Array.Empty<string>()), true);

        // Assert
        Assert.Equal(expected, actual);
    }
}
