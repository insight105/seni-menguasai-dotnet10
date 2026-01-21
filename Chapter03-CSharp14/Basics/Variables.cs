using System;

namespace Chapter03.Basics
{
    public static class Variables
    {
        public static void Run()
        {
            Console.WriteLine("--- Variables and Data Types ---");

            // Numeric types
            int myInt = 42;
            double myDouble = 3.14159;
            decimal myDecimal = 99.99m; // Money

            Console.WriteLine($"Int: {myInt}, Double: {myDouble}, Decimal: {myDecimal}");

            // C# 14 / Modern Inference
            var name = "C# 14"; // String
            var isValid = true;   // Boolean

            Console.WriteLine($"Inferred Name: {name}, IsValid: {isValid}");

            // Enums
            OrderStatus status = OrderStatus.Processing;
            Console.WriteLine($"Order Status: {status}");
        }
    }

    public enum OrderStatus
    {
        Pending,
        Processing,
        Shipped,
        Delivered,
        Cancelled
    }
}
