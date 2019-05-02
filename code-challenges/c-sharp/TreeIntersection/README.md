# Intersecting Values in Binary Tree

## Challenge

In this challenge I wrote a C# console app containing a method that takes two binary trees as inputs and returns a list of the values common to both trees.

My solution use my own custom implementations of binary tree and hash table data structures. 

## Approach & Efficiency

### Time Efficiency

* Binary tree traversal (depth-first recursive approach)
	* O(n)

* Hash table lookup
	* O(1)

### Space Efficiency

* Binary tree

	* O(h) where *h* is the height of the tree

* Hash table

	* O(n)

## Solution

First-take whiteboard solution:

![Initial whiteboard planning](https://github.com/amjcurtis/data-structures-and-algorithms/blob/master/assets/binarytree-intersection-whiteboard.JPG)
