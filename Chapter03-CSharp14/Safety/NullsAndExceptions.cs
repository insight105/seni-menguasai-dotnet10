using System;

namespace Chapter03.Safety
{
    public static class NullsAndExceptions
    {
        public static void Run()
        {
            Console.WriteLine("--- Safety (Nulls & Exceptions) ---");

            // Nullable Types
            string? nickname = null;
            string displayName = nickname ?? "Guest"; // Null-coalescing
            Console.WriteLine($"Hello, {displayName}");

            // Null-conditional
            Person? p = null;
            Console.WriteLine($"Age: {p?.Age}"); // Prints nothing (null)

            // Try-Catch
            try
            {
                ValidateAge(-5);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Caught error: {ex.Message}");
            }
        }

        static void ValidateAge(int age)
        {
            if (age < 0) throw new ArgumentException("Age cannot be negative!");
        }

        class Person { public int Age { get; set; } }
    }
}
