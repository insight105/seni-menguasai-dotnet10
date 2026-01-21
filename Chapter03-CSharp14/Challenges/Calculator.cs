using System;

namespace Chapter03.Challenges
{
    public static class Calculator
    {
        public static void Run()
        {
            Console.WriteLine("--- Challenge: Calculator ---");
            while (true)
            {
                Console.WriteLine("\nEnter calculation (number op number) or 'exit':");
                // Simple parser for demo: "5 + 3"
                string input = Console.ReadLine();
                if (input == "exit") break;

                try
                {
                    var parts = input.Split(' ');
                    if (parts.Length != 3) { Console.WriteLine("Invalid format. Use: 5 + 3"); continue; }

                    double a = double.Parse(parts[0]);
                    double b = double.Parse(parts[2]);
                    string op = parts[1];

                    double result = op switch
                    {
                        "+" => a + b,
                        "-" => a - b,
                        "*" => a * b,
                        "/" => b != 0 ? a / b : throw new DivideByZeroException(),
                        _ => throw new InvalidOperationException("Unknown operator")
                    };

                    Console.WriteLine($"Result: {result}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }
    }
}
