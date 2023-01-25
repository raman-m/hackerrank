using RamanM.HackerRank.Algorithms.Warmup.SolveMeFirst;

namespace RamanM.HackerRank.Tests.Algorithms.Warmup.SolveMeFirst;

public class TestCases
{
    [Theory]
    [InlineData("00")]
    [InlineData("01")]
    public void Solution_SolveMeFirst_SampleTestCaseXX(string code)
    {
        // Arrange
        var basePath = Path.Combine(Environment.CurrentDirectory, "Algorithms\\Warmup\\SolveMeFirst\\");
        var test = new TestCase(basePath);
        test.InputPath = $"input\\input{code}.txt";
        test.OutputPath = $"output\\output{code}.txt";
        var expected = File.ReadAllText(test.OutputPath);

        // Act
        test.ActInConsole(() => Solution.Main(Array.Empty<string>()));

        // Assert
        var actual = File.ReadAllText(test.TestResultPath).Trim(new char[] { '\t', '\n', '\r' });
        Assert.Equal(expected, actual);
    }
}
