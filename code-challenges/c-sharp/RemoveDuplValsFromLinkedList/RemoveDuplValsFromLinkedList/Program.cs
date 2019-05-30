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
		/// Removes all nodes with a specified value from a linked list
		/// </summary>
		/// <param name="list">Linked list to remove the nodes from</param>
		/// <param name="value">Node value to remove from linked list</param>
		/// <returns>Number of nodes with specified value that were removed from the linked list</returns>
		public static int? RemoveDuplicateValues(LList list, int value)
		{
			list.Current = list.Head;

			int count = 0; // Tally to increment each time a node is removed

			//Node previous = list.Head;
			Node previous = null;

			while (list.Current != null)
			{
				if (list.Current.Value == value)
				{
					previous.Next = list.Current.Next;
					
					//TODO Ensure node to remove gets collected by garbage collecter


					count++;
				}
				previous = list.Current; // Move previous ahead one node at each iteration
				list.Current = list.Current.Next; // Move Current ahead one node at each iteration
			}

			if (count > 1)
			{
				return count;
			}
			return null;
		}
	}
}
