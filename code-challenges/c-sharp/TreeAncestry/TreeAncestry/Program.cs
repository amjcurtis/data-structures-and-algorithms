using BinaryTree.Classes;
using System;

namespace TreeAncestry
{
	public class Program
	{
		static void Main(string[] args)
		{
			// Instantiate binary tree and populate with nodes
			BinaryTree<int> tree = new BinaryTree<int>();

			Node<int> node1 = new Node<int>(1);
			Node<int> node2 = new Node<int>(2);
			Node<int> node3 = new Node<int>(3);
			Node<int> node4 = new Node<int>(4);
			Node<int> node5 = new Node<int>(5);
			Node<int> node6 = new Node<int>(6);
			Node<int> node7 = new Node<int>(7);
			Node<int> node8 = new Node<int>(8);
			Node<int> node9 = new Node<int>(9);
			Node<int> node10 = new Node<int>(10);

			// Populate tree with nodes
			tree.Root = node1;
			tree.Root.LeftChild = node2;
			tree.Root.RightChild = node3;
			tree.Root.LeftChild.LeftChild = node4;
			tree.Root.LeftChild.RightChild = node5;
			tree.Root.RightChild.LeftChild = node6;
			tree.Root.RightChild.RightChild = node7;
			tree.Root.LeftChild.LeftChild.LeftChild = node8;
			tree.Root.LeftChild.LeftChild.RightChild = node9;
			tree.Root.LeftChild.RightChild.LeftChild = node10;

			////////////////////////////////////////////
			// Demo IsAncestor() method
			////////////////////////////////////////////

			Console.WriteLine(IsAncestor(4, 9, tree.Root)); // Second value is descendant of first
			Console.WriteLine(IsAncestor(2, 10, tree.Root)); // Second value is descendant of first
			Console.WriteLine(IsAncestor(3, 10, tree.Root)); // Second value not descendant of first
			Console.WriteLine(IsAncestor(14, 9, tree.Root)); // Ancestor not in tree
			Console.WriteLine(IsAncestor(1, 77, tree.Root)); // Descendant not in tree

			// Empty tree passed as argument
			BinaryTree<int> emptyTree = new BinaryTree<int>();
			bool? nullTree = IsAncestor(1, 77, emptyTree.Root);
			Console.WriteLine(nullTree.HasValue ? nullTree.ToString() : "NULL");
		}

		/// <summary>
		/// Checks whether node with value a is ancestor of node with value b
		/// </summary>
		/// <param name="a">Value of ancestor node to check for</param>
		/// <param name="b">Value of descendant node to check for</param>
		/// <param name="root">Root note of tree</param>
		/// <returns>True or false</returns>
		public static bool? IsAncestor(int a, int b, Node<int> root)
		{
			if (root == null) return null; // Handle empty tree

			bool flag = false;
			Node<int> found = null;

			// Internal method for PreOrder traversal
			void PreOrderContains(int x, Node<int> node)
			{
				if (node.Value == x)
				{
					found = node;
				}

				if (node.LeftChild != null)
				{
					PreOrderContains(x, node.LeftChild);
				}

				if (node.RightChild != null)
				{
					PreOrderContains(x, node.RightChild);
				}
			}

			// Check whether tree contains first (ancestor) value
			PreOrderContains(a, root);

			if (found != null && found.Value == a)
			{
				// If tree contains ancestor value, check whether second (descendant) value exists downstream from ancestor
				PreOrderContains(b, found);

				// If so, set boolean flag to true
				if (found.Value == b)
				{
					flag = true;
				}
			}

			return flag;
		}
	}
}
