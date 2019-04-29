using System;
using System.Collections.Generic;
using System.Text;

namespace HashTable
{
	public class HashTable
	{

		public LinkedList<Node>[] Map { get; set; }

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

		/// <summary>
		/// Traverses hash table and retrieves first key:value pair with specified key
		/// </summary>
		/// <param name="key">key to search for</param>
		/// <returns>node if key found, else null</returns>
		public Node Get(string key)
		{
			for (int i = 0; i < Map.Length; i++)
			{
				if (Map[i] != null)
				{
					foreach (var item in Map[i])
					{
						if (item.Key == key)
						{
							return item;
						}
					}
				}
			}
			return null;
		}

		/// <summary>
		/// Traverses hash table and returns whether or not table contains specified key
		/// </summary>
		/// <param name="key">key to search hash table for</param>
		/// <returns>boolean</returns>
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
