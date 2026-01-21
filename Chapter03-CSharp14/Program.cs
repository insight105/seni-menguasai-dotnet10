using System;
using System.Threading.Tasks;

namespace Chapter03;

class Program
{
    static async Task Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("=== C# 14 Chapter 3 Examples ===");
            Console.WriteLine("1. Basics (Variables, Types)");
            Console.WriteLine("2. Control Flow (Switch, Loops)");
            Console.WriteLine("3. Methods (Params, Local functions)");
            Console.WriteLine("4. OOP (Records, Primary Constructors)");
            Console.WriteLine("5. Collections (Expressions, Spread)");
            Console.WriteLine("6. LINQ (Queries, Lambdas)");
            Console.WriteLine("7. Async (Await, WhenAll)");
            Console.WriteLine("8. Safety (Nulls, Exceptions)");
            Console.WriteLine("9. Challenge: Calculator");
            Console.WriteLine("0. Exit");
            Console.Write("\nSelect an option: ");

            string choice = Console.ReadLine();

            if (choice == "0") break;

            Console.WriteLine();
            try
            {
                switch (choice)
                {
                    case "1": Basics.Variables.Run(); break;
                    case "2": ControlFlow.Logic.Run(); break;
                    case "3": Methods.Functions.Run(); break;
                    case "4": OOP.Demo.Run(); break;
                    case "5": Collections.Demo.Run(); break;
                    case "6": LINQ.Queries.Run(); break;
                    case "7": await Async.AsyncDemo.Run(); break;
                    case "8": Safety.NullsAndExceptions.Run(); break;
                    case "9": Challenges.Calculator.Run(); break;
                    default: Console.WriteLine("Invalid option. Press Enter..."); break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nError running example: {ex.Message}");
            }

            Console.WriteLine("\nPress Enter to return to menu...");
            Console.ReadLine();
        }
    }
}
