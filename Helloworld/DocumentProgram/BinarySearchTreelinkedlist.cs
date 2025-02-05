using System;

public class TreeNode
{
    public int Data;
    public TreeNode Left, Right;

    public TreeNode(int item)
    {
        Data = item;
        Left = Right = null;
    }
}

public class BinarySearchTree
{
    public TreeNode Root;

    public void Insert(int data)
    {
        Root = InsertRec(Root, data);
    }

    private TreeNode InsertRec(TreeNode root, int data)
    {
        if (root == null) return new TreeNode(data);

        if (data < root.Data)
            root.Left = InsertRec(root.Left, data);
        else if (data > root.Data)
            root.Right = InsertRec(root.Right, data);

        return root;
    }

    public void InOrder()
    {
        InOrderRec(Root);
        Console.WriteLine();
    }

    private void InOrderRec(TreeNode root)
    {
        if (root != null)
        {
            InOrderRec(root.Left);
            Console.Write(root.Data + " ");
            InOrderRec(root.Right);
        }
    }
}

public class BinaBinarySearchTreelinkedlist
{
    public static void Main(string[] args)
    {
        BinarySearchTree bst = new BinarySearchTree();

        Console.Write("Enter numbers separated by space: ");
        string[] inputs = Console.ReadLine().Split();

        foreach (string input in inputs)
        {
            if (int.TryParse(input, out int num))
                bst.Insert(num);
        }

        Console.WriteLine("In-order Traversal: ");
        bst.InOrder();
    }
}
