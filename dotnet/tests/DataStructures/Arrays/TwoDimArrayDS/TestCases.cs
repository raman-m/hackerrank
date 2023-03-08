using RamanM.HackerRank.DataStructures.Arrays.TwoDimArrayDS;

namespace RamanM.HackerRank.Tests.DataStructures.Arrays.TwoDimArrayDS;

[Collection(nameof(Console))]
public class TestCases : TestCase
{
    [Theory]
    [InlineData("00")]
    [InlineData("01")]
    [InlineData("03")]
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
