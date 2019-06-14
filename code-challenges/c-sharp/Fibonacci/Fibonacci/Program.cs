using System;

namespace Fibonacci
{
	class Program
	{
		private static int fibCount = 0;

		static void Main(string[] args)
		{
			// 0 1 1 2 3 5 8 13 21 34 55

			// Demo Fibonacci recursive
			Console.WriteLine("FIBONACCI RECURSIVE");
			int fib = FibonacciRecursive(10);
			Console.WriteLine();
			Console.WriteLine(fib);      // Nth number in Fib sequence
			Console.WriteLine(fibCount); // Number of recursive calls req'd to calc nth Fib number
			Console.WriteLine();

			// Demo Fibonacci memoized
			Console.WriteLine("FIBONACCI MEMOIZED");
			int[] fibSequence = FibonacciMemoized(10);
			foreach (int i in fibSequence)
			{
				Console.Write("{0} ", i);
			}
			Console.WriteLine();
		}

		public static int FibonacciRecursive(int n)
		{
			fibCount++;
			Console.WriteLine(n);
			if (n < 2) return n; // Base case
			return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
		}

		public static int[] FibonacciMemoized(int n)
		{
			int[] sequence = new int[n + 1];
			sequence[0] = 0;
			sequence[1] = 1;

			int fibCurrent = 0;
			for (int i = 2; i <= n; i++)
			{
				fibCurrent = sequence[i - 1] + sequence[i - 2];
				sequence[i] = fibCurrent;
			}
			return sequence;
		}
	}
}
