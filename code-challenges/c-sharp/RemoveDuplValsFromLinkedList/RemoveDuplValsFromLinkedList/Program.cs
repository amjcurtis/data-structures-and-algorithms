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
			llist.Append(9);
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
			int? removedValues = RemoveDuplicateValues(llist, 4);

			// Print contents of list after removing value
			int[] listAfter = llist.Print();
			Console.WriteLine("List after: [{0}]", string.Join(", ", listAfter));

			// Print number of removed values
			if (removedValues == null)
			{
				Console.WriteLine("NULL");
			}
			else
			{
				Console.WriteLine($"Number of nodes removed: {removedValues}");
			}
		}

		/// <summary>
		/// Takes in linked list and value of node(s) to be removed from list
		/// </summary>
		/// <param name="list">Linked list</param>
		/// <param name="value">Value of node(s) to remove</param>
		/// <returns>Count of nodes removed</returns>
		public static int RemoveDuplicateValues(LList list, int value)
		{
			list.Current = list.Head;

			int count = 0; // Tally to increment each time a node is removed

			//Node previous = list.Head;
			Node previous = null;

			// Handle case where Head's value is value of node(s) to remove
			if (list.Current != null && list.Head.Value == value) // Put outside while loop to avoid running this check at every iteration of loop
			{
				list.Head = list.Head.Next;
				previous = list.Current;
				list.Current = list.Current.Next;
				count++;
			}

			while (list.Current != null)
			{
				if (list.Current.Value == value)
				{
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
