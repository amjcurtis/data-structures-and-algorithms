using System;
using System.Diagnostics;

namespace Fibonacci
{
	class Program
	{
		static void Main(string[] args)
		{
			// Fib number to calculate
			int n = 10;

			// Initialize stopwatch instances for clocking execution time
			Stopwatch watch = new Stopwatch();

			// Demo Fibonacci recursive
			Console.WriteLine("FIBONACCI RECURSIVE");
			watch.Start();
			int fibRecurs = FibonacciRecursive(n);
			watch.Stop();
			Console.WriteLine($"The {n}th Fibonacci number is: {fibRecurs}"); // Nth number in Fib sequence
			Console.WriteLine($"Number of operations req'd: {OperationCount}"); // Number of recursive calls req'd to calc nth Fib number
			Console.WriteLine($"Elapsed time: {watch.Elapsed} seconds\n");
			// Produce whole Fibonacci sequence up to n instead of just the nth Fibonacci number
			OperationCount = 0;
			for (int i = 0; i <= 10; i++)
			{
				//OperationCount = 0; // Reset counter before calculating next Fibonacci number
				int fib = FibonacciRecursive(i);
				Console.WriteLine($"Fib number when i is {i} is {fib}. It took {OperationCount} calls to get here.");
			}

			// Demo Fibonacci memoized
			Console.WriteLine("\nFIBONACCI MEMOIZED");
			watch.Restart();
			Tuple<int, int[]> fibMemoized = FibonacciMemoized(n);
			watch.Stop();
			foreach (int i in fibMemoized.Item2)
			{
				Console.Write("{0} ", i);
			}
			Console.WriteLine($"\nThe {n}th Fibonacci number is: {fibMemoized.Item2[fibMemoized.Item2.Length - 1]}");
			Console.WriteLine($"Number of operations req'd: {fibMemoized.Item1}");
			Console.WriteLine($"Elapsed time: {watch.Elapsed} seconds\n");

			// Demo Fibonacci greedy
			Console.WriteLine("FIBONACCI GREEDY");
			watch.Restart();
			Tuple<int, int> fibGreedy = FibonacciGreedy(n);
			watch.Stop();
			Console.WriteLine($"The {n}th Fibonacci number is: {fibGreedy.Item1}");
			Console.WriteLine($"Number of operations req'd: {fibGreedy.Item2}");
			Console.WriteLine($"Elapsed time: {watch.Elapsed} seconds\n");
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
			//Console.Write($"{n} "); // Print value of n at each recursive call
			if (n < 2) return n; // Base case
			return FibonacciRecursive(n - 2) + FibonacciRecursive(n - 1);
		}

		/// <summary>
		/// Calculates Fibonacci sequence up to nth number inclusive in O(n) space; more efficient than recursive method thanks to "memoizing" (caching) previously calc'd Fib number
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
			return new Tuple<int, int[]>(fibCount, sequence);
		}

		/// <summary>
		/// Calculates nth Fibonacci number in O(1) space; uses "memoizing" (caching) previously calc'd Fib numbers
		/// </summary>
		/// <param name="n"></param>
		/// <returns>nth number in Fibonacci sequence</returns>
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
			return new Tuple<int, int>(current, fibCount);
		}
	}
}
