using System;
using System.Collections.Generic;

namespace BinaryTree.Classes
{
	public class BinaryTree<T>
	{
		public Node<T> Root { get; set; }

		// Instantiate new public collection outside traversal methods so new list isn't instantiated at every recursive call
		// Note: need to clear node list after each traversal
		public List<T> Nodes = new List<T>();

		public BinaryTree(Node<T> node)
		{
			Root = node;
		}

		// Empty constructor so can instantiate empty binary tree
		public BinaryTree()
		{
		}

		/// <summary>
		/// Clears list of nodes populated by last traversal of tree
		/// </summary>
		public void ClearNodeList()
		{
			Nodes.Clear();
		}

		/// <summary>
		/// Performs depth-first traversal of binary tree, inspecting root node before traversing to child nodes
		/// </summary>
		/// <param name="root">root node of tree</param>
		/// <returns>list of values of nodes in binary tree</returns>
		public List<T> PreOrder(Node<T> root)
		{
			// Error check
			if (root == null) return null;

			Nodes.Add(root.Value);

			if (root.LeftChild != null)
			{
				PreOrder(root.LeftChild);
			}

			if (root.RightChild != null)
			{
				PreOrder(root.RightChild);
			}

			return Nodes;
		}

		/// <summary>
		/// Performs depth-first traversal of binary tree, inspecting root node between traversing to child nodes
		/// </summary>
		/// <param name="root">root node of tree</param>
		/// <returns>list of values of nodes in binary tree</returns>
		public List<T> InOrder(Node<T> root)
		{
			// Error check
			if (root == null) return null;

			if (root.LeftChild != null)
			{
				InOrder(root.LeftChild);
			}

			Nodes.Add(root.Value);

			if (root.RightChild != null)
			{
				InOrder(root.RightChild);
			}

			return Nodes;
		}

		/// <summary>
		/// Performs depth-first traversal of binary tree, inspecting root node after traversing to child nodes
		/// </summary>
		/// <param name="root">root node of tree</param>
		/// <returns>list of values of nodes in binary tree</returns>
		public List<T> PostOrder(Node<T> root)
		{
			// Error check
			if (root == null) return null;

			if (root.LeftChild != null)
			{
				PostOrder(root.LeftChild);
			}

			if (root.RightChild != null)
			{
				PostOrder(root.RightChild);
			}

			Nodes.Add(root.Value);

			return Nodes;
		}

		/// <summary>
		/// Traverses tree depth-first non-recursively by using a stack
		/// </summary>
		/// <param name="root">root node of tree</param>
		/// <returns>list of nodes traversed</returns>
		public List<T> TraverseDepthFirstWithStack(Node<T> root)
		{
			// Error check
			if (root == null) return null;

			Node<T> current;

			// Instantiate stack
			Stack<Node<T>> stack = new Stack<Node<T>>();

			stack.Push(root);

			while (stack.Count > 0)
			{
				current = stack.Pop();
				Nodes.Add(current.Value);

				if (current.RightChild != null)
				{
					stack.Push(current.RightChild);
				}

				if (current.LeftChild != null)
				{
					stack.Push(current.LeftChild);
				}
			}

			return Nodes;
		}

		/// <summary>
		/// Traverses binary tree breadth first
		/// </summary>
		/// <param name="tree">binary tree</param>
		/// <returns>boolean indicated whether tree has been traversed successfully to end</returns>
		public List<T> TraverseBreadthFirst(Node<T> root)
		{
			// Error check
			if (root == null) return null;

			// Instantiate queue
			Queue<Node<T>> queue = new Queue<Node<T>>();

			queue.Enqueue(root);

			while (queue.Count > 0)
			{
				Node<T> front = queue.Dequeue();

				Nodes.Add(front.Value);

				if (front.LeftChild != null)
				{
					queue.Enqueue(front.LeftChild);
				}

				if (front.RightChild != null)
				{
					queue.Enqueue(front.RightChild);
				}
			}

			return Nodes;
		}

		/// <summary>
		/// Checks whether binary tree is a binary search tree
		/// </summary>
		/// <param name="root">root node of tree</param>
		/// <returns>boolean depending on whether tree is BST or not or null if tree is empty</returns>
		public bool? IsBinarySearchTree(Node<int> root)
		{
			// Error check
			if (root == null) return null;

			// Instantiate queue
			Queue<Node<int>> queue = new Queue<Node<int>>();

			queue.Enqueue(root);

			while (queue.Count > 0)
			{
				Node<int> front = queue.Dequeue();

				if (front.LeftChild != null)
				{
					if (front.LeftChild.Value <= front.Value)
					{
						queue.Enqueue(front.LeftChild);
					}
					else
					{
						return false;
					}
				}

				if (front.RightChild != null)
				{
					if (front.RightChild.Value >= front.Value)
					{
						queue.Enqueue(front.RightChild);
					}
					else
					{
						return false;
					}
				}
			}

			return true;
		}

		/// <summary>
		/// Recursively traverses binary tree to find whether tree is balanced.
		/// </summary>
		/// <param name="root">Root node of tree.</param>
		/// <returns>Boolean.</returns>
		public bool IsBalancedRecursive(Node<T> root)
		{
			return (
						root == null // Base case
				   ) ||
				   (
						IsBalancedRecursive(root.LeftChild) &&
						IsBalancedRecursive(root.RightChild) &&
						Math.Abs(GetHeight(root.LeftChild) - GetHeight(root.RightChild)) <= 1
				   );
		}

		/// <summary>
		/// Calculates height of binary tree from specified node to bottom of tree.
		/// </summary>
		/// <param name="node">Starting node in tree.</param>
		/// <returns>Boolean.</returns>
		public int GetHeight(Node<T> node)
		{
			// Base case
			if (node == null) return 0;

			return 1 + Math.Max(GetHeight(node.LeftChild), GetHeight(node.RightChild));
		}

		public bool IsBalancedWithStack(Node<T> root)
		{
			// Error check
			if (root == null) return true;

			Node<T> current;

			// Instantiate stack
			Stack<Node<T>> stack = new Stack<Node<T>>();

			stack.Push(root);

			while (stack.Count > 0)
			{
				current = stack.Pop();

				//TODO fill in balance test logic


				if (current.RightChild != null)
				{
					stack.Push(current.RightChild);
				}

				if (current.LeftChild != null)
				{
					stack.Push(current.LeftChild);
				}
			}
		}

		/// <summary>
		/// Traverses tree breadth-first and returns maximum node value
		/// </summary>
		/// <param name="root">root node</param>
		/// <returns>max node value or null if tree is empty</returns>
		public int? FindMaxValue(Node<int> root)
		{
			// Handles edge case where tree is empty
			if (root == null) return null;

			// Variable to store max value
			int? max = int.MinValue;

			// Instantiate queue for breadth-first traversal
			Queue<Node<int>> queue = new Queue<Node<int>>();

			queue.Enqueue(root);

			while (queue.Count > 0)
			{
				Node<int> front = queue.Dequeue();

				// Update max if necessary
				if (front.Value > max)
				{
					max = front.Value;
				}

				if (front.LeftChild != null)
				{
					queue.Enqueue(front.LeftChild);
				}

				if (front.RightChild != null)
				{
					queue.Enqueue(front.RightChild);
				}
			}

			return max;
		}
	}
}
