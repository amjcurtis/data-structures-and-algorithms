using System;
using System.Collections.Generic;

namespace HashTable
{
	public class Hashtable
	{
		public LinkedList<Node>[] Map { get; set; }

		// Hashtable constructor
		public Hashtable(int size)
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
				hashValue += letters[i]; // Char converts to int implicitly
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
		/// Traverses hashtable and returns whether or not it contains specified value
		/// </summary>
		/// <param name="value">value to search hash table for</param>
		/// <returns>boolean</returns>
		public bool ContainsValue(string value)
		{
			for (int i = 0; i < Map.Length; i++)
			{
				if (Map[i] != null)
				{
					foreach (Node node in Map[i])
					{
						if (node.Value == value)
						{
							return true;
						}
					}
				}
			}
			return false;
		}

		/// <summary>
		/// Returns whether or not hashtable contains specified key
		/// </summary>
		/// <param name="key">key to search hash table for</param>
		/// <returns>boolean</returns>
		public bool ContainsKey(string key)
		{
			int hashKey = Hash(key);

			if (Map[hashKey] != null)
			{
				// Could omit foreach if hash were perfect
				foreach (Node node in Map[hashKey])
				{
					if (node.Key == key)
					{
						return true;
					}
				}
			}
			return false;
		}

		/// <summary>
		/// Retrieves first key:value pair matching search params
		/// </summary>
		/// <param name="key">key to search for</param>
		/// <param name="value">value to search for</param>
		/// <returns>node if key:value pair found, else null</returns>
		public Node Get(string key, string value)
		{
			int hashKey = Hash(key);

			if (Map[hashKey] != null)
			{
				foreach (Node node in Map[hashKey])
				{
					if (node.Value == value)
					{
						return node;
					}
				}
			}
			return null;
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
					foreach (Node node in Map[i])
					{
						Console.Write($"{node.Key}:{node.Value} --> ");
					}
					Console.Write("null");
					Console.WriteLine();
				}
			}
		}
	}
}
