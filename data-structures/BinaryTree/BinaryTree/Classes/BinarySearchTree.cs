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

		/// <summary>
		/// Adds new node with specified value to binary search tree
		/// </summary>
		/// <param name="root">root node of binary search tree to add node to</param>
		/// <param name="value">value of the node to be added</param>
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
						root = root.LeftChild;
						if (root == null)
						{
							root.LeftChild = newNode;
						}
					}
					else if (value > root.Value)
					{
						root = root.RightChild;
						if (root == null)
						{
							root.RightChild = newNode;
						}
					}
					//else // if newNode.Value == root.Value // Should add new node if its value already present in tree?
					//{

					//}
				}
			}
		}

		/// <summary>
		/// Searches binary search tree for a given value and returns boolean
		/// </summary>
		/// <param name="root">root node to start search on</param>
		/// <param name="value">value to search nodes in BST for</param>
		/// <returns>true if value found in BST, else false</returns>
		public bool Contains(Node<int> root, int value)
		{
			while (root != null)
			{
				if (root.Value == value)
				{
					return true;
				}
				if (root.Value > value)
				{
					root = root.LeftChild;
				}
				else
				{
					root = root.RightChild;
				}
			}
			return false;
		}
	}
}
