﻿using RamanM.HackerRank.Algorithms.Warmup.MiniMaxSum;

namespace RamanM.HackerRank.Tests.Algorithms.Warmup.MiniMaxSum;

[Collection(nameof(Console))]
public class TestCases : TestCase
{
    [Theory]
    [InlineData("00")]
    [InlineData("14")]
    public void Solution_Main_TestCaseXX(string code)
    {
        // Arrange
        var expected = Setup(code);

        // Act
        var actual = Act(() => Solution.Main(Array.Empty<string>()), true);

        // Assert
        Assert.Equal(expected, actual);
    }
}
