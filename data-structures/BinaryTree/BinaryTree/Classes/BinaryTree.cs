using BinaryTree.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTree
{
	public class BinaryTree<T>
	{
		public Node<T> Root { get; set; }
		
		// Array for storing values to be output from methods below
		T[] output = new T[15];

		// Count to use for tracking number of values in output array
		int count;

		/// <summary>
		/// Performs depth-first traversal of binary tree, inspecting root node before traversing to child nodes
		/// </summary>
		/// <param name="root">root node of tree</param>
		/// <returns>array of type T</returns>
		public T[] PreOrder(Node<T> root)
		{
			// Clear array (reset all indices to default value)
			Array.Clear(output, 0, output.Length);


		} 

		// Helper method for pushing new values to output array
		public void AddToArray(T value)
		{
			if (count == output.Length)
			{
				Array.Resize(ref output, output.Length + (output.Length / 2));
			}

			// Updates output array at next index
			output[count++] = value;
		}
	}
}
