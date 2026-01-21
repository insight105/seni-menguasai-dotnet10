using System;
using System.Collections.Generic;

namespace Chapter03.Collections
{
    public static class Demo
    {
        public static void Run()
        {
            Console.WriteLine("--- Collections ---");

            // List
            List<int> numbers = new List<int> { 1, 2, 3 };
            numbers.Add(4);
            Console.WriteLine($"List count: {numbers.Count}");

            // Collection Expressions (C# 12+)
            List<int> modernList = [1, 2, 3, 4, 5];
            Console.WriteLine($"Modern List: {string.Join(", ", modernList)}");

            // Spread Operator
            int[] arr1 = [1, 2];
            int[] arr2 = [3, 4];
            int[] combined = [..arr1, ..arr2, 5];
            Console.WriteLine($"Combined: {string.Join(", ", combined)}");

            // Dictionary
            Dictionary<string, int> ages = new()
            {
                ["Alice"] = 30,
                ["Bob"] = 25
            };
            Console.WriteLine($"Alice is {ages["Alice"]}");
        }
    }
}
