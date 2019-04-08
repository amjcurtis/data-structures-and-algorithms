using System;
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

	}
}
