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
			// Instantiate new node and add as root of tree1
			Node<string> tree1Root = new Node<string>("The");
			BinaryTree<string> tree1 = new BinaryTree<string>(tree1Root);

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

			// Populate tree1 with nodes
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

			// Instantiate new node and add as root of tree2
			Node<string> tree2Root = new Node<string>("A");
			BinaryTree<string> tree2 = new BinaryTree<string>(tree2Root);

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

			// Populate tree2 with nodes
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

			foreach (var item in sharedValues)
			{
				Console.WriteLine(item);
			}

			Console.ReadLine();
		}

		public static List<string> TreeIntersection(BinaryTree<string> tree1, BinaryTree<string> tree2)
		{
			Hashtable ht = new Hashtable(1024);
			List<string> list = new List<string>();
			
			void PostOrder1(Node<string> root)
			{
				// Base case
				if (root == null)
				{
					return;
				}

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
				if (!ht.Contains(root.Value))
				{
					ht.Add(root.Value, root.Value);
				}
			}

			// Invoke helper method defined above
			PostOrder1(tree1.Root);

			void PostOrder2(Node<string> root)
			{
				// Base case
				if (root == null)
				{
					return;
				}

				// Traverse tree
				if (root.LeftChild != null)
				{
					PostOrder1(root.LeftChild);
				}

				if (root.RightChild != null)
				{
					PostOrder1(root.RightChild);
				}

				// Logic for adding to List
				if (ht.Contains(root.Value))
				{
					list.Add(root.Value);
				}
			}

			// Invoke helper method defined above
			PostOrder2(tree2.Root);

			return list;
		}
	}
}
