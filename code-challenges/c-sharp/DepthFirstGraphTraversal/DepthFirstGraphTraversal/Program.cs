using GraphDSA.Classes;
using System;
using System.Collections;
using System.Collections.Generic;

namespace DepthFirstGraphTraversal
{
	public class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
		}

		public static List<Vertex<string>> DepthFirstGraph(Vertex<string> root)
		{
			Stack stack = new Stack();
			Hashtable visitedHT = new Hashtable();
			stack.Push(root);
			while (stack.Peek .Count != 0)
			while (stack.Peek() != null)
			{
				Vertex<string> top = (Vertex<string>) stack.Pop();
				visitedHT.Add(top);
				if (graph.GetNeighbors(top) )
				{

				}

			}
		}
	}
}
