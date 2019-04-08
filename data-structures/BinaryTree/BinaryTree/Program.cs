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
			
			Console.ReadLine();
		}
	}
}
