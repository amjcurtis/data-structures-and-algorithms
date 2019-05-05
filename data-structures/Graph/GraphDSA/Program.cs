using GraphDSA.Classes;
using System;
using System.Collections.Generic;

namespace GraphDSA
{
	class Program
	{
		static void Main(string[] args)
		{
			Graph<string> graph = new Graph<string>();

			Vertex<string> a = graph.AddVertex("Detroit");
			Vertex<string> b = graph.AddVertex("Boston");
			Vertex<string> c = graph.AddVertex("Atlanta");
			Vertex<string> d = graph.AddVertex("Denver");

			graph.AddUndirectedEdge(a, b, 6);
			graph.AddUndirectedEdge(b, c, 10);
			graph.AddDirectedEdge(a, c, 13);
			graph.AddUndirectedEdge(b, d, 15);

			// Demo Print method
			graph.Print();

			// Demo GetNeighbors method
			var listOfEdges = graph.GetNeighbors(b);
			foreach (var edge in listOfEdges)
			{
				Console.WriteLine(edge.Vertex.Value);
			}

			// Demo GetVertices method
			var listOfVerts = graph.GetVertices();

			Console.ReadLine();
		}
	}
}
