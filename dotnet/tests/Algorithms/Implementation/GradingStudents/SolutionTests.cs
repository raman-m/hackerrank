using RamanM.HackerRank.Algorithms.Implementation.GradingStudents;

namespace RamanM.HackerRank.Tests.Algorithms.Implementation.GradingStudents;

[Collection(nameof(Console))]
public class SolutionTests : ConsoleTest
{
    [Fact]
    public void Main_Example_ReturnsGraded()
    {
        // Arrange
        var stdin = $"3{nl}84{nl}29{nl}57";
        var graded = $"85{nl}29{nl}57{nl}";

        // Act
        var actual = ActOnOutput(() => Solution.Main(Array.Empty<string>()), stdin);

        // Assert
        Assert.Equal(graded, actual);
    }

    [Fact]
    public void Main_Sample_ReturnsGraded()
    {
        // Arrange
        var stdin = $"4{nl}73{nl}67{nl}38{nl}33";
        var graded = $"75{nl}67{nl}40{nl}33{nl}";

        // Act
        var actual = ActOnOutput(() => Solution.Main(Array.Empty<string>()), stdin);

        // Assert
        Assert.Equal(graded, actual);
    }
}
