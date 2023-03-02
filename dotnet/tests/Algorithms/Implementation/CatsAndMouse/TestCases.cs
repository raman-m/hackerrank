using RamanM.HackerRank.Algorithms.Implementation.CatsAndMouse;

namespace RamanM.HackerRank.Tests.Algorithms.Implementation.CatsAndMouse;

[Collection(nameof(Console))]
public class TestCases : TestCase
{
    [Theory]
    [InlineData("00")]
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
