using ConsoleApp_LinkedList.Classes;
using System;

namespace RemoveDuplValsFromLinkedList
{
	public class Program
	{
		static void Main(string[] args)
		{
			LList llist = new LList();

			// Add nodes to list
			llist.Append(4);
			llist.Append(4);
			for (int i = 0; i < 6; i++)
			{
				llist.Append(i + 1);
			}
			llist.Append(4);
			llist.Append(7);
			llist.Append(4);

			// Print contents of list before removing value
			int[] listBefore = llist.Print();
			Console.WriteLine("List before: [{0}]", string.Join(", ", listBefore));

			// Demo RemoveDuplicateValues() method
			int removedValues = RemoveValue(llist, 4);

			// Print contents of list after removing value
			int[] listAfter = llist.Print();
			Console.WriteLine("List after: [{0}]", string.Join(", ", listAfter));

			// Print number of removed values
			Console.WriteLine($"Number of nodes removed: {removedValues}");
		}

		/// <summary>
		/// Takes in linked list and value of node(s) to be removed from list
		/// </summary>
		/// <param name="list">Linked list</param>
		/// <param name="value">Value of node(s) to remove</param>
		/// <returns>Count of nodes removed</returns>
		public static int RemoveValue(LList list, int value)
		{
			list.Current = list.Head;

			int count = 0; // Tally to increment each time a node is removed

			Node previous = list.Head;

			while (list.Current != null)
			{
				if (list.Current.Value == value)
				{
					// Handle case where Head's value is value to be removed
					// Included inside while loop in case first n nodes in list contain value to remove
					if (list.Current == list.Head)
					{
						list.Head = list.Head.Next;
					}

					previous.Next = list.Current.Next;
					count++;
				}
				previous = list.Current; // Move previous ahead one node at each iteration
				list.Current = list.Current.Next; // Move Current ahead one node at each iteration
			}

			return count;
		}
	}
}
