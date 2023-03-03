using RamanM.HackerRank.Algorithms.Implementation.RepeatedString;

namespace RamanM.HackerRank.Tests.Algorithms.Implementation.RepeatedString;

public class ResultTests
{
    [Fact]
    public void RepeatedString_Example_ReturnsFour()
    {
        // Arrange
        const long n = 10;
        const string s = "abcac";
        const long four = 4;

        // Act
        long actual = Result.repeatedString(s, n);

        // Assert
        Assert.Equal(four, actual);
    }

    [Fact]
    public void RepeatedString_Sample0_ReturnsSeven()
    {
        // Arrange
        const long n = 10;
        const string s = "aba";
        const long seven = 7;

        // Act
        long actual = Result.repeatedString(s, n);

        // Assert
        Assert.Equal(seven, actual);
    }

    [Fact]
    public void RepeatedString_Sample1_ReturnsTrillion()
    {
        // Arrange
        const long n = 1000000000000;
        const string s = "a";
        const long trillion = 1000000000000;

        // Act
        long actual = Result.repeatedString(s, n);

        // Assert
        Assert.Equal(trillion, actual);
    }
}
