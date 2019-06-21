﻿using System;
using BinaryTree.Classes;
using System.Collections.Generic;

namespace BinaryTree
{
	public class Program
	{
		static void Main(string[] args)
		{

			BinaryTree<int> tree = new BinaryTree<int>();

			// Instantiate nodes to populate tree			
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

			/*
							   1
							  /  \
							2      3
						   / \    / \
						 4    5  6   7
						/\	 /			
					   8  9 10

			*/

			// Demo preorder traversal
			Console.WriteLine("PREORDER");
			List<int> preOrderOutput = tree.PreOrder(tree.Root);
			foreach (int num in preOrderOutput)
			{
				Console.Write("{0} ", num);
			}
			Console.WriteLine("\n");
			tree.Nodes.Clear();

			// Demo inorder traversal
			Console.WriteLine("INORDER");
			List<int> inOrderOutput = tree.InOrder(tree.Root);
			foreach (int num in inOrderOutput)
			{
				Console.Write("{0} ", num);
			}
			Console.WriteLine("\n");
			tree.Nodes.Clear();

			// Demo postorder traversal
			Console.WriteLine("POSTORDER");
			List<int> postOrderOutput = tree.PostOrder(tree.Root);
			foreach (int num in postOrderOutput)
			{
				Console.Write("{0} ", num);
			}
			Console.WriteLine("\n");
			tree.Nodes.Clear();

			// Demo breadth-first tree traversal
			Console.WriteLine("BREADTH-FIRST TRAVERSAL");
			List<int> outputOfBreadthFirst = tree.TraverseBreadthFirst(tree.Root);
			foreach (var num in outputOfBreadthFirst)
			{
				Console.Write("{0} ", num);
			}
			Console.WriteLine("\n");
			tree.Nodes.Clear();

			// Demo depth-first traversal using a stack
			Console.WriteLine("DEPTH-FIRST TRAVERSAL WITH STACK");
			List<int> depthFirstOutput = tree.TraverseDepthFirstWithStack(tree.Root);
			foreach (var num in depthFirstOutput)
			{
				Console.Write("{0} ", num);
			}
			Console.WriteLine("\n");
			tree.Nodes.Clear();

			// Demo FindMaxValue method
			int? max = tree.FindMaxValue(tree.Root);
			Console.WriteLine($"Max value is: {(max.HasValue ? max.ToString() : "NULL")}");
			Node<int> nullNode = null;
			int ? nullMax = tree.FindMaxValue(nullNode);
			Console.WriteLine($"Max value is: {(nullMax.HasValue ? nullMax.ToString() : "NULL")}");
		}
	}
}
