using System;
using System.Collections.Generic;

namespace HashTable
{
	public class Hashtable
	{
		public LinkedList<Node>[] Map { get; set; }
		public List<string> Values { get; set; }

		// Hashtable constructor
		public Hashtable(int size)
		{
			Map = new LinkedList<Node>[size];
			Values = new List<string>();
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
		/// Adds new hashed key:value pair to hashtable in O(1) time
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
			Values.Add(value);
		}

		/// <summary>
		/// Adds new key:value pair to hashtable, hashing value as the key
		/// </summary>
		/// <param name="value">value to add</param>
		public void Add(string value)
		{
			// Use value as key to hash
			string key = value;
			int hashKey = Hash(key);

			if (Map[hashKey] == null)
			{
				Map[hashKey] = new LinkedList<Node>();
			}

			Map[hashKey].AddFirst(new Node(key, value));
			Values.Add(value);
		}

		/// <summary>
		/// Checks whether hashtable contains specified key in O(1) time
		/// </summary>
		/// <param name="key">key to search hashtable for</param>
		/// <returns>boolean</returns>
		public bool ContainsKey(string key)
		{
			/*
			* Runtime complexity is O(1) in best and avg case
			* or O(k) time where k is number of keys hashed
			* to same index (in worst case, k > 1)
			*/

			int hashKey = Hash(key);

			if (Map[hashKey] != null)
			{
				// Could omit foreach and always get O(1) runtime if hash were perfect
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
		/// Checks whether hashtable contains value in O(n) time
		/// </summary>
		/// <param name="value">value to search hashtable for</param>
		/// <returns>boolean</returns>
		public bool ContainsValue(string value)
		{
			/*
			 * Runtime complexity is in worst case O(nk) where n is number
			 * of buckets and k is number of key:value pairs in hashtable
			 */

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
		/// Retrieves first key:value pair where key matches specified key
		/// </summary>
		/// <param name="key">key to search for</param>
		/// <returns>node if key:value pair found, else null</returns>
		public Node Get(string key)
		{
			int hashKey = Hash(key);

			if (Map[hashKey] != null)
			{
				foreach (Node node in Map[hashKey])
				{
					// Could omit foreach and always get O(1) runtime if hash were perfect
					if (node.Key == key)
					{
						return node;
					}
				}
			}
			return null;
		}

		/// <summary>
		/// Retrieves first key:value pair matching specified key and value, allowing exact search for value in case same key is hashed multiple times with different values
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
		/// Writes key:value pairs from hashtable to console
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
