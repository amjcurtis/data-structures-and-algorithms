using System;
using BinaryTree.Classes;
using System.Collections.Generic;

namespace BinaryTree
{
	class Program
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
			Console.Write(outputOfPreOrder[0]);
			Console.Write(outputOfPreOrder[1]);
			Console.WriteLine(outputOfPreOrder[2]);
			tree.output.Clear();

			// Test InOrder() method
			List<int> outputOfInOrder = tree.InOrder(intNode);
			Console.Write(outputOfInOrder[0]);
			Console.Write(outputOfInOrder[1]);
			Console.WriteLine(outputOfInOrder[2]);
			tree.output.Clear();

			// Test PostOrder() method
			List<int> outputOfPostOrder = tree.PostOrder(intNode);
			Console.Write(outputOfPostOrder[0]);
			Console.Write(outputOfPostOrder[1]);
			Console.WriteLine(outputOfPostOrder[2]);
			tree.output.Clear();

			// Test BST's Add() method
			Node<int> rootOfBST = new Node<int>(21);
			BinarySearchTree<int> bst = new BinarySearchTree<int>(rootOfBST);
			Console.WriteLine(bst.Root.Value);

			bst.Add(bst.Root, 22);
			Console.WriteLine(bst.Root.RightChild.Value);

			////////////////////////////////////////////
			
			////////////////////////////////////////////
			
			BinaryTree<int> breadthFirstTree = new BinaryTree<int>();

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

			// Run breadth-first traversal method
			tree.TraverseBreadthFirst(tree);

			Console.ReadLine();
		}
	}
}
