using System;

namespace UniqueChars
{
	public class Program
	{
		static void Main(string[] args)
		{
			string trueStr = "abcdefg";		// Happy path
			string falseStr = "abcaefge";	// String with even number of chars and duplicates in random places
			string falseStr2 = "abcdefge";  // String with odd number of chars and duplicates in random places
			string falseStr3 = "abcdefa";	// First and last letters are duplicates
			string falseStr4 = "abcdeff";	// Last two letters are duplicates
			string falseStr5 = "aabcdef";   // First two letters are duplicates

			Console.WriteLine(AreCharactersUnique(trueStr));
			Console.WriteLine(AreCharactersUnique(falseStr));
			Console.WriteLine(AreCharactersUnique(falseStr2));
			Console.WriteLine(AreCharactersUnique(falseStr3));
			Console.WriteLine(AreCharactersUnique(falseStr4));
			Console.WriteLine(AreCharactersUnique(falseStr5));
		}

		/// <summary>
		/// Takes in a string and returns whether all characters in string are unique
		/// </summary>
		/// <param name="input">string</param>
		/// <returns>boolean</returns>
		public static bool AreCharactersUnique(string input)
		{
			// Split input string into char array (not technically necessary but slightly faster and more memory-efficient)
			char[] arr = input.ToCharArray();

			// i can loop arr.Length-1 times; value at last index will already have been checked against all other letters
			for (int i = 0; i < arr.Length - 1; i++)
			{
				// j must be offset from i, else i will equal j and yield false on first iteration
				for (int j = i + 1; j < arr.Length; j++)
				{
					if (arr[i] == arr[j])
					{
						return false;
					}
				}
			}

			return true;
		}
	}
}
