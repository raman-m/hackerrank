using RamanM.HackerRank.Algorithms.Implementation.GradingStudents;

namespace RamanM.HackerRank.Tests.Algorithms.Implementation.GradingStudents;

public class ResultTests
{
    [Fact]
    public void GradingStudents_Example_ReturnsGraded()
    {
        // Arrange
        const int n = 3;
        var grades = new List<int>(n) { 84, 29, 57 };
        var graded = new List<int>(n) { 85, 29, 57 };

        // Act
        var actual = Result.gradingStudents(grades);

        // Assert
        Assert.Equal(graded, actual);
    }

    [Fact]
    public void GradingStudents_Sample_ReturnsGraded()
    {
        // Arrange
        const int n = 4;
        var grades = new List<int>(n) { 73, 67, 38, 33 };
        var graded = new List<int>(n) { 75, 67, 40, 33 };

        // Act
        var actual = Result.gradingStudents(grades);

        // Assert
        Assert.Equal(graded, actual);
    }
}
