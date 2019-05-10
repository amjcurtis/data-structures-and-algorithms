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
			Graph<string> graph = new Graph<string>();

			// Add vertices to graph
			Vertex<string> a = graph.AddVertex("A");
			Vertex<string> b = graph.AddVertex("B");
			Vertex<string> c = graph.AddVertex("C");
			Vertex<string> d = graph.AddVertex("D");
			Vertex<string> e = graph.AddVertex("E");
			Vertex<string> f = graph.AddVertex("F");
			Vertex<string> g = graph.AddVertex("G");
			Vertex<string> h = graph.AddVertex("H");

			// Add edges to graph
			graph.AddUndirectedEdge(a, b, 5);
			graph.AddUndirectedEdge(a, d, 5);
			graph.AddUndirectedEdge(b, c, 5);
			graph.AddUndirectedEdge(c, g, 5);
			graph.AddUndirectedEdge(d, e, 5);
			graph.AddUndirectedEdge(d, f, 5);
			graph.AddUndirectedEdge(d, h, 5);

			Console.WriteLine("PRINT GRAPH\n");
			//graph.Print();

			List<Vertex<string>> depthFirstOutput = DepthFirstGraph(graph, a);
			foreach (var vertex in depthFirstOutput)
			{
				Console.WriteLine(vertex.Value);
			}

		}

		public static List<Vertex<string>> DepthFirstGraph(Graph<string> graph, Vertex<string> root)
		{
			// Input validation
			if (!graph.GetVertices().Contains(root))
			{
				return null;
			}

			List<Vertex<string>> traversed = new List<Vertex<string>>();

			//TODO verify this is actually necessary
			// If graph contains only 1 vertex
			if (graph.GetNeighbors(root).Count == 0)
			{
				traversed.Add(root);
				return traversed;
			}

			Stack stack = new Stack();
			//Hashtable visitedHT = new Hashtable();
			HashSet<Vertex<string>> visitedHS = new HashSet<Vertex<string>>();

			stack.Push(root);
				bool unvisitedNeighbors = false;
			while (stack.Peek() != null)
			//while (stack.Count != 0) // Alternative loop condition
			{
				Vertex<string> top = (Vertex<string>) stack.Peek();

				List<Edge<string>> neighbors = graph.GetNeighbors(top);

				foreach (var neighbor in neighbors)
				{
					if (!visitedHS.Contains(neighbor.Vertex))
					{
						//visitedHS.Add(top); // Mark top as visited
						unvisitedNeighbors = true;
						stack.Push(neighbor.Vertex); // Push not-yet-visited neighbor into stack
					}
					//else
					//{
					//	stack.Pop();
					//}
				}
				if (unvisitedNeighbors == true)
				{
					visitedHS.Add(top); // Mark top as visited
					traversed.Add(top);
				}
				else // If top node doesn't have unvisited neighbors
				{
					stack.Pop();
				}
			}

			return traversed;
		}
	}
}
