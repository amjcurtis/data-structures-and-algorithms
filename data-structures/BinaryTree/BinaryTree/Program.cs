using System;
using BinaryTree.Classes;
using System.Collections.Generic;

namespace BinaryTree
{
	public class Program
	{
		static void Main(string[] args)
		{
			BinaryTree<int> tree = new BinaryTree<int>();

			// Instantiate nodes to populate tree
			Node<int> node1 = new Node<int>(1);
			Node<int> node2 = new Node<int>(2);
			Node<int> node3 = new Node<int>(3);
			Node<int> node4 = new Node<int>(4);
			Node<int> node5 = new Node<int>(5);
			Node<int> node6 = new Node<int>(6);
			Node<int> node7 = new Node<int>(7);
			Node<int> node8 = new Node<int>(8);
			Node<int> node9 = new Node<int>(9);
			Node<int> node10 = new Node<int>(10);

			// Populate tree with nodes
			tree.Root = node1;
			tree.Root.LeftChild = node2;
			tree.Root.RightChild = node3;
			tree.Root.LeftChild.LeftChild = node4;
			tree.Root.LeftChild.RightChild = node5;
			tree.Root.RightChild.LeftChild = node6;
			tree.Root.RightChild.RightChild = node7;
			tree.Root.LeftChild.LeftChild.LeftChild = node8;
			tree.Root.LeftChild.LeftChild.RightChild = node9;
			tree.Root.LeftChild.RightChild.LeftChild = node10;

			/*				 (tree)
							   1
							  /  \
							2      3
						   / \    / \
						 4    5  6   7
						/\	 /			
					   8  9 10

							  (bst)
							   50
							  /  \
							40    60
						   / \    / \
						 35  45  55  65
						/\	 /			
					  33 37 42
			*/

		
			// Instantiate and populate new tree for demo'ing IsBinarySearchTree method
			BinaryTree<int> bst = new BinaryTree<int>();
			bst.Root = new Node<int>(50);
			bst.Root.LeftChild = new Node<int>(40);
			bst.Root.RightChild = new Node<int>(60);
			bst.Root.LeftChild.LeftChild = new Node<int>(35);
			bst.Root.LeftChild.RightChild = new Node<int>(45);
			bst.Root.RightChild.LeftChild = new Node<int>(55);
			bst.Root.RightChild.RightChild = new Node<int>(65);
			bst.Root.LeftChild.LeftChild.LeftChild = new Node<int>(33);
			bst.Root.LeftChild.LeftChild.RightChild = new Node<int>(37);
			bst.Root.LeftChild.RightChild.LeftChild = new Node<int>(42);

			
			// Demo preorder traversal
			Console.WriteLine("PREORDER");
			List<int> preOrderOutput = tree.PreOrder(tree.Root);
			foreach (int num in preOrderOutput)
			{
				Console.Write("{0} ", num);
			}
			Console.WriteLine("\n");
			tree.Nodes.Clear();

			
			// Demo inorder traversal
			Console.WriteLine("INORDER");
			List<int> inOrderOutput = tree.InOrder(tree.Root);
			foreach (int num in inOrderOutput)
			{
				Console.Write("{0} ", num);
			}
			Console.WriteLine("\n");
			tree.Nodes.Clear();

			
			// Demo postorder traversal
			Console.WriteLine("POSTORDER");
			List<int> postOrderOutput = tree.PostOrder(tree.Root);
			foreach (int num in postOrderOutput)
			{
				Console.Write("{0} ", num);
			}
			Console.WriteLine("\n");
			tree.Nodes.Clear();

			
			// Demo depth-first traversal using a stack
			Console.WriteLine("DEPTH-FIRST TRAVERSAL WITH STACK");
			List<int> depthFirstOutput = tree.TraverseDepthFirstWithStack(tree.Root);
			foreach (var num in depthFirstOutput)
			{
				Console.Write("{0} ", num);
			}
			Console.WriteLine("\n");
			tree.Nodes.Clear();

			
			// Demo breadth-first tree traversal
			Console.WriteLine("BREADTH-FIRST TRAVERSAL WITH QUEUE");
			List<int> outputOfBreadthFirst = tree.TraverseBreadthFirst(tree.Root);
			foreach (var num in outputOfBreadthFirst)
			{
				Console.Write("{0} ", num);
			}
			Console.WriteLine("\n");
			tree.Nodes.Clear();

			
			// Demo IsBinarySearchTree method
			Console.WriteLine("TEST WHETHER TREE IS BINARY SEARCH TREE");
			Console.WriteLine(tree.IsBinarySearchTree(tree.Root));
			Console.WriteLine(bst.IsBinarySearchTree(bst.Root));
			Console.WriteLine();

			
			// Demo FindMaxValue method
			int? max = tree.FindMaxValue(tree.Root);
			Console.WriteLine($"Max value is: {(max.HasValue ? max.ToString() : "NULL")}");
			Node<int> nullNode = null;
			int? nullMax = tree.FindMaxValue(nullNode);
			Console.WriteLine($"Max value is: {(nullMax.HasValue ? nullMax.ToString() : "NULL")}");

			
			// Demo recursive IsBalancedRecursive method
			Console.WriteLine($"tree is balanced: {tree.IsBalancedRecursive(tree.Root)}"); // true
			// Unbalance tree
			tree.Root.RightChild.LeftChild = null;
			tree.Root.RightChild.RightChild = null;
			tree.Root.LeftChild.RightChild.LeftChild = null;
			Console.WriteLine($"tree is balanced: {tree.IsBalancedRecursive(tree.Root)}"); // false


			// Demo MergeTrees method
			BinaryTree<int> treeToMerge1 = new BinaryTree<int>();
			treeToMerge1.Root = new Node<int>(1);
			treeToMerge1.Root.LeftChild = new Node<int>(3);
			treeToMerge1.Root.RightChild = new Node<int>(2);
			treeToMerge1.Root.LeftChild.LeftChild = new Node<int>(5);

			BinaryTree<int> treeToMerge2 = new BinaryTree<int>();
			treeToMerge2.Root = new Node<int>(2);
			treeToMerge2.Root.LeftChild = new Node<int>(1);
			treeToMerge2.Root.RightChild = new Node<int>(3);
			treeToMerge2.Root.LeftChild.RightChild = new Node<int>(4);
			treeToMerge2.Root.RightChild.RightChild = new Node<int>(7);

			Node<int> newTreeRoot = MergeTrees(treeToMerge1.Root, treeToMerge2.Root);
			List<int> mergedTreeNodeValues = BreadthFirstStatic(newTreeRoot);
			foreach (int value in mergedTreeNodeValues)
			{
				Console.WriteLine(value);
			}
		}


