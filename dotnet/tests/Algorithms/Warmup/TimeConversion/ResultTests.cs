using RamanM.HackerRank.Algorithms.Warmup.TimeConversion;

namespace RamanM.HackerRank.Tests.Algorithms.Warmup.TimeConversion;

public class ResultTests
{
    [Theory]
    [InlineData("12:01:00PM", "12:01:00")]
    [InlineData("12:01:00AM", "00:01:00")]
    public void TimeConversion_Example_Returns24hourFormat(string time12hour, string expected)
    {
        // Arrange, Act
        string actual = Result.timeConversion(time12hour);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void TimeConversion_Sample_Returns24hourFormat()
    {
        // Arrange
        const string time12hour = "07:05:45PM";

        // Act
        string actual = Result.timeConversion(time12hour);

        // Assert
        Assert.Equal("19:05:45", actual);
    }
}
