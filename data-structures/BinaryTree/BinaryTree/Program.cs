using System;
using BinaryTree.Classes;
using System.Collections.Generic;

namespace BinaryTree
{
	public class Program
	{
		static void Main(string[] args)
		{
			// Instantiate new node and add as root of new BT
			Node<int> intNode = new Node<int>(11);
			BinaryTree<int> tree = new BinaryTree<int>(intNode);

			// Add child nodes to BT
			Node<int> left = new Node<int>(12);
			Node<int> right = new Node<int>(13);
			tree.Root.LeftChild = left;
			tree.Root.RightChild = right;

			// Test PreOrder() method
			List<int> outputOfPreOrder = tree.PreOrder(intNode);
			foreach (int num in outputOfPreOrder)
			{
				Console.Write("{0} ", num);
			}
			Console.WriteLine("\n");
			tree.Nodes.Clear();

			// Demo InOrder() method
			List<int> outputOfInOrder = tree.InOrder(intNode);
			foreach (int num in outputOfInOrder)
			{
				Console.Write("{0} ", num);
			}
			Console.WriteLine("\n");
			tree.Nodes.Clear();

			// Demo PostOrder() method
			List<int> outputOfPostOrder = tree.PostOrder(intNode);
			foreach (int num in outputOfPostOrder)
			{
				Console.Write("{0} ", num);
			}
			Console.WriteLine("\n");
			tree.Nodes.Clear();

			// Demo BST's Add() method
			Node<int> rootOfBST = new Node<int>(21);
			BinarySearchTree<int> bst = new BinarySearchTree<int>(rootOfBST);
			Console.WriteLine($"bst.Root.Value: {bst.Root.Value}");

			bst.Add(bst.Root, 22);
			Console.WriteLine($"bst.Root.RightChild.Value: {bst.Root.RightChild.Value}");
			Console.WriteLine("");

			////////////////////////////////////////////
			// Breadth-first binary tree traversal
			////////////////////////////////////////////

			Console.WriteLine("Node values from breadth-first binary tree traversal:");
			
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

			/*
								1

							 2     3
						    
						  4   5   6   7
						/ \					
					   8  9  10


								1
							  /   \
							 2     3
						   /\     /\
						 4

			*/

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

			// Demo breadth-first tree traversal
			List<int> outputOfBreadthFirst = tree.TraverseBreadthFirst(tree.Root);
			foreach (var num in outputOfBreadthFirst)
			{
				Console.Write("{0} ", num);
			}
			Console.WriteLine("\n");
			tree.Nodes.Clear();

			// Demo Preorder (for comparison with depth-first with stack)
			Console.WriteLine("PREORDER");
			List<int> preOrderOutput = tree.PreOrder(tree.Root);
			foreach (int num in outputOfPreOrder)
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
