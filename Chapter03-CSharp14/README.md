# Chapter 03: C# 14 for Beginners

This project contains code examples for **Chapter 3** of the book "Seni Menguasai .NET 10". It demonstrates the core syntax and modern features of C# 14, organized by topic.

## Project Structure

The project is organized into folders corresponding to the sections in the chapter:

| Folder | Topic | Description |
|--------|-------|-------------|
| `Basics` | Variables & Data Types | Type inference (`var`), Enums, Value vs Reference types. |
| `ControlFlow` | Logic | `if-else`, modern `switch` expressions, loops. |
| `Methods` | Functions | Parameters, return values, local functions, expression-bodied members. |
| `OOP` | Object-Oriented | Classes, Inheritance, Interfaces, **Primary Constructors**, **Records**. |
| `Collections` | Data Arrays | `List<T>`, `Dictionary`, **Collection Expressions** (`[]`), Spread operator (`..`). |
| `LINQ` | Querying | Filtering (`Where`), Transforming (`Select`), Ordering, and Aggregation. |
| `Async` | Concurrency | `async`/`await` patterns, `Task.WhenAll`. |
| `Safety` | Null & Exceptions | Nullable reference types, `try-catch` blocks. |
| `Challenges` | Practice | Interactive exercises (e.g., Calculator). |

## How to Run

This is an interactive console application. To run it:

1.  Open a terminal in this directory.
2.  Run the command:
    ```bash
    dotnet run
    ```
3.  You will see a menu to select which example to run:

    ```text
    === C# 14 Chapter 3 Examples ===
    1. Basics (Variables, Types)
    2. Control Flow (Switch, Loops)
    3. Methods (Params, Local functions)
    ...
    9. Challenge: Calculator
    0. Exit
    ```

4.  Enter the number of the example you want to see and press **Enter**.

## Key Features Demonstrated

- **C# 14 / Modern Syntax**:
    - Top-level statements
    - Global using directives (implied)
    - File-scoped namespaces
- **Type Safety**: Nullable reference types enabled.
- **Productivity**: Collection expressions `[1, 2, 3]` and Primary Constructors `class Person(string Name)`.

Enjoy learning C# 14! 🚀
