# Graph

## Challenge

In this project I implemented a custom-built graph data structure written in C#. 

My GraphDSA namespace includes classes `Graph<T>`, `Vertex<T>`, and `Edge<T>`.

## Efficiency

* Adding new vertex to graph: O(1) time, O(1) space
* Adding an edge between two vertices: O(1) time, O(1) space
* Getting list of all vertices in graph: O(n) time, O(n) space
* Getting list of all of a vertex's neighboring vertices: O(n) time, O(n) space
* Searching graph: O(1) time, O(1) space

## API

My Graph class has the following methods:

* `AddVertex()`: Takes in value of type <T> as argument, add a new vertex with that value to graph, and returns the new vertex.
* `AddDirectedEdge()`: Void method that takes in two vertices of type <T> and an integer weight as arguments, add a directed edge between the two vertices with a weight of the specified integer.
* `AddUndirectedEdge()`: Void method that takes in two vertices of type <T> and an integer weight as arguments, add an undirected edge between the two vertices with a weight of the specified integer.
* `GetNeighbors()`: Takes a vertex as argument and returns an adjacency list containing all the edges connecting to the specified vertex.
* `GetVertices()`: Returns a generic list of all vertices in the graph, or null if graph contains no vertices.
* `Size()`: Void method that returns number of vertices in graph.
* `Print()`: Void method that writes all vertices in the graph to the console.
