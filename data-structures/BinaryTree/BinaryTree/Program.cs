using System;
using BinaryTree.Classes;
using System.Collections.Generic;

namespace BinaryTree
{
	public class Program
	{
		static void Main(string[] args)
		{

			//// Instantiate new node and add as root of new BT
			//Node<int> intNode = new Node<int>(11);
			//BinaryTree<int> tree = new BinaryTree<int>(intNode);

			//// Add child nodes to BT
			//Node<int> left = new Node<int>(12);
			//Node<int> right = new Node<int>(13);
			//tree.Root.LeftChild = left;
			//tree.Root.RightChild = right;

			//// Test PreOrder() method
			//List<int> outputOfPreOrder = tree.PreOrder(intNode);
			//Console.Write($"{outputOfPreOrder[0]} ");
			//Console.Write($"{outputOfPreOrder[1]} ");
			//Console.WriteLine($"{outputOfPreOrder[2]} ");
			//Console.WriteLine("");
			//tree.output.Clear();

			//// Test InOrder() method
			//List<int> outputOfInOrder = tree.InOrder(intNode);
			//Console.Write($"{outputOfInOrder[0]} ");
			//Console.Write($"{outputOfInOrder[1]} ");
			//Console.WriteLine($"{outputOfInOrder[2]} ");
			//Console.WriteLine("");
			//tree.output.Clear();

			//// Test PostOrder() method
			//List<int> outputOfPostOrder = tree.PostOrder(intNode);
			//Console.Write($"{outputOfPostOrder[0]} ");
			//Console.Write($"{outputOfPostOrder[1]} ");
			//Console.WriteLine($"{outputOfPostOrder[2]} ");
			//Console.WriteLine("");
			//tree.output.Clear();

			//// Test BST's Add() method
			//Node<int> rootOfBST = new Node<int>(21);
			//BinarySearchTree<int> bst = new BinarySearchTree<int>(rootOfBST);
			//Console.WriteLine($"bst.Root.Value: {bst.Root.Value}");

			//bst.Add(bst.Root, 22);
			//Console.WriteLine($"bst.Root.RightChild.Value: {bst.Root.RightChild.Value}");
			//Console.WriteLine("");

			////////////////////////////////////////////
			// Breadth-first binary tree traversal
			////////////////////////////////////////////

			Console.WriteLine("Node values from breadth-first binary tree traversal:");

			BinaryTree<int> tree = new BinaryTree<int>();

			Node<int> node1 = new Node<int>(11);
			Node<int> node2 = new Node<int>(12);
			Node<int> node3 = new Node<int>(13);
			Node<int> node4 = new Node<int>(14);
			Node<int> node5 = new Node<int>(15);
			Node<int> node6 = new Node<int>(16);
			Node<int> node7 = new Node<int>(17);
			Node<int> node8 = new Node<int>(18);
			Node<int> node9 = new Node<int>(19);
			Node<int> node10 = new Node<int>(20);

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

			// Traverse tree breadth-first
			tree.TraverseBreadthFirst(tree);

			////////////////////////////////////////////
			// Demo IsAncestor() method
			////////////////////////////////////////////

			Console.WriteLine(IsAncestor(14, 19, tree.Root));
			Console.WriteLine(IsAncestor(12, 20, tree.Root));
			Console.WriteLine(IsAncestor(13, 20, tree.Root));
			Console.WriteLine(IsAncestor(11, 77, tree.Root));
		}


		/// <summary>
		/// Checks whether node with value a is ancestor of node with value b, treating both a and b as root nodes of their own trees in successive calls of recursive preorder method
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

			if (found.Value == a)
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
