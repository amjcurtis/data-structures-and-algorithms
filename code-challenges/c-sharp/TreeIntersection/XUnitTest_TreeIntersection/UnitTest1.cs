using BinaryTree.Classes;
using TreeIntersection;
using System;
using System.Collections.Generic;
using Xunit;

namespace XUnitTest_TreeIntersection
{
	public class UnitTest1
	{
		/// <summary>
		/// Tests whether TreeIntersect method can correctly return list of shared values ("happy path")
		/// </summary>
		[Fact]
		public void CanReturnCorrectListOfSharedValues()
		{
			// ARRANGE

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


			// ACT

			// Invoke TreeIntersect method
			List<string> sharedValues = Program.TreeIntersect(tree1, tree2);


			// ASSERT
			Assert.Equal("dog", sharedValues[0]);
		}

		[Fact]
		public void CanReturnEmptyListIfNotSharedValuesFound()
		{
			// ARRANGE

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
			Node<string> node12 = new Node<string>("black");
			Node<string> node13 = new Node<string>("cat");
			Node<string> node14 = new Node<string>("hopped");
			Node<string> node15 = new Node<string>("onto");
			Node<string> node16 = new Node<string>("a");
			Node<string> node17 = new Node<string>("sleeping");
			Node<string> node18 = new Node<string>("cow");
			Node<string> node19 = new Node<string>("or");
			Node<string> node20 = new Node<string>("something");

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


			// ACT

			// Invoke TreeIntersect method
			List<string> sharedValues = Program.TreeIntersect(tree1, tree2);


			// ASSERT
			Assert.Empty(sharedValues);
		}

		/// <summary>
		/// Tests expected failure case of when either tree is empty
		/// </summary>
		[Fact]
		public void CanReturnNullIfEitherTreeEmpty()
		{
			// ARRANGE

			// Instantiate first tree
			BinaryTree<string> tree1 = new BinaryTree<string>();

			// Instantiate first group of nodes to put in first tree
			Node<string> node1 = new Node<string>("quick");
			Node<string> node2 = new Node<string>("brown");
			Node<string> node3 = new Node<string>("fox");

			// Populate first tree with first group of nodes
			tree1.Root = node1;
			tree1.Root.LeftChild = node2;
			tree1.Root.RightChild = node3;
			
			// Instantiate *empty* second tree
			BinaryTree<string> tree2 = new BinaryTree<string>();

			
			// ACT

			// Invoke TreeIntersect method
			List<string> sharedValues = Program.TreeIntersect(tree1, tree2);


			// ASSERT
			Assert.Null(sharedValues);
		}
	}
}
