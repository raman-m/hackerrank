using RamanM.HackerRank.Algorithms.Warmup.TimeConversion;

namespace RamanM.HackerRank.Tests.Algorithms.Warmup.TimeConversion;

[Collection(nameof(Console))]
public class SolutionTests : ConsoleTest
{
    [Theory]
    [InlineData("12:01:00PM", "12:01:00")]
    [InlineData("12:01:00AM", "00:01:00")]
    public void Main_Example_Returns24hourFormat(string stdin, string expected)
    {
        // Arrange, Act
        var actual = ActOnOutput(() => Solution.Main(Array.Empty<string>()), stdin);

        // Assert
        Assert.Equal(expected + nl, actual);
    }

    [Fact]
    public void Main_Sample_Returns24hourFormat()
    {
        // Arrange
        var stdin = "07:05:45PM";
        var time24hour = "19:05:45" + nl;

        // Act
        var actual = ActOnOutput(() => Solution.Main(Array.Empty<string>()), stdin);

        // Assert
        Assert.Equal(time24hour, actual);
    }
}
