using RamanM.HackerRank.DataStructures.LinkedLists.InsertANodeAtTheHeadOfALinkedList;
using static RamanM.HackerRank.DataStructures.LinkedLists.InsertANodeAtTheHeadOfALinkedList.Solution;

namespace RamanM.HackerRank.Tests.DataStructures.LinkedLists.InsertANodeAtTheHeadOfALinkedList;

public class SolutionUnitTests
{
    [Fact]
    public void InsertNodeAtHead_Sample_ReturnsNodeAtHead()
    {
        // Arrange
        SinglyLinkedList list = new SinglyLinkedList();
        var data = new List<int> { 383, 484, 392, 975, 321 };

        foreach (int i in data)
        {
            // Act
            var actual = Solution.insertNodeAtHead(list.head, i);
            list.head = actual;

            // Assert
            Assert.NotNull(actual);
            Assert.Equal(i, actual.data);
        }

        // Assert
        Assert.Equal(data.Count, Count(list.head));
        Assert.Equal(data.Last(), list.head.data);
    }

    private int Count(SinglyLinkedListNode node)
    {
        int count = 0;
        while (node != null)
        {
            count++;
            node = node.next;
        }
        return count;
    }
}

[Collection(nameof(Console))]
public class SolutionTests : ConsoleTest
{
    [Fact]
    public void Main_Sample_PrintsSinglyLinkedList()
    {
        // Arrange
        var stdin = $"5{nl}383{nl}484{nl}392{nl}975{nl}321";
        var printed = $"321{nl}975{nl}392{nl}484{nl}383{nl}";

        // Act
        var actual = ActOnOutput(() => Solution.Main(Array.Empty<string>()), stdin);

        // Assert
        Assert.Equal(printed, actual);
    }
}
