using System;
using StacksAndQueues.Classes;

namespace MultiBracketValidation
{
	public class Program
	{
		public static void Main(string[] args)
		{
			string bracketString = "()[[]]";
			string bracketString2 = "{(})";

			Console.WriteLine(MultiBracketValidation(bracketString));
			Console.WriteLine(MultiBracketValidation(bracketString2));
		}

		/// <summary>
		/// Validates string argument and returns true if any brackets like () {} [] contained in string are opened and closed in proper order
		/// </summary>
		/// <param name="input">string of letters to validate</param>
		public static bool MultiBracketValidation(string input)
		{
			char[] charArray = input.ToCharArray();

			Stack<char> bracketStack = new Stack<char>();

			for (int i = 0; i < charArray.Length; i++)
			{
				if (charArray[i] == '(' || charArray[i] == '{' || charArray[i] == '[')
				{
					bracketStack.Push(charArray[i]);
					Console.WriteLine($"Top of stack:  {bracketStack.Top.Value}");
				}
				else if (charArray[i] == ')' || charArray[i] == '}' || charArray[i] == ']')
				{
					if (bracketStack.Top == null)
					{
						return false;
					}
					else
					{
						if (charArray[i] == ')' && bracketStack.Top.Value == '(')
						{
							Console.WriteLine($"Pop:  {bracketStack.Top.Value}");
							bracketStack.Pop();
						}
						else if (charArray[i] == '}' && bracketStack.Top.Value == '{')
						{
							Console.WriteLine($"Pop:  {bracketStack.Top.Value}");
							bracketStack.Pop();
						}
						else if (charArray[i] == ']' && bracketStack.Top.Value == '[')
						{
							Console.WriteLine($"Pop:  {bracketStack.Top.Value}");
							bracketStack.Pop();
						}
						else
						{
							return false;
						}
					}
				}
			}

			if (bracketStack.Top != null)
			{
				return false;
			}
			else
			{
				return true;
			}
		}
	}
}
