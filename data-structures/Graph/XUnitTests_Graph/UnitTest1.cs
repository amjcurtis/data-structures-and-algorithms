using Xunit;
using GraphDSA.Classes;

namespace XUnitTests_Graph
{
	public class UnitTest1
	{
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

		[Fact]
		public void CanGetReturnListOfNodes()
		{
			// ARRANGE
			Graph<string> graph = new Graph<string>();

			// Add vertices to graph
			Vertex<string> a = graph.AddVertex("Detroit");
			Vertex<string> b = graph.AddVertex("Boston");
			Vertex<string> c = graph.AddVertex("Atlanta");
			Vertex<string> d = graph.AddVertex("Denver");

			//// Add edges to graph
			//graph.AddUndirectedEdge(a, b, 6);
			//graph.AddUndirectedEdge(b, c, 10);
			//graph.AddDirectedEdge(a, c, 13);
			//graph.AddUndirectedEdge(b, d, 15);

			// ACT
			var vertList = graph.GetVertices();

			// ASSERT
			Assert.Equal(vertList[3].Value, d.Value);
		}
	}
}
