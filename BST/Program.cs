using System;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
BinaryTree tree1 = new BinaryTree();

tree1.root = new Node(1);
tree1.root.left = new Node(2);
tree1.root.right = new Node(3);
tree1.root.right.left = new Node(8);
tree1.root.left.left = new Node(4);
tree1.root.left.right = new Node(5);
tree1.root.left.right.right = new Node(9);
int height = tree1.maxDepth(tree1.root);
Console.WriteLine("Height of tree is : " +
							height);

Console.WriteLine("Mirror of tree is : ");
Node root = tree1.Mirror(tree1.root);
tree1.inOrder(root);

BinaryTree tree2 = new BinaryTree();
tree2.root = new Node(1);
tree2.root.left = new Node(2);
tree2.root.right = new Node(3);
tree2.root.left.left = new Node(4);
tree2.root.left.right = new Node(5);
tree2.root.left.right.right = new Node(9);
Console.WriteLine("THE comparision is result is " + Compare(tree1.root, tree2.root));

bool Compare(Node node1, Node node2)
{
	if (node1 == null && node2 == null)
		return true; 
	else if(node1 != null && node2 == null || node1 == null && node2 != null)
    {
		return false;
    }
	else if (node1!=null && node2 != null && node1.data != node2.data)
	{
		return false;
	}
	else
	{
		/* compute the depth of each subtree */
		bool isLsAME = Compare(node1.left, node2.left);

		bool isRsAME = Compare(node1.right, node2.right);

		if (isLsAME && isRsAME)
		{
			return true;
		}
		else
		{
			return false;
		}
	}
}

// C# program to find height of tree


// A binary tree node
public class Node
{
	public int data;
	public Node left, right;

	public Node(int item)
	{
		data = item;
		left = right = null;
	}
}

public class BinaryTree
{
	public Node root;


	/* Compute the "maxDepth" of a tree -- the number of
	nodes along the longest path from the root node
	down to the farthest leaf node.*/
	public int maxDepth(Node node)
	{
		if (node == null)
			return 0;
		else
		{
			/* compute the depth of each subtree */
			int ldepth = maxDepth(node.left);

			int rdepth = maxDepth(node.right);
				
			/* use the larger one */
			if (ldepth > rdepth)
				return ldepth + 1;
			else
				return rdepth + 1;
        }
    }

    public Node Mirror(Node root)
    {
        Node node = null;

        if (root != null)
        {
            node = new Node(root.data);
            node.right = Mirror(root.left);
            node.left = Mirror(root.right);
        }

        return node;
    }

	public virtual void inOrder(Node node)
	{
		if (node == null)
		{
			return;
		}

		inOrder(node.left);
		Console.Write(node.data + " ");

		inOrder(node.right);
	}
}



// This code has been contributed by
// Correction done by Amit Srivastav
