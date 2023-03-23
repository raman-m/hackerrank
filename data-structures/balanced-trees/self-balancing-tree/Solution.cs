namespace RamanM.HackerRank.DataStructures.BalancedTrees.SelfBalancingTree;

using System;
using System.Collections.Generic;

public class Node
{
    public readonly int Value;
    public Node Left;
    public Node Right;

    public int Height => Solution.Height(this);

    public Node(int value)
    { Value = value; }
}

public class Solution
{
    public static int Height(Node tree)
    {
        if (tree == null)
            return -1;

        if (tree.Left == null && tree.Right == null)
            return 0;

        int left = Height(tree.Left);
        int right = Height(tree.Right);

        return Math.Max(left, right) + 1;
    }

    public static int BalanceFactor(Node tree)
    {
        if (tree == null)
            return 0;

        int leftHeight = Height(tree.Left) + 1;
        int rightHeight = Height(tree.Right) + 1;

        return leftHeight - rightHeight;
    }

    public static Node Insert(Node root, int value)
    {
        if (root == null)
            return new Node(value);

        if (root.Value == value)
            return root;

        if (root.Value > value)
            root.Left = Insert(root.Left, value);
        else
            root.Right = Insert(root.Right, value);

        while (Math.Abs( BalanceFactor(root) ) >= 2)
        {
            root = Balance(root);
        }
        return root;
    }

    public static Node Balance(Node tree)
    {
        if (tree == null)
            return null;

        int bFactor = BalanceFactor(tree);
        if (bFactor >= -1 && bFactor <= 1)
            return tree; // balancing is not required

        if (bFactor >= 2) // left case
        {
            int leftBF = BalanceFactor(tree.Left);
            if (leftBF < 0) // left right case
                return RotateLeftRightCase(tree);
            else
                return RotateRight(tree);
        }

        if (bFactor <= -2) // right case
        {
            int rightBF = BalanceFactor(tree.Right);
            if (rightBF > 0) // right left case
                return RotateRightLeftCase(tree);
            else
                return RotateLeft(tree);
        }

        return tree;
    }

    public static Node RotateLeftRightCase(Node parent)
    {
        if (parent == null || parent.Left == null || parent.Left.Right == null)
            return parent;

        int factor = BalanceFactor(parent);
        if (factor < 2)
            return parent;

        Node child = parent.Left;
        factor = BalanceFactor(child);
        if (factor >= 0) // not left right case
            return parent;

        Node A = child.Left;
        Node rotating = child.Right;
        Node B = rotating.Left;
        Node C = rotating.Right;
        Node D = parent.Right;

        parent.Left = null; // start rotation

        child.Left = A;
        child.Right = B;
        rotating.Left = child;
        rotating.Right = C;
        parent.Left = rotating;
        parent.Right = D;

        return parent;
    }

    public static Node RotateRightLeftCase(Node parent)
    {
        if (parent == null || parent.Right == null || parent.Right.Left == null)
            return parent;

        int factor = BalanceFactor(parent);
        if (factor > -2)
            return parent;

        Node child = parent.Right;
        factor = BalanceFactor(child);
        if (factor <= 0) // not right left case
            return parent;

        Node A = parent.Left;
        Node rotating = child.Left;
        Node B = rotating.Left;
        Node C = rotating.Right;
        Node D = child.Right;

        parent.Right = null; // start rotation

        child.Left = C;
        child.Right = D;
        rotating.Left = B;
        rotating.Right = child;
        parent.Right = rotating;
        parent.Left = A;

        return parent;
    }

    public static Node RotateLeft(Node parent)
    {
        if (parent == null || parent.Right == null || parent.Right.Right == null)
            return parent; // bad subtree, nothing to rotate

        int factor = BalanceFactor(parent);
        if (factor > -2)
            return parent; // not right right case

        Node child = parent.Right;
        Node subchild = child.Right;

        Node A = parent.Left;
        Node B = child.Left;
        Node C = subchild.Left;
        Node D = subchild.Right;

        Node root = child; // start rotation
        root.Left = parent;
        root.Right = subchild;
        root.Left.Left = A;
        root.Left.Right = B;
        root.Right.Left = C;
        root.Right.Right = D;

        return root;
    }

    public static Node RotateRight(Node parent)
    {
        if (parent == null || parent.Left == null || parent.Left.Left == null)
            return parent; // bad subtree, nothing to rotate

        int factor = BalanceFactor(parent);
        if (factor < 2)
            return parent; // not left left case

        Node child = parent.Left;
        Node subchild = child.Left;

        Node A = subchild.Left;
        Node B = subchild.Right;
        Node C = child.Right;
        Node D = parent.Right;

        Node root = child; // start rotation
        root.Left = subchild;
        root.Right = parent;
        root.Left.Left = A;
        root.Left.Right = B;
        root.Right.Left = C;
        root.Right.Right = D;

        return root;
    }

    public static Node Find(Node root, int value)
    {
        if (root == null)
            return null;

        if (root.Value == value)
            return root;

        if (root.Value > value)
            return Find(root.Left, value);
        else // root.Value < value
            return Find(root.Right, value);
    }

    public static void Traverse(Node node)
    {
        if (node == null)
            return;

        int factor = BalanceFactor(node);
        Console.Write($"{node.Value}(BF={factor}) ");

        Traverse(node.Left);
        Traverse(node.Right);
    }

    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());
        var values = Console.ReadLine().TrimEnd().Split(' ').Select(iStr => Convert.ToInt32(iStr));

        Node root = null;
        Dictionary<int, Node> nodes = new Dictionary<int, Node>(n);
        foreach (int val in values.Take(n))
        {
            root = Insert(root, val);
            Node node = Find(root, val);
            nodes.Add(val, node);
        }

        int inserted = Convert.ToInt32(Console.ReadLine().Trim());
        root = Insert(root, inserted);
        Node last = Find(root, inserted);
        nodes.Add(inserted, last);

        // Print balance factors
        foreach (int value in nodes.Keys.OrderBy(key => key))
        {
            int factor = BalanceFactor(nodes[value]);
            Console.Write($"{value}(BF={factor}) ");
        }
        Console.WriteLine();

        Traverse(root);
    }
}
