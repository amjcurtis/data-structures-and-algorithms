using System;
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

			FizzBuzzTree(tree);

			Console.WriteLine($"tree.Root.RightChild: {tree.Root.RightChild.Value}");

			Console.ReadLine();
		}

		public static BinaryTree<object> FizzBuzzTree(BinaryTree<object> tree)
		{
			// FizzBuzz tests
			if ((int)tree.Root.Value % 3 == 0 && (int)tree.Root.Value % 5 == 0)
			{
				tree.Root.Value = "FizzBuzz";
			}
			else if ((int)tree.Root.Value % 3 == 0)
			{
				tree.Root.Value = "Fizz";
			}
			else if ((int)tree.Root.Value % 5 == 0)
			{
				tree.Root.Value = "Buzz";
			}
			
			// Traversal of child nodes
			if (tree.Root.LeftChild != null)
			{
				tree.PreOrder(tree.Root.LeftChild);
			}

			if (tree.Root.RightChild != null)
			{
				tree.PreOrder(tree.Root.RightChild);
			}

			return tree;
		}

		// Helper method to check for FizzBuzz
		//public string CheckFizzBuzz(int value)
		//{

		//}

	}
}
