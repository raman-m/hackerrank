using RamanM.HackerRank.DataStructures.Stacks.MaximumElement;

namespace RamanM.HackerRank.Tests.DataStructures.Stacks.MaximumElement;

[Collection(nameof(Console))]
public class TestCases : TestCase
{
    [Theory]
    [InlineData("00")]
    [InlineData("03")]
    [InlineData("06")]
    [InlineData("17")]
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
