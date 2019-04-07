using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTree.Classes
{
	public class BinarySearchTree<T>
	{

		public BinaryTree<int> BinaryTree { get; set; }

		// Constructor for binary search tree
		public BinarySearchTree()
		{
			BinaryTree = new BinaryTree<int>();
		}

		public void Add(int value)
		{
			// Instantiate new node and give it a value
			Node<int> newNode = new Node<int>(value);

			if (value > BinaryTree.Root.Value)
			{

			}
		}
	}
}
