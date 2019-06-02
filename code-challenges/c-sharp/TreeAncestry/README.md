# Node Ancestry in a Binary Tree

## Challenge

In this challenge I wrote a C# console app containing a method called `IsAncestor()` that determines whether a node containing a specified value is an "ancestor" of a node containing another specified value. An "ancestor" node is defined as any node present in the path from a given node to the root node (including the root node). 

My approach involves using a recursive preorder traversal method (defined internally within the `IsAncestor()` method) to first check whether the tree contains the specified ancestor node and then, if so, to check whether the specified descendant value is contained downstream from the ancestor node. The same preorder method (`PreOrderContains()`) is used for both checks in succession, taking different arguments each time. This effectively treats the ancestor node as the root of its own tree and checks to see whether the descendant is contained in that tree; if so, then an ancestor-descendant relationship has been established.

My solution uses my own custom binary tree implementation.

Note: for the sake of this code challenge, it is assumed that the tree contains only unique values.


## API

### Parameters

The `IsAncestor()` method takes three arguments as input: 

1. An `int` _a_ (value of ancestor node to look for)
2. An `int` _b_ (value of descendant node to look for)
3. A binary tree node

### Return Value

The method returns a nullable boolean (`bool?`) depending on whether or not the tree contained both the specified ancestor and descendant values _and_ the nodes containing the values were in an ancestor-descendant relationship. 


## Approach & Efficiency

### Time Efficiency

* Recursive preorder traversal: O(n^2) (until I can get the recursive method to stop traversing further once the value being searched for is found)

### Space Efficiency

* Recursive preorder traversal: O(h) where h is the height of the tree
