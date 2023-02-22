﻿using RamanM.HackerRank.Algorithms.Warmup.SolveMeFirst;

namespace RamanM.HackerRank.Tests.Algorithms.Warmup.SolveMeFirst;

[Collection(nameof(Console))]
public class TestCases : TestCase
{
    [Theory]
    [InlineData("00")]
    [InlineData("01")]
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
