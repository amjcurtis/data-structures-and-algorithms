using System;

namespace Fibonacci
{
	class Program
	{
		static void Main(string[] args)
		{
			// Fib number to calculate
			int n = 10;

			// Demo Fibonacci recursive
			Console.WriteLine("FIBONACCI RECURSIVE");
			int fibRecurs = FibonacciRecursive(n);
			Console.WriteLine();
			Console.WriteLine($"The {n}th Fibonacci number is: {fibRecurs}");	// Nth number in Fib sequence
			Console.WriteLine($"Number of operations req'd: {OperationCount}"); // Number of recursive calls req'd to calc nth Fib number
			Console.WriteLine();

			// Demo Fibonacci memoized
			Console.WriteLine("FIBONACCI MEMOIZED");
			Tuple<int, int[]> fibMemoized = FibonacciMemoized(n);
			foreach (int i in fibMemoized.Item2)
			{
				Console.Write("{0} ", i);
			}
			Console.WriteLine($"\nThe {n}th Fibonacci number is: {fibMemoized.Item2[fibMemoized.Item2.Length - 1]}");
			Console.WriteLine($"Number of operations req'd: {fibMemoized.Item1}");
			Console.WriteLine();

			// Demo Fibonacci greedy
			Console.WriteLine("FIBONACCI GREEDY");
			Tuple<int, int> fibGreedy = FibonacciGreedy(n);
			Console.WriteLine($"The {n}th Fibonacci number is: {fibGreedy.Item1}");
			Console.WriteLine($"Number of operations req'd: {fibGreedy.Item2}");
			Console.WriteLine();
		}

		// Static field for counting number of operations in recursive Fibonacci method
		public static int OperationCount = 0;

		/// <summary>
		/// Calculates nth Fibonacci number recursively
		/// </summary>
		/// <param name="n">number to calculate in Fibonacci sequence</param>
		/// <returns>nth number in Fibonacci sequence</returns>
		public static int FibonacciRecursive(int n)
		{
			OperationCount++;
			Console.WriteLine(n);
			if (n < 2) return n; // Base case
			return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
		}

		/// <summary>
		/// Calculates nth Fibonacci number in O(n) space; more efficient than recursive method thanks to "memoizing" (caching) previously calc'd Fib number
		/// </summary>
		/// <param name="n">number to calculate in Fibonacci sequence</param>
		/// <returns>Fibonacci sequence up to nth number</returns>
		public static Tuple<int, int[]> FibonacciMemoized(int n)
		{
			int fibCount = 0; // Counter for tracking number of operations
			int[] sequence = new int[n + 1];
			sequence[0] = 0;
			sequence[1] = 1;

			for (int i = 2; i <= n; i++)
			{
				sequence[i] = sequence[i - 1] + sequence[i - 2];
				fibCount++;
			}
			Tuple<int, int[]> tup = new Tuple<int, int[]>(fibCount, sequence);
			return tup;
		}

		/// <summary>
		/// Calculates nth Fibonacci number in O(1) space; uses "memoizing" (caching) previously calc'd Fib numbers
		/// </summary>
		/// <param name="n"></param>
		/// <returns></returns>
		public static Tuple<int, int> FibonacciGreedy(int n)
		{
			int fibCount = 0; // Counter for tracking number of operations

			// Variables for saving current and previous two numbers in Fib sequence
			int prevPrev = 0;
			int prev = 1;
			int current = 0;

			for (int i = 2; i <= n; i++)
			{
				current = prev + prevPrev;
				prevPrev = prev;
				prev = current;

				fibCount++;
			}
			Tuple<int, int> result = new Tuple<int, int>(current, fibCount);;
			return result;
		}
	}
}
