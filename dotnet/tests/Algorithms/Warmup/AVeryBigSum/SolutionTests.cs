﻿using RamanM.HackerRank.Algorithms.Warmup.AVeryBigSum;

namespace RamanM.HackerRank.Tests.Algorithms.Warmup.AVeryBigSum;

[Collection(nameof(Console))]
public class SolutionTests : ConsoleTest
{
    [Fact]
    public void Main_Sample_ReturnsOutput()
    {
        // Arrange
        var stdin = $"5{nl}1000000001 1000000002 1000000003 1000000004 1000000005";
        var output = "5000000015" + nl;

        // Act
        var actual = ActOnOutput(() => Solution.Main(Array.Empty<string>()), stdin);

        // Assert
        Assert.Equal(output, actual);
    }
}
