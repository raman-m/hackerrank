using RamanM.HackerRank.Algorithms.Warmup.TimeConversion;

namespace RamanM.HackerRank.Tests.Algorithms.Warmup.TimeConversion;

[Collection(nameof(Console))]
public class TestCases : TestCase
{
    [Theory]
    [InlineData("00")]
    [InlineData("01")]
    [InlineData("02")]
    public void Solution_Main_TestCaseXX(string code)
    {
        // Arrange
        var expected = Setup(code);

        // Act
        var actual = Act(() => Solution.Main(Array.Empty<string>()));

        // Assert
        Assert.Equal(expected, actual);
    }
}
