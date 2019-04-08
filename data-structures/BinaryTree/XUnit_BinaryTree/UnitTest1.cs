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
		public void CanInstantiateEmptyTree()
		{
			//Node<int> intNode = new Node<int>(1);
			BinaryTree<int> tree = new BinaryTree<int>();

			Assert.Null(tree.Root);
		}

		/// <summary>
		/// Tests whether can instantiate tree and add single root node
		/// </summary>
		[Fact]
		public void CanInstantiateTreeWithSingleNode()
		{
			Node<int> intNode = new Node<int>(1);
			BinaryTree<int> tree = new BinaryTree<int>(intNode);

			Assert.Equal(1, tree.Root.Value);
		}
	}
}
