using System;

namespace Chapter03.OOP
{
    public static class Demo
    {
        public static void Run()
        {
            Console.WriteLine("--- OOP ---");

            // Class with Primary Constructor
            Person p = new("Alice", 30);
            p.Introduce();

            // Record
            var personRecord = new PersonRecord("Bob", 25);
            Console.WriteLine($"Record: {personRecord}");
            
            // Record Mutation (with)
            var olderBob = personRecord with { Age = 26 };
            Console.WriteLine($"Older Record: {olderBob}");

            // Inheritance
            Dog myDog = new Dog { Name = "Buddy" };
            myDog.MakeSound();
        }
    }

    // Primary Constructor (C# 12+)
    public class Person(string name, int age)
    {
        public string Name { get; } = name;
        public int Age { get; } = age;

        public void Introduce()
        {
            Console.WriteLine($"Hi, I'm {Name} and I'm {Age} years old.");
        }
    }

    // Record
    public record PersonRecord(string Name, int Age);

    // Inheritance
    public class Animal
    {
        public string Name { get; set; }
        public virtual void MakeSound() => Console.WriteLine("Generic Sound");
    }

    public class Dog : Animal
    {
        public override void MakeSound() => Console.WriteLine("Woof!");
    }
}
