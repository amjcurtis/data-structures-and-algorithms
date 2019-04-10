using System;
using StacksAndQueues.Classes;
using System.Collections.Generic;
using System.Text;

namespace BinaryTree.Classes
{
	public class BinaryTree<T>
	{

		public Node<T> Root { get; set; }

		// Instantiate new public collection
		public List<T> output = new List<T>();

		// BT constructor
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
		/// <returns>list of values of nodes in binary tree</returns>
		public List<T> PreOrder(Node<T> root)
		{
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

		/// <summary>
		/// Performs depth-first traversal of binary tree, inspecting root node between traversing to child nodes
		/// </summary>
		/// <param name="root">root node of tree</param>
		/// <returns>list of values of nodes in binary tree</returns>
		public List<T> InOrder(Node<T> root)
		{
			if (root.LeftChild != null)
			{
				InOrder(root.LeftChild);
			}

			output.Add(root.Value);

			if (root.RightChild != null)
			{
				PreOrder(root.RightChild);
			}

			return output;
		}

		/// <summary>
		/// Performs depth-first traversal of binary tree, inspecting root node after traversing to child nodes
		/// </summary>
		/// <param name="root">root node of tree</param>
		/// <returns>list of values of nodes in binary tree</returns>
		public List<T> PostOrder(Node<T> root)
		{
			if (root.LeftChild != null)
			{
				InOrder(root.LeftChild);
			}

			if (root.RightChild != null)
			{
				PreOrder(root.RightChild);
			}

			output.Add(root.Value);

			return output;
		}

		/// <summary>
		/// Traverses binary tree breadth first
		/// </summary>
		/// <param name="tree">binary tree</param>
		/// <returns>boolean indicated whether tree has been traversed successfully to end</returns>
		public bool TraverseBreadthFirst(BinaryTree<int> tree)
		{
			if (tree.Root == null)
			{
				return false;
			}

			// Instantiate queue
			System.Collections.Generic.Queue<Node<int>> queue = new System.Collections.Generic.Queue<Node<int>>();

			queue.Enqueue(tree.Root);

			while (queue.Count != 0)
			{
				Node<int> front = queue.Dequeue();

				Console.WriteLine(front.Value);

				if (front.LeftChild != null)
				{
					queue.Enqueue(front.LeftChild);
				}

				if (front.RightChild != null)
				{
					queue.Enqueue(front.RightChild);
				}
			}
			return true;
		}
	}
}
