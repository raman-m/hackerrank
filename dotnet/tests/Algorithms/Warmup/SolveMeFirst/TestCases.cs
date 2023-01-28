using RamanM.HackerRank.Algorithms.Warmup.SolveMeFirst;

namespace RamanM.HackerRank.Tests.Algorithms.Warmup.SolveMeFirst;

[Collection(nameof(TestCases))]
public class TestCases : TestCase
{
    [Theory]
    [InlineData("00")]
    [InlineData("01")]
    public void Solution_Main_TestCaseXX(string code)
    {
        // Arrange
        var expected = Setup(code);

        // Act
        var actual = ActInConsole(() => Solution.Main(Array.Empty<string>()));

        // Assert
        Assert.Equal(expected, actual);
    }
}
