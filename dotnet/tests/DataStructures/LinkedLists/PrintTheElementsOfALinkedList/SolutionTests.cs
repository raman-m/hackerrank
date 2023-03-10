using RamanM.HackerRank.DataStructures.LinkedLists.PrintTheElementsOfALinkedList;
using static RamanM.HackerRank.DataStructures.LinkedLists.PrintTheElementsOfALinkedList.Solution;

namespace RamanM.HackerRank.Tests.DataStructures.LinkedLists.PrintTheElementsOfALinkedList;

[Collection(nameof(Console))]
public class SolutionTests : ConsoleTest
{
    [Fact]
    public void PrintLinkedList_Sample_PrintsDataOfTwoNodes()
    {
        // Arrange
        var list = new SinglyLinkedList();
        list.InsertNode(16);
        list.InsertNode(13);

        string twoNodes = $"16{nl}13{nl}";

        // Act
        var actual = Act(() => Solution.printLinkedList(list.head));

        // Assert
        Assert.Equal(twoNodes, actual);
    }

    [Fact]
    public void Main_Sample_PrintsDataOfTwoNodes()
    {
        // Arrange
        var stdin = Encoding.ASCII.GetBytes($"2{nl}16{nl}13");
        var twoNodes = $"16{nl}13{nl}";

        // Act
        var actual = Act(() => Solution.Main(Array.Empty<string>()), stdin);

        // Assert
        Assert.Equal(twoNodes, actual);
    }
}
