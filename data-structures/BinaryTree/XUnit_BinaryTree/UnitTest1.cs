using System;
using BinaryTree.Classes;
using Xunit;

namespace XUnit_BinaryTree
{
	public class UnitTest1
	{
		[Fact]
		public void CanInstantiateEmptyTree()
		{
			//Node<int> intNode = new Node<int>(1);
			BinaryTree<int> tree = new BinaryTree<int>();

			Assert.Null(tree.Root);
		}
	}
}
