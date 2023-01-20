using RamanM.HackerRank.Algorithms.Warmup.SolveMeFirst;

namespace RamanM.HackerRank.Tests.Algorithms.Warmup;

public class SolveMeFirstTests
{
    [Fact]
    public void SampleTestCase0()
    {
        var actual = Solution.solveMeFirst(2, 3);

        Assert.Equal(5, actual);
    }

    [Fact]
    public void SampleTestCase1()
    {
        var actual = Solution.solveMeFirst(100, 1000);

        Assert.Equal(1100, actual);
    }
}
