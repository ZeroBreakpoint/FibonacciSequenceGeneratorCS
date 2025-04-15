using System;

namespace FibonacciApp
{
    class Program
    {
        // This function prints the first 'n' Fibonacci numbers starting from (0, 1)
        static void PrintFibonacci(int n)
        {
            int first = 0, second = 1;

            for (int i = 0; i < n; i++)
            {
                Console.Write(first + " ");

                int next = first + second;
                first = second;
                second = next;
            }

            Console.WriteLine(); // For line break
        }

        static void Main()
        {
            Console.WriteLine("=== Exercise 2: Fibonacci Sequence ===");

            Console.Write("Enter the number of Fibonacci numbers to generate: ");

            int n;
            while (true)
            {
                string? input = Console.ReadLine();

                // Try to parse input to an int safely
                if (int.TryParse(input, out n) && n > 0)
                    break;

                Console.WriteLine("Invalid input. Please enter a positive whole number.");
            }

            PrintFibonacci(n);
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}