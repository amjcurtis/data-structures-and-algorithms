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
			Node<object> node11 = new Node<object>(10);

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
			//tree.Root.LeftChild.RightChild.RightChild = node10;

			var fbTreeList = FizzBuzzTree(tree.Root);

			foreach (var obj in fbTreeList)
			{
				Console.WriteLine(obj);
			}

		}

		public static List<object> FizzBuzzTree(Node<object> root)
		{
			List<object> list = new List<object>();

			CheckFizzBuzz(root);

			list.Add(root.Value);

			Console.Write($"{root.Value.ToString()} ");

			// Traversal of child nodes
			if (root.LeftChild != null)
			{
				FizzBuzzTree(root.LeftChild);
			}

			if (root.RightChild != null)
			{
				FizzBuzzTree(root.RightChild);
			}

			return list;
		}

		//public static BinaryTree<object> FizzBuzzTree(BinaryTree<object> tree)
		//{
		//	CheckFizzBuzz(tree.Root);

		//	Console.Write($"{tree.Root.Value.ToString()} ");
		//	Console.WriteLine();

		//	// Traversal of child nodes
		//	if (tree.Root.LeftChild != null)
		//	{
		//		FizzBuzzTree(tree);
		//	}

		//	if (tree.Root.RightChild != null)
		//	{
		//		FizzBuzzTree(tree);
		//	}

		//	return tree;
		//}

		// Helper method to check for FizzBuzz
		public static void CheckFizzBuzz(Node<object> node)
		{
			// FizzBuzz tests
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
