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
			for (int i = 0; i < 6; i++)
			{
				llist.Append(i + 1);
			}

			// Print contents of list before removing value
			int[] listBefore = llist.Print();
			Console.WriteLine("List before: [{0}]", string.Join(", ", listBefore));

			// Demo RemoveDuplicateValues() method
			int? removedValue = RemoveDuplicateValues(llist, 4);
			int? valueNotFound = RemoveDuplicateValues(llist, 225);

			// Print contents of list after removing value
			int[] listAfter = llist.Print();
			Console.WriteLine("List after: [{0}]", string.Join(", ", listAfter));

			// Print removed values
			Console.WriteLine(removedValue);
			if (valueNotFound == null)
			{
				Console.WriteLine("NULL");
			}
		}

		public static int? RemoveDuplicateValues(LList list, int value)
		{
			list.Current = list.Head;

			int removedValue;

			Node previous = null;

			while (list.Current.Next != null)
			{
				if (list.Current.Value == value)
				{
					previous.Next = list.Current.Next;
					list.Current.Next = null; // Ensures node to remove gets collected by garbage collecter
					return removedValue = list.Current.Value;
				}
				previous = list.Current;
				list.Current = list.Current.Next;
			}

			return null;
		}
	}
}
