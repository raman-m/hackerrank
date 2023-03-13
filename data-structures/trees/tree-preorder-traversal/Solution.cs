namespace RamanM.HackerRank.DataStructures.Trees.TreePreorderTraversal;

using System;
using System.Collections.Generic;
using System.IO;

public class Node
{
    public Node left;
    public Node right;
    public int data;

    public Node(int data)
    {
        this.data = data;
        left = null;
        right = null;
    }
}

public class Solution
{
    public static void preOrder(Node root)
    {
        if (root == null)
            return;

        Console.Write(root.data + " ");

        preOrder(root.left);
        preOrder(root.right);
    }

    public static Node insert(Node root, int data)
    {
        if (root == null)
        {
            return new Node(data);
        }
        else
        {
            Node current;
            if (data <= root.data)
            {
                current = insert(root.left, data);
                root.left = current;
            }
            else
            {
                current = insert(root.right, data);
                root.right = current;
            }
            return root;
        }
    }

    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());
        var nodes = Console.ReadLine().TrimEnd().Split(' ').Select(iStr => Convert.ToInt32(iStr));

        Node root = null;
        foreach (int data in nodes.Take(n))
        {
            root = insert(root, data);
        }

        preOrder(root);
    }
}
