﻿using System;
using System.Collections.Generic;

namespace GraphDSA.Classes
{
	public class Graph<T>
	{
		// Define adjacency list
		public Dictionary<Vertex<T>, List<Edge<T>>> AdjacencyList { get; set; }

		// Set initial value of graph's size counter
		private int _size = 0;

		// Graph constructor
		public Graph()
		{
			AdjacencyList = new Dictionary<Vertex<T>, List<Edge<T>>>();
		}

		// METHODS

		/// <summary>
		/// Adds a single vertex to graph and increments size property of graph
		/// </summary>
		/// <param name="value">value of vertex to add</param>
		/// <returns>returns the newly added vertex</returns>
		public Vertex<T> AddVertex(T value)
		{
			Vertex<T> vertex = new Vertex<T>(value);

			AdjacencyList.Add(vertex, new List<Edge<T>>());

			_size++;

			return vertex;
		}

		/// <summary>
		/// Add directed edge of specified weight from one specified vertex to another
		/// </summary>
		/// <param name="a">first vertex</param>
		/// <param name="b">second vertex</param>
		/// <param name="weight">weight of edge</param>
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

		/// <summary>
		/// Adds an undirected edge of given weight between two given vertices
		/// </summary>
		/// <param name="a">first vertex</param>
		/// <param name="b">second vertex</param>
		/// <param name="weight">weight of edge</param>
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

		/// <summary>
		/// Returns list of all vertices in graph
		/// </summary>
		/// <returns>List of vertices</returns>
		public List<Vertex<T>> GetVertices()
		{
			if (AdjacencyList.Count < 1)
			{
				return null;
			}

			List<Vertex<T>> vertices = new List<Vertex<T>>();

			foreach (var vertex in AdjacencyList)
			{
				vertices.Add(vertex.Key);
			}
			return vertices;
		}

		/// <summary>
		/// Return number of vertices in graph
		/// </summary>
		/// <returns>int size of graph</returns>
		public int Size()
		{
			return _size;
		}

		/// <summary>
		/// Prints all key:value pairs in graph to the console
		/// </summary>
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

		/// <summary>
		/// Traverses graph breadth-first and returns list of all nodes traversed
		/// </summary>
		/// <param name="startingVertex">vertex</param>
		/// <returns>list of all vertices</returns>
		public List<Vertex<T>> BreadthFirst(Vertex<T> startingVertex)
		{
			// List of traversed vertices to return
			List<Vertex<T>> outputList = new List<Vertex<T>>();

			// Queue to store vertices in as they're visited
			Queue<Vertex<T>> breadth = new Queue<Vertex<T>>();

			// Hashset to store vertices visited so far
			HashSet<Vertex<T>> visited = new HashSet<Vertex<T>>();

			breadth.Enqueue(startingVertex);
			visited.Add(startingVertex);

			// While queue is not empty...
			while (breadth.TryPeek(out startingVertex))
			{
				// Dequeue front of queue and add to output list
				Vertex<T> front = breadth.Dequeue();
				outputList.Add(front);

				List<Edge<T>> neighbors = GetNeighbors(front);
				foreach (Edge<T> neighbor in neighbors)
				{
					// If vertex has not already been visited...
					if (!visited.Contains(neighbor.Vertex))
					{
						breadth.Enqueue(neighbor.Vertex);
						visited.Add(neighbor.Vertex);
					}
				}
			}

			return outputList;
		}
	}
}
