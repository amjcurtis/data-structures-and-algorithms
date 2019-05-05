using GraphDSA.Classes;
using System;

namespace GraphDSA
{
	class Program
	{
		static void Main(string[] args)
		{
			Graph<string> graph = new Graph<string>();

			var a = graph.AddVertex("Detroit");
			var b = graph.AddVertex("Boston");
			var c = graph.AddVertex("Atlanta");

			graph.AddUndirectedEdge(a, b, 6);
			graph.AddUndirectedEdge(b, c, 10);
			graph.AddDirectedEdge(a, c, 13);

			graph.Print();

			Console.ReadLine();
		}
	}
}
