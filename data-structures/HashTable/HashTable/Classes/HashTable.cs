using System;
using System.Collections.Generic;
using System.Text;

namespace HashTable
{
	public class HashTable
	{

		private LinkedList<Node>[] Map { get; set; }

		// Hash table constructor
		public HashTable(int size)
		{
			Map = new LinkedList<Node>[size];
		}

		/// <summary>
		/// Hashes key to integer
		/// </summary>
		/// <param name="key">key to hash</param>
		/// <returns>integer hash</returns>
		public int Hash(string key)
		{
			int hashValue = 0;

			char[] letters = key.ToCharArray();

			for (int i = 0; i < letters.Length; i++)
			{
				hashValue += letters[i];
			}

			hashValue = (hashValue * 599) % Map.Length;

			return hashValue;
		}

		/// <summary>
		/// Adds new hashed key:value pair to hash table
		/// </summary>
		/// <param name="key">key for key:value pair to add</param>
		/// <param name="value">value for key:value pair to add</param>
		public void Add(string key, string value)
		{
			int hashKey = Hash(key);

			if (Map[hashKey] == null) 
			{
				Map[hashKey] = new LinkedList<Node>();
			}

			Map[hashKey].AddFirst(new Node(key, value));
		}


		//TODO Get() method
		//public string Get(string key)
		//{

		//}


		//TODO Contains() method
		public bool Contains(string key)
		{
			for (int i = 0; i < Map.Length; i++)
			{
				if (Map[i] != null)
				{
					foreach (var item in Map[i])
					{
						if (item.Key == key)
						{
							return true;
						}
					}
				}
			}
			return false;
		}


		/// <summary>
		/// Writes key:value pairs from hash table to console
		/// </summary>
		public void Print()
		{
			for (int i = 0; i < Map.Length; i++)
			{
				if (Map[i] != null)
				{
					Console.Write($"Bucket: {i}: ");
					foreach (var item in Map[i])
					{
						Console.Write($"{item.Key}:{item.Value} --> ");
					}
					Console.Write("null");
					Console.WriteLine();
				}
			}
		}
	}
}