		public static Node<int> MergeTrees(Node<int> root1, Node<int> root2)
		{
			if (root1 == null && root2 == null)
			{
				return null;
			}
			else if (root1 == null && root2 != null)
			{
				return root2;
			}
			else if (root1 != null && root2 == null)
			{
				return root1;
			}

			BinaryTree<int> newTree = new BinaryTree<int>();
			Queue<Node<int>> queue = new Queue<Node<int>>();

			newTree.Root = new Node<int>(root1.Value + root2.Value); // Only happens if both root1 and root2 not null
			Node<int> newTreeCurrentNode = newTree.Root;
			queue.Enqueue(root1);
			queue.Enqueue(root2);

			while (queue.Count > 1) // Should be greater'n *one* since we're dequeuing two nodes at each iteration?
			{
				Node<int> t1Node = queue.Dequeue();
				Node<int> t2Node = queue.Dequeue();

				if (t1Node.LeftChild != null && t2Node.LeftChild != null)
				{
					newTreeCurrentNode.LeftChild = new Node<int>(t1Node.LeftChild.Value + t2Node.LeftChild.Value);
					queue.Enqueue(t1Node.LeftChild);
					queue.Enqueue(t2Node.LeftChild);
				}
				else if (t1Node.LeftChild == null && t2Node.LeftChild != null)
				{
					newTreeCurrentNode.LeftChild = new Node<int>(t2Node.LeftChild.Value);
					queue.Enqueue(t2Node.LeftChild);
				}
				else if (t1Node.LeftChild != null && t2Node.LeftChild == null)
				{
					newTreeCurrentNode.LeftChild = new Node<int>(t1Node.LeftChild.Value);
					queue.Enqueue(t1Node.LeftChild);
				}

				if (t1Node.RightChild != null && t2Node.RightChild != null)
				{
					newTreeCurrentNode.RightChild = new Node<int>(t1Node.RightChild.Value + t2Node.RightChild.Value);
					queue.Enqueue(t1Node.RightChild);
					queue.Enqueue(t2Node.RightChild);
				}
				else if (t1Node.RightChild == null && t2Node.RightChild != null)
				{
					newTreeCurrentNode.RightChild = new Node<int>(t2Node.RightChild.Value);
					queue.Enqueue(t2Node.RightChild);
				}
				else if (t1Node.RightChild != null && t2Node.RightChild == null)
				{
					newTreeCurrentNode.RightChild = new Node<int>(t1Node.RightChild.Value);
					queue.Enqueue(t1Node.RightChild);
				}

				// Move newTreeCurrentNode to next node down
				if (t1Node.LeftChild != null || t2Node.LeftChild != null)
				{
					newTreeCurrentNode = newTreeCurrentNode.LeftChild;
				}
				else if (t1Node.RightChild != null || t2Node.RightChild != null)
				{
					newTreeCurrentNode = newTreeCurrentNode.RightChild;
				}
			}

			return newTree.Root;
		}

		public static List<int> list = new List<int>();

		public static List<int> BreadthFirstStatic(Node<int> root)
		{
			Queue<Node<int>> queue = new Queue<Node<int>>();

			queue.Enqueue(root);

			while (queue.Count > 0)
			{
				Node<int> front = queue.Dequeue();

				list.Add(front.Value);

				if (front.LeftChild != null)
				{
					queue.Enqueue(front.LeftChild);
				}

				if (front.RightChild != null)
				{
					queue.Enqueue(front.RightChild);
				}
			}

			return list;
		}
	}
}
