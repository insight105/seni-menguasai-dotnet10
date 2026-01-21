using System;
using System.Linq;
using System.Collections.Generic;

namespace Chapter03.LINQ
{
    public static class Queries
    {
        public static void Run()
        {
            Console.WriteLine("--- LINQ ---");

            List<int> numbers = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];

            // Where
            var even = numbers.Where(n => n % 2 == 0);
            Console.WriteLine($"Even: {string.Join(",", even)}");

            // Select
            var squared = numbers.Select(n => n * n);
            Console.WriteLine($"Squared: {string.Join(",", squared)}");

            // OrderByDescending
            var desc = numbers.OrderByDescending(n => n);
            Console.WriteLine($"Descending: {string.Join(",", desc)}");

            // Aggregation
            Console.WriteLine($"Sum: {numbers.Sum()}");
            Console.WriteLine($"Average: {numbers.Average()}");

            // Objects
            var products = new List<Product>
            {
                new("Laptop", 1200m),
                new("Mouse", 25m)
            };

            var expensive = products
                .Where(p => p.Price > 100)
                .Select(p => p.Name);

            Console.WriteLine($"Expensive: {string.Join(", ", expensive)}");
        }
    }

    record Product(string Name, decimal Price);
}
