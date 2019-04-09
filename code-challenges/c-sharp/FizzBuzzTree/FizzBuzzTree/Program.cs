using System;
using BinaryTree.Classes;

namespace FizzBuzzTree
{
	public class Program
	{
		public static void Main(string[] args)
		{
			BinaryTree<int> tree = new BinaryTree<int>();
		}

		public BinaryTree<object> FizzBuzzTree(BinaryTree<int> tree)
		{
			// FizzBuzz tests
			if (tree.Root.Value % 3 == 0 && tree.Root.Value % 5 == 0)
			{
				tree.Root.Value == "FizzBuzz";
			}
			else if (tree.Root.Value % 3 == 0)
			{
				tree.Root.Value == "Fizz";
			}
			else if (tree.Root.Value % 5 == 0)
			{
				tree.Root.Value == "Buzz";
			}
			
			// Traversal of child nodes
				if (tree.Root.LeftChild != null)
			{
				FizzBuzzTree(tree.Root.LeftChild);
			}

			if (tree.Root.RightChild != null)
			{
				FizzBuzzTree(tree.Root.RightChild);
			}

			return tree;
		}
	}
}
