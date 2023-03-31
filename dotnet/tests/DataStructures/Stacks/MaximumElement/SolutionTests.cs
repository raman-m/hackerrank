using RamanM.HackerRank.DataStructures.Stacks.MaximumElement;

namespace RamanM.HackerRank.Tests.DataStructures.Stacks.MaximumElement;

[Collection(nameof(Console))]
public class SolutionTests : ConsoleTest
{
    [Fact]
    public void Main_Sample_Returns26And91()
    {
        // Arrange
        var stdin = $"10{nl}1 97{nl}2{nl}1 20{nl}2{nl}1 26{nl}1 20{nl}2{nl}3{nl}1 91{nl}3";
        var expected = $"26{nl}91{nl}";

        // Act
        var actual = ActOnOutput(() => Solution.Main(Array.Empty<string>()), stdin);

        // Assert
        Assert.Equal(expected, actual);
    }
}
