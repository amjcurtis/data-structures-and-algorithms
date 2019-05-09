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

		public static List<Vertex<string>> DepthFirstGraph(Graph<Vertex<string>> graph)
		{
			Stack stack = new Stack();
			Hashtable visited = new Hashtable();
			stack.Push();
			while (stack.Count != 0)
			{
				Vertex<string> top = (Vertex<string>) stack.Pop();
				visited.Add(top);
				if (graph.GetNeighbors(top) )
				{

				}

			}
		}
	}
}
