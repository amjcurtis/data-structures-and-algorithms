using Xunit;
using GraphDSA.Classes;
using System.Collections.Generic;

namespace XUnitTests_Graph
{
	public class UnitTest1
	{

		/// <summary>
		/// Tests whether AddVertex() method can add a vertex to graph
		/// </summary>
		[Fact]
		public void CanAddVertexToGraph()
		{
			// Arrange
			Graph<string> graph = new Graph<string>();

			// Act
			Vertex<string> a = graph.AddVertex("Detroit");
			
			// Assert
			Assert.Equal("Detroit", a.Value);
		}

		/// <summary>
		/// Tests whether AddUndirectedEdge() method can add an edge between two vertices
		/// </summary>
		[Fact]
		public void CanAddEdge()
		{
			// Arrange
			Graph<string> graph = new Graph<string>();
			Vertex<string> a = graph.AddVertex("Detroit");
			Vertex<string> b = graph.AddVertex("Boston");

			// Act
			graph.AddUndirectedEdge(a, b, 6);
			var edgeList = graph.GetNeighbors(a);

			// Assert
			Assert.Equal(edgeList[0].Vertex.Value, b.Value);
		}

		/// <summary>
		/// Tests whether GetVertices() method can return list of all vertices in graph
		/// </summary>
		[Fact]
		public void CanGetListOfNodes()
		{
			// ARRANGE
			Graph<string> graph = new Graph<string>();

			// Add vertices to graph
			Vertex<string> a = graph.AddVertex("Detroit");
			Vertex<string> b = graph.AddVertex("Boston");
			Vertex<string> c = graph.AddVertex("Atlanta");
			Vertex<string> d = graph.AddVertex("Denver");

			// ACT
			var vertList = graph.GetVertices();

			// ASSERT
			Assert.Equal(vertList[3].Value, d.Value);
		}

		/// <summary>
		/// Tests whether GetNeighbors() method can get list of all neighboring vertices of specified vertex
		/// </summary>
		[Fact]
		public void CanGetListOfNeighbors()
		{
			// ARRANGE
			Graph<string> graph = new Graph<string>();

			// Add vertices to graph
			Vertex<string> a = graph.AddVertex("Detroit");
			Vertex<string> b = graph.AddVertex("Boston");
			Vertex<string> c = graph.AddVertex("Atlanta");
			Vertex<string> d = graph.AddVertex("Denver");

			// Add edges to graph
			graph.AddUndirectedEdge(a, b, 6);
			graph.AddUndirectedEdge(a, c, 10);
			graph.AddUndirectedEdge(a, c, 13);
			graph.AddUndirectedEdge(a, d, 15);

			// ACT
			var neighborList = graph.GetNeighbors(a);

			// ASSERT
			Assert.Equal(neighborList[3].Vertex.Value, d.Value);
		}

		/// <summary>
		/// Tests whether GetNeightbors() method can return weight of edges between specified vertex and its neighboring vertices
		/// </summary>
		[Fact]
		public void CanReturnNeighborsWithWeightIncluded()
		{
			// ARRANGE
			Graph<string> graph = new Graph<string>();

			// Add vertices to graph
			Vertex<string> a = graph.AddVertex("Detroit");
			Vertex<string> b = graph.AddVertex("Boston");
			Vertex<string> c = graph.AddVertex("Atlanta");
			Vertex<string> d = graph.AddVertex("Denver");

			// Add edges to graph
			graph.AddUndirectedEdge(a, b, 6);
			graph.AddUndirectedEdge(a, c, 10);
			graph.AddUndirectedEdge(a, c, 13);
			graph.AddUndirectedEdge(a, d, 15);

			// ACT
			var neighborList = graph.GetNeighbors(a);

			// ASSERT
			Assert.Equal(15, neighborList[3].Weight);
		}

		/// <summary>
		/// Tests whether Size() method can return correct number of vertices in graph
		/// </summary>
		[Fact]
		public void CanReturnGraphSize()
		{
			// ARRANGE
			Graph<string> graph = new Graph<string>();

			// Add vertices to graph
			Vertex<string> a = graph.AddVertex("Detroit");
			Vertex<string> b = graph.AddVertex("Boston");
			Vertex<string> c = graph.AddVertex("Atlanta");
			Vertex<string> d = graph.AddVertex("Denver");

			// ACT
			int size = graph.Size();

			// ASSERT
			Assert.Equal(4, size);
		}

		/// <summary>
		/// Tests whether GetVertices() method can return vertex from graph with only a single vertex
		/// </summary>
		[Fact]
		public void CanReturnVertexFromGraphWithOneVertex()
		{
			// ARRANGE
			Graph<string> graph = new Graph<string>();
			Vertex<string> a = graph.AddVertex("Detroit");

			// ACT
			var vertList = graph.GetVertices();

			// ASSERT
			Assert.Equal(a.Value, vertList[0].Value);
		}

		/// <summary>
		/// Tests whether GetVertices() method can return null if graph is empty
		/// </summary>
		[Fact]
		public void CanReturnNullIfGraphEmpty()
		{
			// ARRANGE
			Graph<string> graph = new Graph<string>();

			// ACT
			List<Vertex<string>> vertList = graph.GetVertices();

			// ASSERT
			Assert.Null(vertList);
		}
	}
}
