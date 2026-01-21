using System;

namespace Chapter03.Methods
{
    public static class Functions
    {
        public static void Run()
        {
            Console.WriteLine("--- Methods ---");

            Greet("Developer");
            
            int product = Multiply(5, 4);
            Console.WriteLine($"5 * 4 = {product}");

            PrintInfo("Alice", 25);
            PrintInfo("Bob"); // Uses default age

            int sum = Sum(1, 2, 3, 4, 5);
            Console.WriteLine($"Sum of 1..5: {sum}");
        }

        static void Greet(string name) => Console.WriteLine($"Hello, {name}!");

        // Expression-bodied
        static int Multiply(int a, int b) => a * b;

        // Optional parameters
        static void PrintInfo(string name, int age = 18)
        {
            Console.WriteLine($"{name} is {age} years old");
        }

        // Params
        static int Sum(params int[] numbers)
        {
            int total = 0;
            foreach (int num in numbers) total += num;
            return total;
        }
    }
}
