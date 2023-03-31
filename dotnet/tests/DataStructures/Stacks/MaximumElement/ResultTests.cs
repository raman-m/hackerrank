using RamanM.HackerRank.DataStructures.Stacks.MaximumElement;

namespace RamanM.HackerRank.Tests.DataStructures.Stacks.MaximumElement;

public class ResultTests
{
    [Fact]
    public void GetMax_Sample_Returns26And91()
    {
        // Arrange
        const int n = 10;
        var operations = new List<string>(n) { "1 97", "2", "1 20", "2", "1 26", "1 20", "2", "3", "1 91", "3" };
        var expected = new List<int> { 26, 91 };

        // Act
        var actual = Result.GetMax(operations);

        // Assert
        Assert.NotNull(actual);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void GetMax_TestCase03_Returns100()
    {
        // Arrange
        const int n = 68;
        string lines = @"68
1 1
1 44
3
3
2
3
3
1 3
1 37
2
3
1 29
3
1 73
1 51
3
3
3
1 70
3
1 8
2
1 49
1 56
1 81
2
1 59
1 44
2
3
3
2
3
3
1 4
3
1 89
2
1 37
1 50
1 64
2
1 49
1 35
1 85
3
1 41
2
3
3
1 86
3
1 60
1 8
3
1 100
3
1 83
3
1 47
2
1 78
2
1 55
1 97
2
3
1 40";
        lines = lines.Remove(0, n.ToString().Length + Environment.NewLine.Length);
        var operations = lines.Split(Environment.NewLine);
        lines = @"44
44
1
1
3
29
73
73
73
73
73
73
73
73
73
85
85
85
86
86
100
100
100";

        var expected = lines.Split(Environment.NewLine)
            .Select(int.Parse).ToList();

        // Act
        var actual = Result.GetMax(operations.ToList());

        // Assert
        Assert.NotNull(actual);
        Assert.Equal(expected, actual);
        Assert.Equal(100, actual.Last());
    }
}
