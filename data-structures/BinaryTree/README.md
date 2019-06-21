# Binary Tree / Binary Search Tree

## Challenge

This challenge involved creating a .NET Core console app that implements a binary tree data
structure, with separate classes for a regular unstructured binary tree and a structured
binary search tree, as well as a generic `Node<T>` class shared by both tree classes. 

The `BinaryTree` class has depth-first traversal methods `PreOrder()`, `InOrder()`, and
`PostOrder()` that return generic `List<T>` collections containing the value of all nodes in
the tree. `BinaryTree` also has a `TraverseBreadthFirst()` method that does what it sounds
like it does...and returns a boolean depending on whether the method fully traverses the tree. The class was further extended with a method `FindMaxValue()` that does a breadth-first traversal of a binary tree and returns the highest node value found in the tree. 

The `BinarySearchTree` class has methods `Add()` (for inserting a node in the
appropriate place in the tree) and `Contains()` (for searching for a given value in the tree).
Both the `BinaryTree` and `BinarySearchTree` classes are implemented as generic collections (`<T>`).


## Approach & Efficiency

The three depth-first traversal methods on the `BinaryTree` class have a time complexity of
*O(n)* and a space complexity of *O(h)* (where *h* is the height of the tree). 

The breadth-first traversals of a binary tree (implemented in the `TraverseBreadthFirst()` and `FindMaxValue()` methods) have a time complexity of *O(n)* and a space
complexity of *O(w)*, where *w* is the width of the tree. 

The `Add()` and `Contains()` methods on the `BinarySearchTree` class have a time complexity of
*O(log n)* at minimum and space complexity of *O(1)* (because we aren't allocating any 
additional space when searching for a node).
