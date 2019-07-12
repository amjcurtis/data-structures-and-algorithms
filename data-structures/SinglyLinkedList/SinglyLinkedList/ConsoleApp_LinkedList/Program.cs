using System;
using System.Collections.Generic;
using ConsoleApp_LinkedList.Classes;

namespace ConsoleApp_LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {

            //Node newNode = new Node();
            //newNode.Value = 10;

            try
            {
                LList sll = new LList();
                for (int i = 0; i < 6; i++)
                {
					// Demo Append() method
					sll.Append(i + 1);
                }
				
				//	[1] -> [2] -> [3] -> [4] -> [5] -> [6] -> null 

				// Demo Insert() method
				//myLinkedList.Insert(244);

				// Demo Print() method
				int[] nodeVals = sll.Print();
                Console.WriteLine("Nodes values: [{0}]", string.Join(", ", nodeVals));

				// Demo GetKthNodeFromEnd() method
				int k = 2;
				Node kthValFromEnd = sll.GetKthNodeFromEnd(k);
				Console.WriteLine($"k = {k}");
                Console.WriteLine($"kth node from end: {kthValFromEnd.Value}\n");

				// Demo IsCircular method
				Node end = sll.GetKthNodeFromEnd(1); // Get last node in list
				end.Next = sll.Head; // Make list circular
				Console.WriteLine(sll.IsCircular());
				end.Next = null; // Reset end.Next so list isn't circular anymore

				// Reverse array of values before printing it to console (because nodes were inserted at *front* of list)
				//Console.WriteLine("REVERSE printedVals TO SHOW NODES IN ORDER IN WHICH THEY WERE ADDED");
				//Array.Reverse(printedVals);

				// Demo reversing of linked list
				Console.WriteLine("REVERSE LINKED LIST");
				sll.Reverse();
				nodeVals = sll.Print();
				Console.WriteLine("printedVals: [{0}]", string.Join(", ", nodeVals));
			}
			catch (Exception e)
            {
                Console.WriteLine(e);
            }

            Console.ReadLine();
        }
	}
}
