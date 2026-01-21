// Chapter 03: C# 14 - Modern Features Demo
// This demonstrates key C# 14 features covered in the book

using System;

Console.WriteLine("=== C# 14 Feature Demonstrations ===\n");

// 1. Primary Constructors (C# 12+)
var person = new Person("Alice", 30);
person.Introduce();

// 2. Collection Expressions (C# 12+)
int[] numbers = [1, 2, 3, 4, 5];
List<string> names = ["Alice", "Bob", "Charlie"];
Console.WriteLine($"Numbers: {string.Join(", ", numbers)}");

// 3. Pattern Matching
var result = CheckValue(42);
Console.WriteLine($"Value check: {result}");

// 4. Records for DTOs
var product = new Product("Laptop", 999.99m, "Electronics");
Console.WriteLine($"Product: {product}");

// 5. Nullable Reference Types
string? nullableText = null;
Console.WriteLine($"Length: {nullableText?.Length ?? 0}");

Console.WriteLine("\n=== Demo Complete ===");

// Helper Methods
static string CheckValue(object value) => value switch
{
    int n when n > 0 => "Positive number",
    int n when n < 0 => "Negative number",
    string s => $"Text: {s}",
    _ => "Unknown type"
};

// Classes with Primary Constructor
class Person(string name, int age)
{
    public string Name { get; } = name;
    public int Age { get; } = age;

    public void Introduce() => 
        Console.WriteLine($"Hi, I'm {Name} and I'm {Age} years old.");
}

// Record for immutable data
record Product(string Name, decimal Price, string Category);
