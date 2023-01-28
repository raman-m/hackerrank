using RamanM.HackerRank.Algorithms.Implementation.SalesByMatch;

namespace RamanM.HackerRank.Tests.Algorithms.Implementation.SalesByMatch;

[Collection(nameof(TestCases))]
public class TestCases : TestCase
{
    [Theory]
    [InlineData("00")]
    [InlineData("08")]
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
