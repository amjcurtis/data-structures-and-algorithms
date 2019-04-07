using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTree.Classes
{
	public class BinarySearchTree<T>
	{

		public Node<T> Root { get; set; }

		//public BinaryTree<int> BinaryTree { get; set; }

		//// Constructor for binary search tree
		//public BinarySearchTree()
		//{
		//	BinaryTree = new BinaryTree<int>();
		//}

		// Constructor for BST
		public BinarySearchTree(Node<T> node)
		{
			Root = node;
		}

		// Empty constructor so can instantiate empty BST
		public BinarySearchTree()
		{
		}

		public void Add(int value)
		{
			// Instantiate new node and give it a value
			Node<int> newNode = new Node<int>(value);

			while (Root.LeftChild)
			{

			}

			if (value > BinaryTree.Root.Value)
			{

			}
		}
	}
}
