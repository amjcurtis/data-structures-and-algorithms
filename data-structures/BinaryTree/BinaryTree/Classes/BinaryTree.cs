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
			return (root == null) || // Base case
				(IsBalancedRecursive(root.LeftChild) &&
				IsBalancedRecursive(root.RightChild) &&
				Math.Abs(GetHeight(root.LeftChild) - GetHeight(root.RightChild)) <= 1);
		}

		/// <summary>
		/// Recursively calculates height of binary tree from specified node to bottom of tree.
		/// </summary>
		/// <param name="node">Starting node in tree.</param>
		/// <returns>Boolean.</returns>
		public int GetHeight(Node<T> node)
		{
			// Base case
			if (node == null) return 0;

			return 1 + Math.Max(GetHeight(node.LeftChild), GetHeight(node.RightChild));
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


		public static Node<int> MergeTrees(Node<int> root1, Node<int> root2)
		{
			if (root1 == null && root2 == null)
			{
				return null;
			}
			else if (root1 == null && root2 != null)
			{
				return root2;
			}
			else if (root1 != null && root2 == null)
			{
				return root1;
			}

			BinaryTree<int> newTree = new BinaryTree<int>();
			Queue<Node<int>> queue = new Queue<Node<int>>();

			newTree.Root = new Node<int>(root1.Value + root2.Value); // Only happens if both root1 and root2 not null
			Node<int> newTreeCurrentNode = newTree.Root;
			queue.Enqueue(root1);
			queue.Enqueue(root2);

			while (queue.Count > 1) // Greater'n one since we're dequeuing two nodes at each iteration
			{
				Node<int> t1Node = queue.Dequeue();
				Node<int> t2Node = queue.Dequeue();

				if (t1Node.LeftChild != null && t2Node.LeftChild != null)
				{
					newTreeCurrentNode.LeftChild = new Node<int>(t1Node.LeftChild.Value + t2Node.LeftChild.Value);
					newTreeCurrentNode = newTreeCurrentNode.LeftChild;
					queue.Enqueue(t1Node.LeftChild);
					queue.Enqueue(t2Node.LeftChild);
				}
				else if (t1Node.LeftChild == null && t2Node.LeftChild != null)
				{
					newTreeCurrentNode.LeftChild = new Node<int>(t2Node.LeftChild.Value);
					queue.Enqueue(t2Node.LeftChild);
				}
				else if (t1Node.LeftChild != null && t2Node.LeftChild == null)
				{
					newTreeCurrentNode.LeftChild = new Node<int>(t1Node.LeftChild.Value);
					queue.Enqueue(t1Node.LeftChild);
				}
				else // If both t1Node.LeftChild and t2Node.LeftChild are null
				{

				}

				if (t1Node.RightChild != null && t2Node.RightChild != null)
				{
					newTreeCurrentNode.RightChild = new Node<int>(t1Node.RightChild.Value + t2Node.RightChild.Value);
					queue.Enqueue(t1Node.RightChild);
					queue.Enqueue(t2Node.RightChild);
				}
				else if (t1Node.RightChild == null && t2Node.RightChild != null)
				{
					newTreeCurrentNode.RightChild = new Node<int>(t2Node.RightChild.Value);
					queue.Enqueue(t2Node.RightChild);
				}
				else if (t1Node.RightChild != null && t2Node.RightChild == null)
				{
					newTreeCurrentNode.RightChild = new Node<int>(t1Node.RightChild.Value);
					queue.Enqueue(t1Node.RightChild);
				}

				//TODO Move newTreeCurrentNode to next node down

			}
		}
	}
}
