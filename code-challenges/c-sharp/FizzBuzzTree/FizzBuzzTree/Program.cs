using System;
using System.Collections.Generic;
using BinaryTree.Classes;

namespace FizzBuzzTree
{
	public class Program
	{
		public static void Main(string[] args)
		{
			BinaryTree<object> tree = new BinaryTree<object>();

			Node<object> node1 = new Node<object>(1);
			Node<object> node2 = new Node<object>(2);
			Node<object> node3 = new Node<object>(3);
			Node<object> node4 = new Node<object>(4);
			Node<object> node5 = new Node<object>(5);
			Node<object> node6 = new Node<object>(6);
			Node<object> node7 = new Node<object>(7);
			Node<object> node8 = new Node<object>(8);
			Node<object> node9 = new Node<object>(9);
			Node<object> node10 = new Node<object>(10);
			Node<object> node11 = new Node<object>(15);

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
			tree.Root.LeftChild.RightChild.RightChild = node11;

			// Print tree nodes before FizzBuzz
			var fbTreeList = tree.PreOrder(tree.Root);
			foreach (var obj in tree.Nodes)
			{
				Console.Write($"{obj} ");
			}
			Console.WriteLine();
			tree.ClearNodeList(); // Clear tree node list before next tree traversal

			// Demo FizzBuzzTree() method
			fbTreeList = FizzBuzzTree(tree, tree.Root);

			// Print tree nodes after FizzBuzz
			foreach (var obj in tree.Nodes)
			{
				Console.Write($"{obj} ");
			}
			Console.WriteLine();
		}

		/// <summary>
		/// Performs FizzBuzz on binary tree nodes
		/// </summary>
		/// <param name="tree">binary tree</param>
		/// <param name="root">root node of binary tree</param>
		/// <returns>list of tree nodes traversed</returns>
		public static List<object> FizzBuzzTree(BinaryTree<object> tree, Node<object> root)
		{
			// Test current node for FizzBuzz
			CheckFizzBuzz(root);

			// Add current node's value to tree's "output" list 
			tree.Nodes.Add(root.Value);

			// Traversal of child nodes
			if (root.LeftChild != null)
			{
				FizzBuzzTree(tree, root.LeftChild);
			}

			if (root.RightChild != null)
			{
				FizzBuzzTree(tree, root.RightChild);
			}

			return tree.Nodes;
		}

		/// <summary>
		/// Tests node value for FizzBuzz
		/// </summary>
		/// <param name="node">binary tree node</param>
		public static void CheckFizzBuzz(Node<object> node)
		{
			if ((int)node.Value % 3 == 0 && (int)node.Value % 5 == 0)
			{
				node.Value = "FizzBuzz";
			}
			else if ((int)node.Value % 3 == 0)
			{
				node.Value = "Fizz";
			}
			else if ((int)node.Value % 5 == 0)
			{
				node.Value = "Buzz";
			}
		}
	}
}
