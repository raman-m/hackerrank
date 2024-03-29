﻿using RamanM.HackerRank.Algorithms.Warmup.SimpleArraySum;

namespace RamanM.HackerRank.Tests.Algorithms.Warmup.SimpleArraySum;

[Collection(nameof(Console))]
public class SolutionTests : ConsoleTest
{
    [Fact]
    public void Main_Example_ReturnsSum()
    {
        // Arrange
        var stdin = $"3{nl}1 2 3";
        var expected = "6" + nl;

        // Act
        var actual = ActOnOutput(() => Solution.Main(Array.Empty<string>()), stdin);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Main_Sample_ReturnsSum()
    {
        // Arrange
        var stdin = $"6{nl}1 2 3 4 10 11";
        var expected = "31" + nl;

        // Act
        var actual = ActOnOutput(() => Solution.Main(Array.Empty<string>()), stdin);

        // Assert
        Assert.Equal(expected, actual);
    }
}
