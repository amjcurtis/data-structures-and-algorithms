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

		public void Add(Node<int> root, int value)
		{
			// Instantiate new node and give it a value
			Node<int> newNode = new Node<int>(value);

			if (root == null)
			{
				root = newNode;
			}
			else
			{
				while (root.LeftChild != null || root.RightChild != null)
				{
					if (newNode.Value < root.Value)
					{
						if (root.LeftChild == null)
						{
							root.LeftChild = newNode;
						}
						root = root.LeftChild;
					}
					else if (value > root.Value)
					{
						if (root == null)
						{
							root.RightChild = newNode;
						}
						root = root.RightChild;
					}
					// Need else clause for if newNode.Value == root.Value?

					
				}
			}
		}
	}
}
