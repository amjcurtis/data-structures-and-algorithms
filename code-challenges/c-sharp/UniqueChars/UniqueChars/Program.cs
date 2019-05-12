using System;

namespace UniqueChars
{
	public class Program
	{
		static void Main(string[] args)
		{
			string trueStr = "abcdefg";
			string falseStr = "abcaefge";
			string falseStr2 = "abcdefge";
			string falseStr3 = "abcdefa";
			string falseStr4 = "abcdeff";
			string falseStr5 = "aabcdef";
			
			Console.WriteLine(AreCharactersUnique(trueStr));
			Console.WriteLine(AreCharactersUnique(falseStr));
			Console.WriteLine(AreCharactersUnique(falseStr2));
			Console.WriteLine(AreCharactersUnique(falseStr3));
			Console.WriteLine(AreCharactersUnique(falseStr4));
			Console.WriteLine(AreCharactersUnique(falseStr5));
		}

		public static bool AreCharactersUnique(string input)
		{
			// Split input string into char array
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
