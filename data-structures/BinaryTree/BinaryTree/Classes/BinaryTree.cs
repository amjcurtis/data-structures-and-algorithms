using System;
using BinaryTree.Classes;
using StacksAndQueues.Classes;
using System.Collections.Generic;
using System.Text;

namespace BinaryTree
{
	public class BinaryTree<T>
	{
		public Classes.Node<T> Root { get; set; }

		/// <summary>
		/// Performs depth-first traversal of binary tree, inspecting root node before traversing to child nodes
		/// </summary>
		/// <param name="root">root node of tree</param>
		/// <returns>array of type T</returns>
		public List<T> PreOrder(Classes.Node<T> root)
		{
			List<T> output = new List<T>();

			StacksAndQueues.Classes.Queue<T> queue = new StacksAndQueues.Classes.Queue<T>();

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
	}
}
