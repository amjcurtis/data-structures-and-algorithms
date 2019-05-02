using System;
using System.Collections.Generic;
using BinaryTree.Classes;
using HashTable;

namespace TreeIntersection
{
	public class Program
	{
		static void Main(string[] args)
		{
			// Instantiate first tree
			BinaryTree<string> tree1 = new BinaryTree<string>();

			// Instantiate first group of nodes to put in first tree
			Node<string> node1 = new Node<string>("quick");
			Node<string> node2 = new Node<string>("brown");
			Node<string> node3 = new Node<string>("fox");
			Node<string> node4 = new Node<string>("jumped");
			Node<string> node5 = new Node<string>("over");
			Node<string> node6 = new Node<string>("the");
			Node<string> node7 = new Node<string>("lazy");
			Node<string> node8 = new Node<string>("dog");
			Node<string> node9 = new Node<string>("and");
			Node<string> node10 = new Node<string>("said");

			// Populate first tree with first group of nodes
			tree1.Root = node1;
			tree1.Root.LeftChild = node2;
			tree1.Root.RightChild = node3;
			tree1.Root.LeftChild.LeftChild = node4;
			tree1.Root.LeftChild.RightChild = node5;
			tree1.Root.RightChild.LeftChild = node6;
			tree1.Root.RightChild.RightChild = node7;
			tree1.Root.LeftChild.LeftChild.LeftChild = node8;
			tree1.Root.LeftChild.LeftChild.RightChild = node9;
			tree1.Root.LeftChild.RightChild.LeftChild = node10;

			// Instantiate second tree
			BinaryTree<string> tree2 = new BinaryTree<string>();

			// Instantiate second group of nodes to put in second tree
			Node<string> node11 = new Node<string>("fast");
			Node<string> node12 = new Node<string>("brown");
			Node<string> node13 = new Node<string>("cat");
			Node<string> node14 = new Node<string>("hopped");
			Node<string> node15 = new Node<string>("over");
			Node<string> node16 = new Node<string>("the");
			Node<string> node17 = new Node<string>("sleeping");
			Node<string> node18 = new Node<string>("dog");
			Node<string> node19 = new Node<string>("and");
			Node<string> node20 = new Node<string>("shouted");

			// Populate second tree with second group of nodes
			tree2.Root = node11;
			tree2.Root.LeftChild = node12;
			tree2.Root.RightChild = node13;
			tree2.Root.LeftChild.LeftChild = node14;
			tree2.Root.LeftChild.RightChild = node15;
			tree2.Root.RightChild.LeftChild = node16;
			tree2.Root.RightChild.RightChild = node17;
			tree2.Root.LeftChild.LeftChild.LeftChild = node18;
			tree2.Root.LeftChild.LeftChild.RightChild = node19;
			tree2.Root.LeftChild.RightChild.LeftChild = node20;

			// Invoke TreeIntersection method
			List<string> sharedValues = TreeIntersection(tree1, tree2);

			// Print contents of the array of values common to both trees
			foreach (var item in sharedValues)
			{
				Console.WriteLine(item);
			}

			Console.ReadLine();
		}

		/// <summary>
		/// Takes in two binary trees and returns list of all values found in both trees
		/// </summary>
		/// <param name="tree1">first binary tree</param>
		/// <param name="tree2">second binary tree</param>
		/// <returns>List of values common to both trees</string></returns>
		public static List<string> TreeIntersection(BinaryTree<string> tree1, BinaryTree<string> tree2)
		{
			Hashtable ht = new Hashtable(1024);
			List<string> listOfSharedValues = new List<string>();
			
			// First internal helper method: traverses first tree recursively and add its values to hash table
			void PostOrder1(Node<string> root)
			{
				// Traverse tree
				if (root.LeftChild != null)
				{
					PostOrder1(root.LeftChild);
				}

				if (root.RightChild != null)
				{
					PostOrder1(root.RightChild);
				}

				// Logic for adding to HT
				ht.Add(root.Value, root.Value);
			}

			// Second internal helper method: traverses second tree recursively and add values found in both trees to an array
			void PostOrder2(Node<string> root)
			{
				// Traverse tree
				if (root.LeftChild != null)
				{
					PostOrder2(root.LeftChild);
				}

				if (root.RightChild != null)
				{
					PostOrder2(root.RightChild);
				}

				// Logic for adding to list of shared values
				if (ht.Contains(root.Value))
				{
					if (!listOfSharedValues.Contains(root.Value))
					{
						listOfSharedValues.Add(root.Value);
					}
				}
			}

			// Invoke helper methods defined above
			PostOrder1(tree1.Root);
			PostOrder2(tree2.Root);

			return listOfSharedValues;
		}
	}
}
