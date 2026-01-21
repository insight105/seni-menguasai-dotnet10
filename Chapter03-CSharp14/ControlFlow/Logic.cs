using System;

namespace Chapter03.ControlFlow
{
    public static class Logic
    {
        public static void Run()
        {
            Console.WriteLine("--- Control Flow ---");

            // Switch Expression
            int dayNumber = 3;
            string dayName = dayNumber switch
            {
                1 => "Monday",
                2 => "Tuesday",
                3 => "Wednesday",
                4 => "Thursday",
                5 => "Friday",
                6 or 7 => "Weekend",
                _ => "Invalid"
            };
            Console.WriteLine($"Day {dayNumber} is {dayName}");

            // Loops
            Console.WriteLine("ForEach with Index (Modern):");
            string[] fruits = { "Apple", "Banana", "Orange" };
            foreach (var (fruit, index) in fruits.Select((f, i) => (f, i)))
            {
                Console.WriteLine($"{index}: {fruit}");
            }
        }
    }
}
