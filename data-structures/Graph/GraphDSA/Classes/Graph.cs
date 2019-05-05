using System;
using System.Collections.Generic;
using System.Text;

namespace GraphDSA.Classes
{
	class Graph<T>
	{

		public Dictionary<Vertex<T>, List<Edge<T>>> AdjacencyList { get; set; }
		private int _size = 0;

		// Constructor
		public Graph()
		{
			AdjacencyList = new Dictionary<Vertex<T>, List<Edge<T>>>();
		}

		// METHODS

		
		public Vertex<T> AddVertex(T value)
		{
			Vertex<T> vertex = new Vertex<T>(value);

			AdjacencyList.Add(vertex, new List<Edge<T>>());

			_size++;

			return vertex;
		}

		public void AddDirectedEdge(Vertex<T> a, Vertex<T> b, int weight)
		{
			AdjacencyList[a].Add(

				new Edge<T>
				{
					Weight = weight,
					Vertex = b
				}
			);
		}

		public void AddUndirectedEdge(Vertex<T> a, Vertex<T> b, int weight)
		{
			AddDirectedEdge(a, b, weight);
			AddDirectedEdge(b, a, weight);
		}

		/// <summary>
		/// Returns iterable list of edges between specified vertex and adjacent vertices
		/// </summary>
		/// <param name="vertex">specified vertex</param>
		/// <returns>list of edges</returns>
		public List<Edge<T>> GetNeighbors(Vertex<T> vertex)
		{
			return AdjacencyList[vertex];
		}

		public List<Vertex<T>> GetVertices()
		{
			List<Vertex<T>> vertices = new List<Vertex<T>>();

			foreach (var vertex in AdjacencyList)
			{
				vertices.Add(vertex.Key);
			}
			return vertices;
		}

		public void Print()
		{
			foreach (var vertex in AdjacencyList)
			{
				Console.Write($"Vertex: {vertex.Key.Value}  :  ");
				foreach (var edge in vertex.Value)
				{
					Console.Write($"{edge.Vertex.Value}, {edge.Weight}  ->  ");
				}
				Console.WriteLine("NULL");
			}
		}
	}
}
