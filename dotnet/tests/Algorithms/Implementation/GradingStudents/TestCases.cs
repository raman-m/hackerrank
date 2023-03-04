using RamanM.HackerRank.Algorithms.Implementation.GradingStudents;

namespace RamanM.HackerRank.Tests.Algorithms.Implementation.GradingStudents;

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
