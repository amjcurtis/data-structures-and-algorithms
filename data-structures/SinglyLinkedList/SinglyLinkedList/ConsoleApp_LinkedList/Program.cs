using System;
using ConsoleApp_LinkedList.Classes;

namespace ConsoleApp_LinkedList
{
	class Program
	{
		static void Main(string[] args)
		{
			LList list = new LList();
			for (int i = 0; i < 7; i++)
			{
				// Demo Append() method
				list.Append(i + 1);
			}

			//	[1] -> [2] -> [3] -> [4] -> [5] -> [6] -> [7] -> null 

			// Demo Print() method
			int[] nodeVals = list.Print();
			Console.WriteLine("Nodes values: [{0}]", string.Join(", ", nodeVals));

			// Demo GetKthNodeFromEnd() method
			int k = 2;
			Node kthValFromEnd = list.GetKthNodeFromEnd(k);
			Console.WriteLine($"k = {k}");
			Console.WriteLine($"kth node from end: {kthValFromEnd.Value}\n");

			// Demo IsCircular method
			Node end = list.GetKthNodeFromEnd(1); // Get last node in list
			end.Next = list.Head.Next.Next.Next; // Make list circular
			Console.WriteLine($"Is list circular: {list.IsCircular()}");
			Node collisionPoint = list.FindLoopStart();
			Console.WriteLine($"Value of node at start of loop in circular list: {collisionPoint.Value}");
			end.Next = null; // Reset end.Next so list isn't circular anymore
			Console.WriteLine($"Is list circular: {list.IsCircular()}");
			Node collisionPoint2 = list.FindLoopStart();
			if (collisionPoint2 == null)
			{
				Console.WriteLine("NULL");
			}
			else
			{
				Console.WriteLine($"Value of node at start of loop in circular list: {collisionPoint2.Value}");
			}

			// Reverse array of values before printing it to console (because nodes were inserted at *front* of list)
			//Console.WriteLine("REVERSE printedVals TO SHOW NODES IN ORDER IN WHICH THEY WERE ADDED");
			//Array.Reverse(printedVals);

			// Demo reversing of linked list
			Console.WriteLine("REVERSE LINKED LIST");
			list.Reverse();
			nodeVals = list.Print();
			Console.WriteLine("printedVals: [{0}]", string.Join(", ", nodeVals));
		}
	}
}
