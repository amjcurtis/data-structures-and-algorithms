using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTree.Classes
{
	public class Node<T>
	{
		public T Value { get; set; }
		public Node<T> LeftChild { get; set; }
		public Node<T> RightChild { get; set; }

		// Node constructor
		public Node(T value)
		{
			Value = value;
			LeftChild = null;
			RightChild = null;
		}

		// Empty constructor so can instantiate empty node
		public Node()
		{
		}
	}
}
