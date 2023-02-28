using RamanM.HackerRank.Algorithms.Implementation.ElectronicsShop;

namespace RamanM.HackerRank.Tests.Algorithms.Implementation.ElectronicsShop;

public class SolutionGetMoneySpentTests
{
    [Fact]
    public void GetMoneySpent_Example_ReturnsFiftyEight()
    {
        //  Act
        const int budget = 60, n = 3, m = 3;
        var keyboards = new int[n] { 40, 50, 60 };
        var drives = new int[m] { 5, 8, 12 };
        const int fiftyEight = 58;

        // Arrange
        int actual = Solution.getMoneySpent(keyboards, drives, budget);

        // Assert
        Assert.Equal(fiftyEight, actual);
    }

    [Fact]
    public void GetMoneySpent_Sample0_ReturnsNine()
    {
        //  Act
        const int budget = 10, n = 2, m = 3;
        var keyboards = new int[n] { 3, 1 };
        var drives = new int[m] { 5, 2, 8 };
        const int nine = 9;

        // Arrange
        int actual = Solution.getMoneySpent(keyboards, drives, budget);

        // Assert
        Assert.Equal(nine, actual);
    }

    [Fact]
    public void GetMoneySpent_Sample1_ReturnsNothing()
    {
        //  Act
        const int budget = 5, n = 1, m = 1;
        var keyboards = new int[n] { 4 };
        var drives = new int[m] { 5 };
        const int nothing = -1;

        // Arrange
        int actual = Solution.getMoneySpent(keyboards, drives, budget);

        // Assert
        Assert.Equal(nothing, actual);
    }
}

[Collection(nameof(Console))]
public class SolutionTests : ConsoleTest
{
    [Fact]
    public void Main_Example_ReturnsFiftyEight()
    {
        // Arrange
        var stdin = $"60 3 3{nl}40 50 60{nl}5 8 12";
        var fiftyEight = "58" + nl;

        // Arrange
        var actual = ActOnOutput(() => Solution.Main(Array.Empty<string>()), stdin);

        // Assert
        Assert.Equal(fiftyEight, actual);
    }

    [Fact]
    public void Main_Sample0_ReturnsNine()
    {
        // Arrange
        var stdin = $"10 2 3{nl}3 1{nl}5 2 8";
        var nine = "9" + nl;

        // Act
        var actual = ActOnOutput(() => Solution.Main(Array.Empty<string>()), stdin);

        // Assert
        Assert.Equal(nine, actual);
    }

    [Fact]
    public void Main_Sample1_ReturnsNothing()
    {
        // Arrange
        var stdin = $"5 1 1{nl}4{nl}5";
        var nothing = "-1" + nl;

        // Act
        var actual = ActOnOutput(() => Solution.Main(Array.Empty<string>()), stdin);

        // Assert
        Assert.Equal(nothing, actual);
    }
}
