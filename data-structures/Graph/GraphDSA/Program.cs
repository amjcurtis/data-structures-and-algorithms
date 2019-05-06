using GraphDSA.Classes;
using System;
using System.Collections.Generic;

namespace GraphDSA
{
	public class Program
	{
		static void Main(string[] args)
		{
			Graph<string> graph = new Graph<string>();

			// Add vertices to graph
			Vertex<string> a = graph.AddVertex("Detroit");
			Vertex<string> b = graph.AddVertex("Boston");
			Vertex<string> c = graph.AddVertex("Atlanta");
			Vertex<string> d = graph.AddVertex("Denver");

			// Add edges to graph
			graph.AddUndirectedEdge(a, b, 6);
			graph.AddUndirectedEdge(b, c, 10);
			graph.AddDirectedEdge(a, c, 13);
			graph.AddUndirectedEdge(b, d, 15);

			// Demo Print method
			Console.WriteLine("PRINT GRAPH");
			graph.Print();

			// Demo GetNeighbors method
			Console.WriteLine("LIST OF EDGES");
			var listOfEdges = graph.GetNeighbors(b);
			foreach (var edge in listOfEdges)
			{
				Console.WriteLine(edge.Vertex.Value);
			}

			// Demo GetVertices method
			Console.WriteLine("LIST OF VERTICES");
			var listOfVerts = graph.GetVertices();
			foreach (var vertex in listOfVerts)
			{
				Console.WriteLine(vertex.Value);
			}

			// Demo Size method
			Console.WriteLine("GRAPH SIZE");
			int graphSize = graph.Size();
			Console.WriteLine(graphSize);
		}
	}
}
