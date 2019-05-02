using System;
using Hashtable = HashTable.Hashtable;
using HashTable;
using System.Collections.Generic;

namespace LeftJoinHashTables
{
	public class Program
	{
		static void Main(string[] args)
		{
			// Instantiate first hash table
			Hashtable ht1 = new Hashtable(1024);

			// Add key:value pairs to first HT
			ht1.Add("fond", "enamored");
			ht1.Add("wrath", "anger");
			ht1.Add("diligent", "employed");
			ht1.Add("outfit", "garb");
			ht1.Add("guide", "usher");

			// Instantiate second hash table
			Hashtable ht2 = new Hashtable(1024);

			// Add other key:value pairs to second HT
			ht2.Add("fond", "averse");
			ht2.Add("wrath", "delight");
			ht2.Add("diligent", "idle");
			ht2.Add("guide", "follow");
			ht2.Add("flow", "jam");

			// Capture list of arrays returned by LeftJoin method
			List<string[]> leftJoin = LeftJoin(ht1, ht2);

			// Print contents of list of arrays to the console
			foreach (var array in leftJoin)
			{
				for (int i = 0; i < array.Length; i++)
				{
					Console.Write($"{array[i]} ");
				}
				Console.WriteLine("");
			}
			Console.WriteLine("");
		}

		/// <summary>
		/// Performs a simplified SQL-style LEFT JOIN operation on two hash tables
		/// </summary>
		/// <param name="ht1">left hash table</param>
		/// <param name="ht2">right hash table</param>
		/// <returns>list of arrays</returns>
		public static List<string[]> LeftJoin(Hashtable ht1, Hashtable ht2)
		{
			// Initialize list of arrays
			List<string[]> listOfArrays = new List<string[]>();

			// Traverse left hash table
			for (int i = 0; i < ht1.Map.Length; i++)
			{
				if (ht1.Map[i] != null)
				{
					foreach (var node in ht1.Map[i])
					{
						Node ht1Node = ht1.Get(node.Key);

						// Initialize new array to hold current table row's contents
						string[] array = new string[3]; 

						// Populate array's first two indices with key and value from left table
						array[0] = ht1Node.Key;
						array[1] = ht1Node.Value;

						if (ht2.Contains(ht1Node.Key))
						{
							Node ht2Node = ht2.Get(ht1Node.Key);
							array[2] = ht2Node.Value;
						}
						else
						{
							array[2] = "NULL";
						}

						listOfArrays.Add(array);
					}
				}
			}
			return listOfArrays;
		}
	}
}
