using System;
using System.Collections.Generic;
using BinaryTree.Classes;
using Xunit;

namespace XUnit_BinaryTree
{
	public class UnitTest1
	{

		/// <summary>
		/// Tests whether can instantiate empty binary tree with no nodes
		/// </summary>
		[Fact]
		public void CanInstantiateEmptyBT()
		{
			// Act
			BinaryTree<int> tree = new BinaryTree<int>();

			// Assert
			Assert.Null(tree.Root);
		}

		/// <summary>
		/// Tests whether can instantiate tree and add single root node
		/// </summary>
		[Fact]
		public void CanInstantiateBinaryTreeWithSingleNode()
		{
			// Arrange
			Node<int> intNode = new Node<int>(1);

			// Act
			BinaryTree<int> tree = new BinaryTree<int>(intNode);
			
			// Assert
			Assert.Equal(1, tree.Root.Value);
		}

		/// <summary>
		/// Tests whether can add left child node to BT root
		/// </summary>		
		[Fact]
		public void CanAddLeftChildNodeToBT()
		{
			// Arrange
			Node<int> intNode = new Node<int>(1);
			BinaryTree<int> tree = new BinaryTree<int>(intNode);
			Node<int> left = new Node<int>(2);

			// Act
			tree.Root.LeftChild = left;

			// Assert
			Assert.Equal(2, tree.Root.LeftChild.Value);
		}

		/// <summary>
		/// Tests whether can add right child node to BT root
		/// </summary>
		[Fact]
		public void CanAddRightChildNodeToBT()
		{
			// Arrange
			Node<int> intNode = new Node<int>(1);
			BinaryTree<int> tree = new BinaryTree<int>(intNode);
			Node<int> right = new Node<int>(3);

			// Act
			tree.Root.RightChild = right;

			// Assert
			Assert.Equal(3, tree.Root.RightChild.Value);
		}

		/// <summary>
		/// Tests whether can return list from PreOrder method
		/// </summary>
		[Fact]
		public void CanReturnCollectionFromPreOrderTraversalOfBT()
		{
			// Arrange
			Node<int> intNode = new Node<int>(11);
			BinaryTree<int> tree = new BinaryTree<int>(intNode);
			Node<int> left = new Node<int>(12);
			Node<int> right = new Node<int>(13);
			tree.Root.LeftChild = left;
			tree.Root.RightChild = right;

			// Act
			List<int> outputList = tree.PreOrder(intNode);

			// Assert
			Assert.Equal(11, outputList[0]);
		}

		/// <summary>
		/// Tests whether can return list from InOrder method
		/// </summary>
		[Fact]
		public void CanReturnCollectionFromInOrderTraversalOfBT()
		{
			// Arrange
			Node<int> intNode = new Node<int>(11);
			BinaryTree<int> tree = new BinaryTree<int>(intNode);
			Node<int> left = new Node<int>(12);
			Node<int> right = new Node<int>(13);
			tree.Root.LeftChild = left;
			tree.Root.RightChild = right;

			// Act
			List<int> outputList = tree.InOrder(intNode);

			// Assert
			Assert.Equal(11, outputList[1]);
		}

		/// <summary>
		/// Tests whether can return list from PostOrder method
		/// </summary>
		[Fact]
		public void CanReturnCollectionFromPostOrderTraversalOfBT()
		{
			// Arrange
			Node<int> intNode = new Node<int>(11);
			BinaryTree<int> tree = new BinaryTree<int>(intNode);
			Node<int> left = new Node<int>(12);
			Node<int> right = new Node<int>(13);
			tree.Root.LeftChild = left;
			tree.Root.RightChild = right;

			// Act
			List<int> outputList = tree.PostOrder(intNode);

			// Assert
			Assert.Equal(11, outputList[2]);
		}

		/// <summary>
		/// Tests "happy path" of populating tree with nodes and then traversing tree
		/// </summary>
		[Fact]
		public void CanTraverseBinaryTreeBreadthFirst()
		{
			// ARRANGE
			// Instantiate tree and populate with nodes
			BinaryTree<int> tree = new BinaryTree<int>();

			Node<int> node1 = new Node<int>(11);
			Node<int> node2 = new Node<int>(12);
			Node<int> node3 = new Node<int>(13);
			Node<int> node4 = new Node<int>(14);
			Node<int> node5 = new Node<int>(15);
			Node<int> node6 = new Node<int>(16);
			Node<int> node7 = new Node<int>(17);

			tree.Root = node1;
			tree.Root.LeftChild = node2;
			tree.Root.RightChild = node3;
			tree.Root.LeftChild.LeftChild = node4;
			tree.Root.LeftChild.RightChild = node5;
			tree.Root.RightChild.LeftChild = node6;
			tree.Root.RightChild.RightChild = node7;

			// ACT
			bool treeTraversed = tree.TraverseBreadthFirst(tree);

			// ASSERT
			Assert.True(treeTraversed);
		}

		/// <summary>
		/// Tests whether can return false to indicate empty tree won't be traversed
		/// </summary>
		[Fact]
		public void CannotTraverseEmptyTree()
		{
			// ARRANGE
			// Instantiate empty tree
			BinaryTree<int> tree = new BinaryTree<int>();

			// ACT
			bool treeTraversed = tree.TraverseBreadthFirst(tree);

			// ASSERT
			Assert.False(treeTraversed);
		}
	}
}
