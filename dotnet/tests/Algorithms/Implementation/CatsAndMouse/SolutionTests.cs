using RamanM.HackerRank.Algorithms.Implementation.CatsAndMouse;

namespace RamanM.HackerRank.Tests.Algorithms.Implementation.CatsAndMouse;

public class SolutionCatAndMouseTests
{
    [Fact]
    public void CatAndMouse_Example_CatBCatchesTheMouse()
    {
        // Arrange
        const int x = 2, y = 5, z = 4;

        // Act
        string actual = Solution.catAndMouse(x, y, z);

        // Assert
        Assert.Equal("Cat B", actual);
    }

    [Theory]
    [InlineData(1, 2, 3, "Cat B")]
    [InlineData(1, 3, 2, "Mouse C")]
    public void CatAndMouse_Sample_ReturnsCatsOrMouse(int x, int y, int z, string expected)
    {
        // Arrange, Act
        string actual = Solution.catAndMouse(x, y, z);

        // Assert
        Assert.Equal(expected, actual);
    }
}

[Collection(nameof(Console))]
public class SolutionTests : ConsoleTest
{
    [Fact]
    public void Main_Example_CatBCatchesTheMouse()
    {
        // Arrange
        var stdin = $"1{nl}2 5 4";
        var catB = "Cat B" + nl;

        // Arrange
        var actual = ActOnOutput(() => Solution.Main(Array.Empty<string>()), stdin);

        // Assert
        Assert.Equal(catB, actual);
    }

    [Fact]
    public void Main_Sample_ReturnsCatsOrMouse()
    {
        // Arrange
        var stdin = $"2{nl}1 2 3{nl}1 3 2";
        var nine = $"Cat B{nl}Mouse C{nl}";

        // Act
        var actual = ActOnOutput(() => Solution.Main(Array.Empty<string>()), stdin);

        // Assert
        Assert.Equal(nine, actual);
    }
}
