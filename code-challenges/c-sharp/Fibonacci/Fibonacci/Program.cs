using System;

namespace Fibonacci
{
	class Program
	{
		private static int fibCount = 0;

		static void Main(string[] args)
		{
			// 0 1 1 2 3 5 8 13 21 34 55
			int fib = FibonacciRecursive(3);
			Console.WriteLine();
			Console.WriteLine(fib);
			Console.WriteLine(fibCount);
		}
		
		public static int FibonacciRecursive(int n)
		{
			fibCount++;
			Console.WriteLine(n);
			if (n < 2) return n; // Base case
			return FibonacciRecursive(n - 2) + FibonacciRecursive(n - 1);
		}
	}
}
