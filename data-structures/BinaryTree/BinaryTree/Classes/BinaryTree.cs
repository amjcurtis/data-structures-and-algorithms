using System;
using StacksAndQueues.Classes;
using System.Collections.Generic;
using System.Text;

namespace BinaryTree.Classes
{
	public class BinaryTree<T>
	{

		public Node<T> Root { get; set; }

		// Should only need for breadth-first traversals
		//StacksAndQueues.Classes.Queue<T> queue = new StacksAndQueues.Classes.Queue<T>();

		// Binary tree constructor
		public BinaryTree(Node<T> node)
		{
			Root = node;
		}

		// Empty constructor so can instantiate empty binary tree
		public BinaryTree()
		{
		}

		/// <summary>
		/// Performs depth-first traversal of binary tree, inspecting root node before traversing to child nodes
		/// </summary>
		/// <param name="root">root node of tree</param>
		/// <returns>array of type T</returns>
		public List<T> PreOrder(Node<T> root)
		{
			// Instantiate new collection
			List<T> output = new List<T>();

			output.Add(root.Value);

			if (root.LeftChild != null)
			{
				PreOrder(root.LeftChild);
			}

			if (root.RightChild != null)
			{
				PreOrder(root.RightChild);
			}

			return output;
		}


		public List<T> InOrder(Node<T> root)
		{
			// Instantiate new collection
			List<T> output = new List<T>();

			if (root.LeftChild != null)
			{
				InOrder(root.LeftChild);
			}

			output.Add(root.Value);

			if (root.RightChild != null)
			{
				InOrder(root.RightChild);
			}

			return output;
		}

		public List<T> PostOrder(Node<T> root)
		{
			// Instantiate new collection
			List<T> output = new List<T>();

			if (root.LeftChild != null)
			{
				InOrder(root.LeftChild);
			}

			if (root.RightChild != null)
			{
				InOrder(root.RightChild);
			}

			output.Add(root.Value);

			return output;
		}
	}
}
