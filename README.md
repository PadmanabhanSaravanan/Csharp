# CSharp

## **Table of Content**

* [**Introduction**](#introduction)
* [**Reading and writing to a console**](#reading-and-writing-to-a-console)
* [**Built-in data types**](#built-in-data-types)
* [**String data type**](#string-data-type)
* [**Operators**](#operators)
* [**Nullable Types**](#nullable-types)
* [**Datatype conversions**](#datatype-conversions)
* [**Arrays**](#arrays)
* [**Comments**](#comments)
* [**If statement**](#if-statement)
* [**Switch statement**](#switch-statement)
* [**While loop**](#while-loop)
* [**Do while loop**](#do-while-loop)
* [**For & foreach loop**](#for-&-foreach-loop)
* [**Methods**](#methods)
* [**Method parameters**](#method-parameters)
* [**Namespaces**](#namespaces)
* [**Class - Introduction**](#class-introduction)
* [**Static & Instance members**](#static-&-instance-members)
* [**Inheritance**](#inheritance)
* [**Method hiding**](#method-hiding)
* [**Polymorphism**](#polymorphism)
* [**Method overriding Vs hiding**](#method-overriding-vs-hiding)
* [**Method overloading**](#method-overloading)
* [**Why Properties**](#why-properties)
* [**Properties**](#properties)
* [**Structs**](#structs)
* [**Classes Vs Structs**](#classes-vs-structs)
* [**Interfaces**](#interfaces)
* [**Explicit interface implementation**](#explicit-interface-implementation)
* [**Abstract Classes**](#abstract-classes)
* [**Abstract Classes Vs Interfaces**](#abstract-classes-vs-interfaces)
* [**Diamond Problem**](#diamond-problem)
* [**Multiple inheritance**](#multiple-inheritance)
* [**Delegates**](#delegates)
* [**Delegates Example - I**](#delegates-example-i)
* [**Multicast Delegates**](#multicast-delegates)
* [**Exception Handling**](#exception-handling)
* [**Inner Exceptions**](#inner-exceptions)
* [**Custom Exceptions**](#custom-exceptions)
* [**Exception Handling Abuse**](#exception-handling-abuse)
* [**Why Enums**](#why-enums)
* [**Enums Example**](#enums-example)
* [**Enums Concepts**](#enums-concepts)
* [**Types v/s Type Members**](#types-v/s-type-members)
* [**Access Modifiers - Private, Public and Protected**](#access-modifiers-private,-public-and-protected)
* [**Access Modifiers - Internal and Protected Internal**](#access-modifiers-internal-and-protected-internal)
* [**Access Modifiers for types**](#access-modifiers-for-types)
* [**Attributes**](#attributes)
* [**Reflection**](#reflection)
* [**Generics**](#generics)
* [**Reason to override ToString() method**](#reason-to-override-tostring-method)
* [**Reason to override Equals() method**](#reason-to-override-equals-method)
* [**Difference between Convert.ToString() and ToString() method**](#difference-between-convert.tostring-and-tostring-method)
* [**Difference between string and stringbuilder**](#difference-between-string-and-stringbuilder)
* [**Partial classes in C#**](#partial-classes-in-c#)
* [**Creating partial classes in C#**](#creating-partial-classes-in-c#)
* [**Partial methods in c#**](#partial-methods-in-c#)
* [**How and where are indexers used in .net**](#how-and-where-are-indexers-used-in-.net)
* [**Overloading indexers**](#overloading-indexers)
* [**Optional parameters**](#optional-parameters)
* [**Making method parameters optional using method overloading**](#making-method-parameters-optional-using-method-overloading)
* [**Making method parameters optional by specifying parameter defaults**](#making-method-parameters-optional-by-specifying-parameter-defaults)
* [**Making method parameters optional by using OptionalAttribute**](#making-method-parameters-optional-by-using-optionalattribute)
* [**What is dictionary in c#**](#what-is-dictionary-in-c#)
* [**What is dictionary in c# continued**](#what-is-dictionary-in-c#-continued)
* [**List collection class in c#**](#list-collection-class-in-c#)
* [**List collection class in c# continued**](#list-collection-class-in-c#-continued)
* [**Working with generic list class and ranges in c#**](#working-with-generic-list-class-and-ranges-in-c#)
* [**Sort a list of simple types in c#**](#sort-a-list-of-simple-types-in-c#)
* [**Sort a list of complex types in c#**](#sort-a-list-of-complex-types-in-c#)
* [**Sort a list of complex types using Comparison delegate**](#sort-a-list-of-complex-types-using-comparison-delegate)
* [**Some useful methods of List collection class**](#some-useful-methods-of-list-collection-class)
* [**When to use a dictionary over list in c#**](#when-to-use-a-dictionary-over-list-in-c#)
* [**Generic queue collection class**](#generic-queue-collection-class)
* [**Generic stack collection class**](#generic-stack-collection-class)
* [**Real time example of queue collection class in c#**](#real-time-example-of-queue-collection-class-in-c#)
* [**Real time example of stack collection class in c#**](#real-time-example-of-stack-collection-class-in-c#)
* [**Multithreading in C#**](#multithreading-in-c#)
* [**Advantages and disadvantages of multithreading**](#advantages-and-disadvantages-of-multithreading)
* [**ThreadStart delegate**](#threadstart-delegate)
* [**ParameterizedThreadStart delegate**](#parameterizedthreadstart-delegate)
* [**Passing data to the Thread function in a type safe manner**](#passing-data-to-the-thread-function-in-a-type-safe-manner)
* [**Retrieving data from Thread function using callback method**](#retrieving-data-from-thread-function-using-callback-method)
* [**Significance of Thread.Join and Thread.IsAlive functions**](#significance-of-thread.join-and-thread.isalive-functions)
* [**Protecting shared resources from concurrent access in multithreading**](#protecting-shared-resources-from-concurrent-access-in-multithreading)
* [**Difference between Monitor and lock in C#**](#difference-between-monitor-and-lock-in-c#)
* [**Deadlock in a multithreaded program**](#deadlock-in-a-multithreaded-program)
* [**How to resolve a deadlock in a multithreaded program**](#how-to-resolve-a-deadlock-in-a-multithreaded-program)
* [**Anonymous methods in c#**](#anonymous-methods-in-c#)
* [**Lambda expression in c#**](#lambda-expression-in-c#)
* [**Func delegate in c#**](#func-delegate-in-c#)
* [**Async and await in c#**](#async-and-await-in-c#)
* [**How to wait for a thread to finish without blocking**](#how-to-wait-for-a-thread-to-finish-without-blocking)
* [**Tasks**](#tasks)
* [**Concurrency vs Parallelism**](#concurrency-vs-parallelism)
* [**Async vs Thread**](#async-vs-thread)

## **Introduction**

* C# (pronounced "C sharp") is a modern, multi-paradigm programming language designed by Microsoft for developing a wide range of applications that run on the .NET Framework. It is a statically-typed, object-oriented language that is often used to build Windows desktop applications, web applications, games, and mobile applications for iOS and Android.

* C# was first introduced in 2000, as part of Microsoft's .NET initiative, and was designed to be an improvement over C++ and Java. It was created by a team of developers led by Anders Hejlsberg, who had previously worked on the development of Turbo Pascal and Borland Delphi.

* The language was named "C#" because it is a musical notation that represents a half-step higher than the C note, signifying that it is a higher-level language than C or C++. C# was designed to be simple, powerful, and easy to learn, with features such as garbage collection and automatic memory management, making it a popular choice for developers.

* Since its introduction, C# has gone through several iterations, with new features and improvements being added with each release. Some of the most notable versions include C# 2.0 (released in 2005), which introduced generics, anonymous methods, and iterator blocks, and C# 3.0 (released in 2007), which introduced lambda expressions, extension methods, and query expressions.

* Today, C# is widely used by developers around the world and is one of the most popular programming languages in the world, especially for developing Windows desktop applications and games.

### **Advantages of Using C#**

There are several advantages to using C# as a programming language. Some of the main advantages include:

1. **Object-oriented programming:** C# is an object-oriented language, which means that it uses objects to represent data and functionality. This allows for better code organization, reusability, and maintainability.

2. **Cross-platform development:** With the introduction of .NET Core, C# can now be used to develop applications that can run on Windows, Linux, and macOS. This makes it a great choice for developers who want to build applications that can run on multiple platforms.

3. **Integration with .NET Framework:** C# is tightly integrated with the .NET Framework, which provides a rich set of class libraries for common tasks such as working with databases, handling network connections, and processing XML data.

4. **Easy to learn:** C# is a high-level language that is relatively easy to learn, especially for developers who are familiar with other C-style languages such as C++ or Java.

5. **Garbage collection:** C# uses a garbage collector to manage memory, which means that developers do not have to worry about manually allocating and deallocating memory. This can make development faster and less error-prone.

6. **Strong typing:** C# is a strongly-typed language, which means that variables must be declared with a specific data type. This can help catch errors at compile time rather than at runtime, making the code more reliable.

7. Overall, C# is a powerful and versatile language that can be used to develop a wide range of applications. Its object-oriented design, cross-platform capabilities, and integration with the .NET Framework make it a popular choice for developers around the world.

### **Setting up C# and .NET CORE SDK to run your first C# program**

**1. Install Visual Studio 2019:**

-   Download and install Visual Studio 2019 from the official website: [Visual Studio Downloads](https://visualstudio.microsoft.com/downloads/).

**2. Select Workload for .NET Core Development:**

-   During the installation process, ensure that you select the workload for ".NET Core cross-platform development" to include the necessary components for C# and .NET Core development.

**3. Create a New Project:**

-   Open Visual Studio 2019.
-   Click on "Create a new project" or go to File > New > Project.
-   Choose the appropriate project template based on your requirements, such as Console Application, Web Application, etc.

**4. Install or Update .NET Core SDK:**

-   Visual Studio 2019 usually comes with the latest .NET Core SDK installed. However, you can verify or update it by going to Tools > Options > Environment > Preview Features > .NET Core and ensuring that "Use previews of the .NET Core SDK" is checked.
-   You can also download and install the .NET Core SDK separately from the official website: [Download .NET](https://dotnet.microsoft.com/download).

### **Steps to Create and Run the Program**

**To create and run the program:**

* Open Visual Studio.
* Click on "Create a new project" or go to `File > New > Project`.
* Select the appropriate project template for a C# Console Application.
* Give your project a name and click "`Create`".
* Visual Studio will generate a default `Program.cs` file with the basic structure of a C# program.
* Copy the provided C# code into the `Program.cs` file.

  ```cs
  using System;
  
  class Program
  {
      public static void Main(string[] args)
      {
          Console.WriteLine("Hello World!");
      }
  }
  ```

* Press `Ctrl + F5` or `go to Debug > Start Without Debugging` to build and run the program.
* You should see the output "Hello World!" printed in the console window.

## **Reading and writing to a console**

**Reading to a console**

In C#, you can read input from the console using the `Console.ReadLine()` method. This method reads a line of input from the user, and returns the input as a string.

Here is an example of how to use `Console.ReadLine()` to read input from the console:

```
using System;

    class Program
    {
        public static void Main(string[] args)
        {
           Console.WriteLine("Please enter your name:");
               string name = Console.ReadLine();
               Console.WriteLine("Hello, " + name + "!");
        }
    }
```

In this example, the program prompts the user to enter their name, reads the input using Console.ReadLine(), and then uses the input to print a personalized greeting message to the console.

Please note that C# is **case sensitive language**.

**Writing to a console**

There are multiple ways to write to the console in C#. Here are two common ways:

**1. Concatenation**: You can use the concatenation operator `+` to combine strings and variables, and then pass the concatenated string to `Console.WriteLine()` or `Console.Write()`.

```
using System;

    class Program
    {
        public static void Main(string[] args)
        {
           string name = "John";
               int age = 30;
               Console.WriteLine("Hello, " + name + ". You are " + age + " years old.");
        }
    }
```

In this example, the program uses concatenation to combine strings and variables before passing them to `Console.WriteLine()`.

**2. String Interpolation:** Starting with C# 6, you can use string interpolation as another way to format strings. It provides a more concise and readable syntax.

```
using System;

    class Program
    {
        public static void Main(string[] args)
        {
           string name = "John";
          int age = 30;
          Console.WriteLine($"Hello, {name}. You are {age} years old.");
        }
    }
```

In this example, the program uses string interpolation by placing the variables inside curly braces `{}` within the string. The values of the variables are automatically inserted into the string when it is evaluated.

Please note that C# is a **case-sensitive language**.

## **Built in data types**

C# is a statically typed programming language that provides a set of built-in types, also known as primitive types, which are fundamental to the language and allow developers to declare variables and data structures.

**Here are the built-in types in C#:**

1. **Boolean:** represents a Boolean value, which can be either true or false.
2. **Byte:** represents an 8-bit unsigned integer.
3. **SByte:** represents an 8-bit signed integer.
4. **Char**: represents a single character.
5. **Decimal**: represents a decimal number with 28-29 significant digits.
6. **Double**: represents a double-precision floating-point number.
7. **Float**: represents a single-precision floating-point number.
8. **Int**: represents a 32-bit signed integer.
9. **UInt**: represents a 32-bit unsigned integer.
10. **Long**: represents a 64-bit signed integer.
11. **ULong**: represents a 64-bit unsigned integer.
12. **Object**: represents any type of object.
13. **Short**: represents a 16-bit signed integer.
14. **UShort**: represents a 16-bit unsigned integer.
15. **String**: represents a sequence of Unicode characters.

Developers can use these built-in types to define variables, constants, and data structures to manipulate data in their C# programs.

**Here's an example code that uses some of the built-in types in C#:**

```
using System;

class Program
{
    static void Main()
    {
        // Declare and initialize some variables
        int age = 30;
        double height = 1.75;
        bool isMarried = true;
        char gender = 'M';
        string name = "John";

        // Output the values of the variables
        Console.WriteLine("Name: {0}", name);
        Console.WriteLine("Age: {0}", age);
        Console.WriteLine("Gender: {0}", gender);
        Console.WriteLine("Height: {0}m", height);
        Console.WriteLine("Married: {0}", isMarried);
    }
}
```

In this code, we declare and initialize variables of various built-in types, including int, double, bool, char, and string. We then use the Console.WriteLine method to output the values of these variables to the console. 

**The output will be:**

```
Name: John
Age: 30
Gender: M
Height: 1.75m
Married: True
```

This is just a simple example of how built-in types can be used in C# programs. Developers can use these types to create more complex data structures, perform calculations, and manipulate data in a variety of ways.

## **String data type**

In C#, a verbatim string literal is a string literal that starts with the `@` character. Verbatim literals are useful when you want to include special characters or escape sequences in a string without having to use escape characters.

In a verbatim string literal, the backslash character () is treated as a regular character, and special characters are represented by their literal values. For example, to include a newline character in a verbatim string literal, you can simply use a line break, like this:

```
string message = @"Hello,
World!";
```

This will create a string with the value "Hello,\r\nWorld!", where \r\n represents a newline character.

In summary, verbatim string literals are a convenient way to include special characters and escape sequences in a string without having to use escape characters. They are particularly useful for including file paths and regular expressions.

### **Escape Sequences**

An escape sequence is a combination of characters that represent a special character or a command. These sequences start with a backslash () character, followed by one or more characters that have a special meaning. Here are some of the commonly used escape sequences in C#:

1. \n - newline character
2. \r - carriage return character
3. \t - tab character
4. \b - backspace character
5. \f - form feed character
6. ' - single quote character
7. " - double quote character

For example, to include a newline character in a string literal, you can use the escape sequence \n, like this:

```
string message = "Hello,\nWorld!";
```

This will create a string with the value "Hello," on one line, followed by "World!" on the next line.

## **Operators**

Operators in C# are special symbols or keywords that perform various operations on one or more operands, which can be constants, variables, or expressions. There are several categories of operators in C#, including:

**1. Arithmetic operators:** perform basic arithmetic operations such as addition `(+)`, subtraction `(-)`, multiplication `(\*)`, division `(/)`, and modulus `(%)`.

**2. Comparison operators:** compare two values and return a Boolean value of true or false. Examples include equals `(==)`, not equals `(!=)`, greater than `(>)`, less than `(<)`, greater than or equal to `(>=)`, and less than or equal to `(<=)`.

**3. Logical operators:** perform logical operations on Boolean values. Examples include logical AND `(&&)`, logical OR `(||)`, and logical NOT `(!)`.

**4. Assignment operators:** assign a value to a variable. Examples include `=`, `+=`, `-=`, `\*=`, `/=`, and `%=`.

**5. Increment and decrement operators:** increase or decrease the value of a variable by 1. Examples include `++` and `--`.

**6. Bitwise operators:** perform operations on the binary representation of a number. Examples include bitwise AND `(&)`, bitwise OR `(|)`, bitwise XOR`(^)`, bitwise NOT `(~)`, left shift `(<<)`, and right shift `(>>)`.

**7. Ternary operator:** a conditional operator that returns one of two values based on a condition. The syntax is `?` :.

**Here is an example code that uses some of these operators in C#:**

```
using System;

class Program
{
    static void Main()
    {
        // Declare and initialize some variables
        int a = 5, b = 10;
        bool isTrue = true;

        // Perform some arithmetic operations
        int sum = a + b;
        int difference = b - a;
        int product = a * b;
        int quotient = b / a;
        int remainder = b % a;

        // Use comparison and logical operators
        bool isEqual = (a == b);
        bool isGreater = (a > b);
        bool isTrueOrGreater = (isTrue || isGreater);

        // Use assignment and increment operators
        a += 1;
        b -= 1;
        a++;
        b--;

        // Output the results
        Console.WriteLine("Sum: {0}", sum);
        Console.WriteLine("Difference: {0}", difference);
        Console.WriteLine("Product: {0}", product);
        Console.WriteLine("Quotient: {0}", quotient);
        Console.WriteLine("Remainder: {0}", remainder);
        Console.WriteLine("Is a equal to b? {0}", isEqual);
        Console.WriteLine("Is a greater than b? {0}", isGreater);
        Console.WriteLine("Is true or greater? {0}", isTrueOrGreater);
        Console.WriteLine("a: {0}", a);
        Console.WriteLine("b: {0}", b);
    }
}
```

In this code, we use various arithmetic, comparison, logical, assignment, and increment operators to perform calculations and manipulate values. 

**The output will be:**

```
Sum: 15
Difference: 5
Product: 50
Quotient: 2
Remainder: 0
Is a equal to b? False
Is a greater than b? False
Is true or greater? True
a: 6
b: 9
```

## **Nullable Types**

**In C# types are divided into 2 broad categories.**

* **Value Types** - int, float, double, structs, enums etc
* **Reference Types** – Interface, Class, delegates, arrays etc

**By default value types are non nullable. To make them nullable use ?**

* int i = 0 (i is non nullable, so "i" cannot be set to null, i = null will generate compiler error)
* int? j = 0 (j is nullable int, so j=null is legal)

**Nullable types bridge the differences between C# types and Database types**

```
using System;
class Program
{
    static void Main()
    {
        int AvailableTickets;
        int? TicketsOnSale = null;

        if (TicketsOnSale == null)
        {
            AvailableTickets = 0;
        }
        else
        {
            AvailableTickets = (int)TicketsOnSale;
        }

        Console.WriteLine("Available Tickets={0}", AvailableTickets);
    }
}
```

```
using System;
class Program
{
    static void Main()
    {
        int AvailableTickets;
        int? TicketsOnSale = null;

        //Using null coalesce operator ??
        AvailableTickets = TicketsOnSale ?? 0;

        Console.WriteLine("Available Tickets={0}", AvailableTickets);
    }

}
```

## **Datatype conversions**

Data type conversions can be classified into two categories: implicit conversions and explicit conversions.

**Implicit Conversions:**

* Implicit conversions occur automatically when a value of one data type is assigned to a variable of another data type. This is possible when the value being assigned can be safely converted to the destination data type without losing information. For example, assigning an integer to a double can be done implicitly because there is no loss of information.

  ```
  int myInt = 42;
  double myDouble = myInt;  // Implicit conversion from int to double
  ```

**Explicit Conversions:**

* Explicit conversions are performed when a value of one data type needs to be converted to another data type that cannot be done implicitly. This is done using explicit casting, which involves specifying the destination data type in parentheses before the value being converted. Explicit conversions can result in data loss or errors if the value being converted cannot fit into the destination data type.

  ```
  double myDouble = 3.14;
  int myInt = (int)myDouble;  // Explicit conversion from double to int
  ```

* In this example, we are converting a double value to an integer using explicit casting. Since integers cannot hold decimal values, the decimal part of the double value is lost during the conversion.

* Other examples of explicit conversions include using Convert class methods, such as Int32.Parse(), to convert a string to an integer, or using ToString() to convert a number to a string.

**Difference between Parse and TryParse**

1. If the number is in a string format you have 2 options - Parse() and TryParse()
2. Parse() method throws an exception if it cannot parse the value, whereas TryParse() returns a bool indicating whether it succeeded or failed.
3. Use Parse() if you are sure the value will be valid, otherwise use TryParse()

## **Arrays**

An array is a collection of similar data types.

```
using System;
class Program
{
    public static void Main()
    {
        // Initialize and assign values in different lines
        int[] EvenNumbers = new int[3];
        EvenNumbers[0] = 0;
        EvenNumbers[1] = 2;
        EvenNumbers[2] = 4;

        // Initialize and assign values in the same line
        int[] OddNumbers = { 1, 3, 5};

        Console.WriteLine("Printing EVEN Numbers");

        // Retrieve and print even numbers from the array
        for (int i = 0; i < EvenNumbers.Length; i++)
        {
            Console.WriteLine(EvenNumbers[i]);
        }

        Console.WriteLine("Printing ODD Numbers");

        // Retrieve and print odd numbers from the array
        for (int i = 0; i < OddNumbers.Length; i++)
        {
            Console.WriteLine(OddNumbers[i]);
        }
    }
}

```

**Advantages:** Arrays are strongly typed.

**Disadvantages:** Arrays cannot grow in size once initialized. Have to rely on integral indices to store or retrieve items from the array.

## **Comments**

Comments are used to add notes, explanations, or other information to the code that are not meant to be executed. Comments can be useful for providing context to the code, making it easier for other developers to understand what the code is doing.

* Single line Comments - `//`

* Multi line Comments - `\* \*/`

* XML Documentation Comments - `///`

**Single-line comments start with two forward slashes `//` and continue until the end of the line. Here's an example:**

```
// This is a single-line comment
int x = 5;  // This is another single-line comment
```

In this example, we use single-line comments to provide notes about the code on each line.

**Multi-line comments, also known as block comments, start with `/*` and end with `*/`. Here's an example:**

```
/*
This is a multi-line comment.
It can span multiple lines and is useful
for providing longer explanations or notes.
*/
int y = 10;
```

In this example, we use a multi-line comment to provide a longer explanation of the code that follows.

* It's important to use comments effectively and appropriately in code. Comments should be used to explain why the code is doing what it's doing, not what the code is doing. Good comments can help make code more readable and maintainable, but too many comments or poorly written comments can make code harder to read and understand.

* In addition to single-line and multi-line comments, C# also supports XML documentation comments, which are used to generate documentation for code elements such as classes, methods, and properties. XML documentation comments start with /// and use a special syntax to provide information about the code element.


## **If statement**

If statements are used for conditional branching. They allow you to specify a block of code to be executed if a certain condition is true, and a different block of code to be executed if the condition is false. if statements are used for conditional branching. They allow you to specify a block of code to be executed if a certain condition is true, and a different block of code to be executed if the condition is false.

**Here is the basic syntax of an if statement in C#:**

```
if (condition)
{
   // code to be executed if condition is true
}
else
{
   // code to be executed if condition is false
}
```

The `condition` is a boolean expression that evaluates to either true or false. If it is true, the code inside the first block of curly braces will be executed. If it is false, the code inside the second block of curly braces (the `else` block) will be executed.

You can also use an `else if` statement to specify additional conditions to be tested if the first condition is false.

**Here's an example:**

```
if (condition1)
{
    // code to be executed if condition1 is true
}
else if (condition2)
{
    // code to be executed if condition2 is true
}
else
{
    // code to be executed if both condition1 and condition2 are false
}
```

In this example, if `condition1` is true, the code inside the first block of curly braces will be executed. If `condition1` is false and `condition2` is true, the code inside the second block of curly braces will be executed. If both `condition1` and `condition2` are false, the code inside the else block will be executed.

It's important to note that the code inside an `if` statement (or any other type of block in C#) must be enclosed in curly braces, even if there is only one statement. This is because C# requires that all blocks of code be enclosed in curly braces, and not doing so can lead to hard-to-find bugs.

## **Switch statement**

A switch statement is used for multi-way branching, where the program selects one of several possible actions to take based on the value of a single expression.

**Basic Syntax:**

```
switch (expression)
{
    case value1:
        // code to be executed if expression equals value1
        break;
    case value2:
        // code to be executed if expression equals value2
        break;
    ...
    default:
        // code to be executed if expression doesn't match any of the cases
        break;
}
```

The `expression` is the value that the program is evaluating. The `case` statements are the possible values that `expression` can take. If `expression` equals `value1`, for example, the code inside the first block of curly braces will be executed. The `break` keyword is used to exit the switch statement and continue with the rest of the program.

If `expression` does not match any of the `case` statements, the code inside the `default` block of curly braces will be executed.

It's important to note that the `case` values must be compile-time constants, meaning they must be known at the time the program is compiled. This means that you can't use variables or expressions as case values.

```
int day = 3;
string dayName;

switch (day)
{
    case 1:
        dayName = "Monday";
        break;
    case 2:
        dayName = "Tuesday";
        break;
    case 3:
        dayName = "Wednesday";
        break;
    case 4:
        dayName = "Thursday";
        break;
    case 5:
        dayName = "Friday";
        break;
    case 6:
        dayName = "Saturday";
        break;
    case 7:
        dayName = "Sunday";
        break;
    default:
        dayName = "Invalid day";
        break;
}

Console.WriteLine(dayName);
```

In this example, the program evaluates the value of the `day` variable, and assigns the corresponding day name to the `dayName` variable using a switch statement. If `day` is equal to 3, for example, the program will execute the code inside the third block of curly braces, and assign the value "Wednesday" to the `dayName` variable. The program will then output "Wednesday" to the console.

A switch statement is used for multi-way branching, where the program selects one of several possible actions to take based on the value of a single expression.

**Basic Syntax:**

```
switch (expression)
{
    case value1:
        // code to be executed if expression equals value1
        break;
    case value2:
        // code to be executed if expression equals value2
        break;
    ...
    default:
        // code to be executed if expression doesn't match any of the cases
        break;
}
```

The `expression` is the value that the program is evaluating. The `case` statements are the possible values that `expression` can take. If `expression` equals `value1`, for example, the code inside the first block of curly braces will be executed. The `break` keyword is used to exit the switch statement and continue with the rest of the program.

If `expression` does not match any of the `case` statements, the code inside the `default` block of curly braces will be executed.

It's important to note that the `case` values must be compile-time constants, meaning they must be known at the time the program is compiled. This means that you can't use variables or expressions as case values.

```
int day = 3;
string dayName;

switch (day)
{
    case 1:
        dayName = "Monday";
        break;
    case 2:
        dayName = "Tuesday";
        break;
    case 3:
        dayName = "Wednesday";
        break;
    case 4:
        dayName = "Thursday";
        break;
    case 5:
        dayName = "Friday";
        break;
    case 6:
        dayName = "Saturday";
        break;
    case 7:
        dayName = "Sunday";
        break;
    default:
        dayName = "Invalid day";
        break;
}

Console.WriteLine(dayName);
```

In this example, the program evaluates the value of the `day` variable, and assigns the corresponding day name to the `dayName` variable using a switch statement. If `day` is equal to 3, for example, the program will execute the code inside the third block of curly braces, and assign the value "Wednesday" to the `dayName` variable. The program will then output "Wednesday" to the console.

## **While loop**

A `while` loop is used to repeatedly execute a block of code as long as a specified condition is true. The loop will continue to execute until the condition is no longer true.

**Here is the basic syntax of a `while` loop in C#:**

```
while (condition)
{
   // code to be executed while condition is true
}
```

The `condition` is a boolean expression that is evaluated before each iteration of the loop. If it is true, the code inside the curly braces will be executed. If it is false, the loop will exit, and program execution will continue with the statement immediately following the loop.

```
int i = 0;

while (i < 10)
{
    Console.WriteLine(i);
    i++;
}
```

In this example, the loop will execute as long as the value of `i` is less than 10. The program will output the value of `i` to the console, increment the value of `i` by 1, and then repeat the process. This will continue until `i` is equal to 10, at which point the loop will exit and program execution will continue with the statement immediately following the loop.

It's important to note that you should always make sure that the condition in a `while` loop will eventually become false, otherwise the loop will continue to execute indefinitely, which is known as an infinite loop. This can cause the program to hang or crash, and can be difficult to debug.

## **Do while loop**

A `do-while` loop is similar to a `while` loop, but with one key difference: the condition is evaluated after the loop has executed at least once. This means that the code inside the loop will always be executed at least once, even if the condition is initially false.

**Do-While Loop Basic Syntax**

```
do
{
    // code to be executed at least once
}
while (condition);
```

The code inside the curly braces will be executed at least once, regardless of whether the condition is true or false. After the code has executed, the condition will be evaluated. If it is true, the loop will execute again. If it is false, the loop will exit, and program execution will continue with the statement immediately following the loop.

**Here's an example of a `do-while` loop in C#:**

```
int i = 0;

do
{
    Console.WriteLine(i);
    i++;
}
while (i < 10);
```

In this example, the loop will execute at least once, because the condition `i < 10` is not evaluated until after the first iteration of the loop. The program will output the value of `i` to the console, increment the value of `i` by 1, and then repeat the process until `i` is equal to 10, at which point the loop will exit and program execution will continue with the statement immediately following the loop.

It's important to note that, like with a `while` loop, you should always make sure that the condition in a `do-while` loop will eventually become false, otherwise the loop will continue to execute indefinitely, which is known as an infinite loop. This can cause the program to hang or crash, and can be difficult to debug.

## **For & foreach loop**

The `for` loop is a control flow statement that allows you to loop through a block of code for a specified number of times. 

**Here is the basic syntax of a `for` loop in C#:**

```
for (initialization; condition; increment/decrement)
{
    // code to be executed
}
```

The `initialization` expression is executed once before the loop starts, and is used to set the initial value of the loop variable. The `condition` expression is evaluated before each iteration of the loop. If it is true, the code inside the curly braces will be executed. If it is false, the loop will exit, and program execution will continue with the statement immediately following the loop. The `increment/decrement` expression is executed at the end of each iteration of the loop, and is used to update the value of the loop variable.

**Here's an example of a `for` loop in C# that iterates over an array:**

```
int[] numbers = { 1, 2, 3, 4, 5 };

for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine(numbers[i]);
}
```

In this example, the loop will execute for each element in the `numbers` array. The loop variable `i` is initialized to 0, and the loop will continue as long as `i` is less than the length of the `numbers` array. The program will output the value of `numbers[i]` to the console, increment the value of `i` by 1, and then repeat the process. This will continue until `i` is equal to the length of the `numbers` array, at which point the loop will exit and program execution will continue with the statement immediately following the loop.

### **foreach loop**

The `foreach` loop is a simplified version of the `for` loop, which is used for iterating over collections that implement the `IEnumerable` interface. 

**Here is the basic syntax of a `foreach` loop in C#:**

```
foreach (var item in collection)
{
    // code to be executed for each item in the collection
}
```

The `collection` is a collection of items to iterate over, and `item` is a temporary variable that represents each item in the collection. The loop will execute once for each item in the collection.

**Here's an example of a `foreach` loop in C# that iterates over an array:**

```
int[] numbers = { 1, 2, 3, 4, 5 };

foreach (int number in numbers)
{
    Console.WriteLine(number);
}
```

In this example, the loop will execute for each element in the `numbers` array. The loop variable `number` represents each element in the array, and the program will output the value of `number` to the console for each iteration of the loop.

It's important to note that `foreach` loops are generally easier to use and less error-prone than `for` loops when iterating over collections, as the loop variable is automatically updated and you don't have to worry about indexing or updating the loop variable yourself.

## **Methods**

In C#, methods are blocks of code that are designed to perform specific tasks or operations. A method in C# can be thought of as a subprogram that can be called from within a program to perform a specific action.

**There are several types of methods in C#:**

1. **Static methods:** These are methods that are associated with a class rather than an instance of that class. They can be called directly using the class name, without the need to create an instance of the class.

2. **Instance methods:** These are methods that are associated with an instance of a class. They can be called on an object of that class using the dot notation.

Static and instance methods are two types of methods in C# that have different ways of being accessed and used.

A static method is associated with a class rather than an instance of that class. It can be called directly using the class name, without the need to create an instance of the class. 

**Static methods are often used for utility functions that do not require any specific object state to be executed**.

```
public class MathUtils
{
    public static int Add(int x, int y)
    {
        return x + y;
    }
}

// Calling the static method
int result = MathUtils.Add(3, 5);

```

In this example, the `Add` method is declared as `static` using the static keyword in its signature. This means that we can call the method directly on the class name without having to create an instance of `MathUtils`. We can call the method by passing in two integers as arguments, and it will return the sum of those integers.

An instance method, on the other hand, is associated with an instance of a class. It can be called on an object of that class using the dot notation. Instance methods are often used to perform operations on the state of a specific object.

**Here's an example of an instance method:**

```
public class Person
{
    public string Name { get; set; }

    public void SayHello()
    {
        Console.WriteLine($"Hello, my name is {Name}");
    }
}

// Creating an instance of the Person class
Person person = new Person();
person.Name = "John";

// Calling the instance method
person.SayHello();

```

In this example, the `Person` class has an instance method called `SayHello`. This method accesses the `Name` property of the object to output a message using `Console.WriteLine()`. We create an instance of `Person` and set the `Name` property to "John". We can then call the `SayHello` method on the `person` object using the dot notation. When we call the method, it outputs the message "Hello, my name is John".

## **Method parameters**

**There are four different types of method parameters that can be used in method signatures:**

1. **Value parameters:** These are the most common type of parameter in C#. Value parameters are used to pass data to a method by value. This means that a copy of the value is created and passed to the method. Any changes made to the value inside the method are not reflected outside the method.

2. **Reference parameters:** Reference parameters are used to pass data to a method by reference. This means that a reference to the value is passed to the method. Any changes made to the value inside the method are reflected outside the method.

3. **Output parameters:** Output parameters are used to return data from a method. They are similar to reference parameters, but they do not require the value to be initialized before it is passed to the method. The value is initialized inside the method and returned to the caller.

4. **Params parameters:** Params parameters are used to pass a variable number of arguments to a method. The keyword "params" is used before the parameter type to indicate that the parameter is a variable-length argument list.

**Here's an example of each type of parameter:**

```
public void ValueParameter(int x)
{
    x = x + 1;
    Console.WriteLine(x);
}

public void ReferenceParameter(ref int x)
{
    x = x + 1;
    Console.WriteLine(x);
}

public void OutputParameter(int x, out int y)
{
    y = x + 1;
    Console.WriteLine(y);
}

public void ParamsParameter(params string[] names)
{
    foreach (string name in names)
    {
        Console.WriteLine(name);
    }
}

```

In this example, the `ValueParameter` method takes a value parameter `x`. The `ReferenceParameter` method takes a reference parameter `x`. The `OutputParameter` method takes an output parameter `y` and returns its value to the caller. The `ParamsParameter` method takes a params parameter `names`, which allows the method to accept any number of string arguments.

## **Namespaces**

Namespaces in C# are used to organize too many classes so that it can be easy to handle the application.

In a simple C# program, we use System.Console where System is the namespace and Console is the class. To access the class of a namespace, we need to use namespacename.classname. We can use using keyword so that we don't have to use complete name all the time.

In C#, global namespace is the root namespace. The global::System will always refer to the namespace "System" of .Net Framework.

**C# namespace example**

```
using System;  
namespace NamespaceApp  
{  
    class Program  
    {  
        static void Main(string[] args)  
        {  
            Console.WriteLine("Hello Namespace!");  
        }  
    }  
} 
``` 

**Output:**

```
Hello Namespace!
```

**namespace example: by fully qualified name**

```
using System;  
namespace First {  
public class Hello  
{  
    public void sayHello() { Console.WriteLine("Hello First Namespace"); }  
}  
}  
namespace Second  
{  
    public class Hello  
    {  
        public void sayHello() { Console.WriteLine("Hello Second Namespace"); }  
    }  
}  
public class TestNamespace  
{  
    public static void Main()  
    {  
        First.Hello h1 = new First.Hello();  
        Second.Hello h2 = new Second.Hello();  
        h1.sayHello();  
        h2.sayHello();  
  
    }  
}
```  

**Output:**

```
Hello First Namespace
Hello Second Namespace
```

## **Class Introduction**

A class is a blueprint or a template for creating objects that have similar properties and methods. It is a fundamental building block of object-oriented programming in C#.

A class encapsulates data and behavior (methods) that operate on that data. It defines the properties, methods, and events that are common to all objects of that class. These properties and methods can be accessed and used by the objects created from that class.

**Here's a example of a class in C#:**

```
public class Rectangle {
   // Fields (data)
   private int length;
   private int width;

   // Constructor
   public Rectangle(int length, int width) {
      this.length = length;
      this.width = width;
   }

   // Properties
   public int Length {
      get { return length; }
      set { length = value; }
   }

   public int Width {
      get { return width; }
      set { width = value; }
   }

   // Method
   public int Area() {
      return length * width;
   }
}
```

In this example, the "Rectangle" class has two fields (data), "length" and "width", a constructor that takes two parameters to initialize the fields, two properties ("Length" and "Width") that provide access to the fields, and a method ("Area") that calculates the area of the rectangle.

**You can create an instance of the "Rectangle" class and set its length and width properties like this:**

```
Rectangle rect = new Rectangle(5, 10);
rect.Length = 7;
rect.Width = 14;
```

**And you can call the "Area" method to get the area of the rectangle:**

```
int area = rect.Area(); // returns 98 (7 * 14)

```

## **Static & Instance members**

* In C#, class members can be either static or instance members. The difference between them is how they are associated with the class and with instances of the class.
* When a class member includes a static modifier, the member is called as static member. When no static modifier is present the member is called as non static member or instance member.
* Static members are invoked using class name, where as instance members are invoked using instances (objects) of the class.
* Static members are associated with the class itself, rather than with instances of the class. They can be accessed using the class name, without the need to create an instance of the class. Static members are created only once, when the program starts, and they exist for the entire lifetime of the program.

**Here's an example of a class with a static member:**

```
public class MyClass {
   // Instance field
   private int value;

   // Static field
   private static int count;

   // Constructor
   public MyClass(int value) {
      this.value = value;
      count++;
   }

   // Instance method
   public int GetValue() {
      return value;
   }

   // Static method
   public static int GetCount() {
      return count;
   }
}

```

* In this example, the "count" field is a static field that is associated with the class, and the "GetCount" method is a static method that can be called using the class name, without creating an instance of the class.
* Instance members, on the other hand, are associated with instances of the class, rather than with the class itself. They can be accessed only through an instance of the class, after the instance has been created.
* An instance member belongs to specific instance(object) of a class.

**Here's an example of a class with instance members:**

```
public class MyClass {
   // Instance field
   private int value;

   // Constructor
   public MyClass(int value) {
      this.value = value;
   }

   // Instance method
   public int GetValue() {
      return value;
   }

   // Instance property
   public int Value {
      get { return value; }
      set { value = value; }
   }
}

```

In this example, the "value" field and the "GetValue" method are instance members, and can be accessed only through an instance of the class. The "Value" property is also an instance member, but it provides a way to access and modify the "value" field using a property syntax.

To summarize, static members are associated with the class itself, and instance members are associated with instances of the class. Static members can be accessed using the class name, without the need to create an instance of the class, and instance members can be accessed only through an instance of the class.

## **Inheritance**

Inheritance is a mechanism by which a new class (called the derived class) is created from an existing class (called the base class), and the new class inherits all the members of the base class, such as fields, methods, properties, and events. The derived class can also add new members or override the base class members as needed.

**To define a class that inherits from another class in C#, you use the ":" symbol followed by the name of the base class, like this:**

```
class DerivedClass : BaseClass {
    // class members go here
}
```

**Here's an example of a simple base class:**

```
class Shape {
    protected int width;
    protected int height;

    public void SetWidth(int w) {
        width = w;
    }

    public void SetHeight(int h) {
        height = h;
    }
}

```

**And here's an example of a derived class that inherits from the base class:**

```
class Rectangle : Shape {
    public int GetArea() {
        return (width * height);
    }
}

```

In this example, the Rectangle class inherits from the Shape class, and it adds a new method called GetArea that calculates the area of a rectangle using the width and height fields inherited from the base class.

**Here's how you can use the derived class:**

```
Rectangle rect = new Rectangle();
rect.SetWidth(5);
rect.SetHeight(10);
int area = rect.GetArea();
Console.WriteLine("Area of rectangle = {0}", area);

```

In this example, a new instance of the Rectangle class is created, and its width and height fields are set using the SetWidth and SetHeight methods inherited from the Shape class. The GetArea method defined in the Rectangle class is then used to calculate and display the area of the rectangle.

Note that the protected access modifier is used to make the width and height fields accessible to the derived class, but not to other classes outside the hierarchy. This is a way to encapsulate the implementation details of the base class and promote code reuse through inheritance.

Summary:

**Inheritance Syntax**

```

public class ParentClass
{
// Parent Class Implementation
}
public class DerivedClass : ParentClass
{
    // ChildClass Implementation
}

```

1. C# supports only single class inheritance.
2. C# supports multiple interface inheritance.
3. Child cicass is a specialization of base class.
4. Base classes are automatically instantiated before derived classes.
5. Parent Class constructor executes before Child Class constructor.

## **Method hiding**

Method hiding is a technique used to create a new version of a method in a derived class that has the same name and signature as a method in the base class, but a different implementation.

Method hiding is achieved by using the "new" keyword to declare the method in the derived class. When a method is hidden, the method in the derived class is called instead of the method in the base class when the method is invoked on an instance of the derived class.

**Here's an example of method hiding in C#:**

```
class BaseClass
{
    public void Method1()
    {
        Console.WriteLine("BaseClass.Method1");
    }
}

class DerivedClass : BaseClass
{
    public new void Method1()
    {
        Console.WriteLine("DerivedClass.Method1");
    }
}

class Program
{
    static void Main(string[] args)
    {
        BaseClass obj1 = new BaseClass();
        obj1.Method1();  // Output: BaseClass.Method1

        DerivedClass obj2 = new DerivedClass();
        obj2.Method1();  // Output: DerivedClass.Method1

        BaseClass obj3 = new DerivedClass();
        obj3.Method1();  // Output: BaseClass.Method1
    }
}
```

In this example, the **DerivedClass** hides the **Method1** from the **BaseClass** by declaring a new method with the same name and signature. When **Method1** is called on an instance of **DerivedClass**, the implementation in </b>'**DerivedClass** is called instead of the implementation in **BaseClass**. However, when **Method1** is called on an instance of **BaseClass** that actually holds an instance of **DerivedClass**, the implementation in **BaseClass** is called.

### **Base Keyword**

The **base** keyword in C# is used to refer to the base class, or the class that a derived class is inheriting from.

When a method in a derived class is hiding a method in the base class, the base keyword can be used to call the hidden method from the derived class. This allows the derived class to reuse the implementation of the method in the base class, while still providing its own implementation for the method.

**Here's an example of using the `base` keyword in method hiding:**

```
class BaseClass
{
    public void Method1()
    {
        Console.WriteLine("BaseClass.Method1");
    }
}

class DerivedClass : BaseClass
{
    public new void Method1()
    {
        Console.WriteLine("DerivedClass.Method1");

        // Call the Method1 implementation from the base class
        base.Method1();
    }
}

class Program
{
    static void Main(string[] args)
    {
        DerivedClass obj = new DerivedClass();
        obj.Method1();
    }
}
```

In this example, the **DerivedClass** is hiding the **Method1** from the **BaseClass** by declaring a new method with the same name and signature. The **Method1** implementation in the **DerivedClass** is called first, and then the **base.Method1()** call is used to call the implementation of **Method1** in the **BaseClass**.

**The output of this program will be:**

```
DerivedClass.Method1
BaseClass.Method1
```

So, the implementation of **Method1** in the **BaseClass** is also called after the implementation of **Method1** in the **DerivedClass** is executed.

## **Polymorphism**

Polymorphism is a fundamental concept in object-oriented programming that allows objects of different types to be treated as if they were of the same type. It is the ability of an object to take on many forms or have multiple behaviors based on the context in which it is used.

There are two main types of polymorphism: compile-time polymorphism (also known as method overloading) and run-time polymorphism (also known as method overriding).

Compile-time polymorphism allows methods with the same name to be defined in the same class, with different parameters. When a method is called, the compiler decides which method to call based on the number and types of arguments passed to the method.

Run-time polymorphism occurs when a method in a subclass has the same name and signature as a method in its superclass. In this case, the subclass method overrides the superclass method, and the subclass object can be treated as an instance of its superclass. The method called at runtime is determined by the actual type of the object that the method is called on, rather than the declared type of the reference variable.

**Here's an example of polymorphism in C#:**

```
class Animal
{
    public virtual void Speak()
    {
        Console.WriteLine("Animal speaks");
    }
}

class Cat : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Meow");
    }
}

class Dog : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Woof");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Animal myAnimal = new Animal();
        myAnimal.Speak(); // Output: Animal speaks

        Animal myCat = new Cat();
        myCat.Speak(); // Output: Meow

        Animal myDog = new Dog();
        myDog.Speak(); // Output: Woof
    }
}

```

In this example, the `Animal` class has a virtual method called `Speak`. The `Cat` and `Dog` classes override this method with their own implementations. In the Main method, we create instances of `Animal`, `Cat`, and `Dog`, but we assign them to variables of type `Animal`. When the `Speak` method is called on these variables, the implementation of the method that is called is determined at runtime based on the actual type of the object. This demonstrates the run-time polymorphism.

## **Method overriding Vs hiding**

Method overriding and method hiding are both ways to provide new implementations of a method in a derived class. However, there are some key differences between these two concepts.

Method overriding occurs when a method in a derived class has the same name and signature as a method in its base class. The derived class method overrides the base class method, and when the method is called on an object of the derived class, the overridden method in the derived class is executed. Method overriding is achieved using the `override` keyword in C#.

Method hiding, on the other hand, occurs when a method in a derived class has the same name as a method in its base class, but a different signature. The derived class method hides the base class method, and when the method is called on an object of the derived class, the method in the derived class is executed instead of the method in the base class. Method hiding is achieved using the `new` keyword in C#.

**Here's an example that demonstrates the difference between method overriding and method hiding:**

```
class BaseClass
{
    public virtual void Method1()
    {
        Console.WriteLine("BaseClass.Method1");
    }

    public void Method2()
    {
        Console.WriteLine("BaseClass.Method2");
    }
}

class DerivedClass : BaseClass
{
    public override void Method1()
    {
        Console.WriteLine("DerivedClass.Method1");
    }

    public new void Method2()
    {
        Console.WriteLine("DerivedClass.Method2");
    }
}

class Program
{
    static void Main(string[] args)
    {
        BaseClass obj1 = new DerivedClass();
        obj1.Method1(); // Output: DerivedClass.Method1
        obj1.Method2(); // Output: BaseClass.Method2

        DerivedClass obj2 = new DerivedClass();
        obj2.Method1(); // Output: DerivedClass.Method1
        obj2.Method2(); // Output: DerivedClass.Method2
    }
}

```

In this example, `BaseClass` has two methods: `Method1` and `Method2`. The `DerivedClass` overrides `Method1` using the `override` keyword and hides `Method2` using the `new` keyword.

When we create an instance of `DerivedClass` and call `Method1` and `Method2` on it, we get the expected output of `DerivedClass.Method1` and `DerivedClass.Method2`. However, when we create an instance of `DerivedClass` and assign it to a variable of type `BaseClass`, and call `Method1` and `Method2` on it, we get the output of `DerivedClass.Method1` and `BaseClass.Method2`.

This demonstrates the difference between method overriding and method hiding. Method overriding allows the overridden method to be called through a base class reference, whereas method hiding only allows the new method to be called through a derived class reference.

## **Method overloading**

Method overloading is a feature in object-oriented programming that allows multiple methods to have the same name, but with different parameters. When a method is called, the compiler determines which version of the method to call based on the number, types, and order of the arguments passed in.

Method overloading is useful when you want to provide different ways to perform a similar operation based on the different types of input arguments that may be passed in. It allows for more concise and readable code by providing a single method name for a variety of related operations.

**Here's an example in C# that demonstrates method overloading:**

```
class Calculator
{
    public int Add(int num1, int num2)
    {
        return num1 + num2;
    }

    public int Add(int num1, int num2, int num3)
    {
        return num1 + num2 + num3;
    }

    public double Add(double num1, double num2)
    {
        return num1 + num2;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Calculator calc = new Calculator();
        int result1 = calc.Add(5, 10); // result1 = 15
        int result2 = calc.Add(5, 10, 15); // result2 = 30
        double result3 = calc.Add(1.5, 2.5); // result3 = 4.0
    }
}

```

In this example, the `Calculator` class has three different methods named `Add`, but with different parameter lists. The first method takes two integers and returns an integer, the second method takes three integers and returns an integer, and the third method takes two doubles and returns a double.

In the `Main` method, we create an instance of `Calculator` and call each version of the `Add` method with different arguments. The appropriate method is called based on the number and types of arguments passed in, and the corresponding result is returned.

## **Why Properties**

Marking the class fields public and exposing to the external world is bad, as you will not have control over what gets assigned and returned.

```
public class Student
{
public int IO;
public string Name;
public int PassMark;
}
public class Program
{
public static void Main()
{
Student C1 = new Student();
C1.ID = 401; Q
C1.Name = null;
C1.PassMark - -100;
Console.writeLine("ID = {0} 8 Name = {1} 8 PassHark = {2}",
C1.ID, C1.Name, C1.PassMark);
}
}
```

**Problems with Public Fields**

1. ID should always be non negative number

2. Name cannot be set to NULL

3. If Student Name is missing "No Name" shodd be returned

4. PassMark should be read only

**We use Getter and Setter Methods**

```
public class Student
{
private int _id;
public string _name;
public int _passHark;

public void SetId(int Id)
{
    if (Id <- 0)
    {
    throw new Exception("Student Id should be greater than zero");
    }
    this._id - Id;
}
public int GetId()
{
return _id;
}
}

public class Program
{
    public static void Main()
    {
    Student C1 - new Student();
    C1.SetId(101);
    Console.writeLine('Student Id - {0}", C1.GetId());
    }
}
```

In this example we use the Setld(int Id) and Getld() methods to encapsulate \_id class field.

As a result, we have better control on what gets assigied and returned from the \_id field.

> Note: Encapsulation is one of the primary pillars of object oriented programming.

## **Properties**

Properties in C# are a mechanism for encapsulating the state of an object and controlling access to its private fields. They provide a clean and concise syntax for getting and setting the values of private fields, and allow for data validation and other logic to be performed when a property is accessed or modified.

In C#, properties are declared using a special syntax that consists of a getter and/or a setter method, which are used to retrieve and modify the value of the property, respectively. Here's an example:

```
class Person
{
    private string name;
    private int age;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Age
    {
        get { return age; }
        set { age = value; }
    }
}

```

In this example, the **Person** class has two private fields, **name** and **age**, which are exposed through public properties with the same names. The **Name** and **Age** properties allow external code to get and set the values of the private fields, while providing encapsulation and data validation.

The **get** and **set** keywords are used to define the getter and setter methods for a property, respectively. The **get** method is used to retrieve the value of the property, while the **set** method is used to modify the value of the property. The value keyword is used inside the setter method to refer to the value being assigned to the property.

**You can also use auto-implemented properties in C#, which allow you to declare a property without explicitly defining a backing field. Here's an example:**

```
class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}
```

In this example, the **Person** class has two auto-implemented properties, **Name** and **Age**, which automatically generate a backing field for the property. The **get** and **set** methods are automatically implemented by the compiler.

Auto-implemented properties are useful when you don't need to perform any additional logic when getting or setting the value of a property. However, if you need to perform additional logic, you should use the standard property syntax with explicit getter and/or setter methods.

## **Structs**

In C#, a struct is a value type that represents a lightweight object that can contain data members and methods. Structs are similar to classes in that they can have fields, properties, and methods, but there are some important differences between the two.

**Here are some key characteristics of structs in C#:**

1. Value type: Structs are value types, which means that they are copied when passed as arguments to methods or assigned to variables. This is in contrast to classes, which are reference types, and are passed by reference.

2. Stack allocated: Structs are allocated on the stack, while objects are allocated on the heap. This makes structs more lightweight and efficient than objects, especially for small, frequently used data structures.

3. Immutable by default: Structs are immutable by default, which means that their fields cannot be modified after they are initialized. If you need to modify a struct, you must create a new instance of the struct with the updated values.

4. No default constructor: Structs do not have a default constructor like classes do. Instead, you must initialize all of the fields of a struct when you create a new instance of it.

**Here's an example of how to define and use a struct in C#:**

```
public struct Rectangle
{
    public int Width;
    public int Height;

    public Rectangle(int width, int height)
    {
        Width = width;
        Height = height;
    }

    public int Area()
    {
        return Width * Height;
    }
}

...

Rectangle rect = new Rectangle(10, 20);
Console.WriteLine("Width: {0}, Height: {1}, Area: {2}", rect.Width, rect.Height, rect.Area());
```

In this example, the `Rectangle` struct represents a rectangle with a given `Width` and `Height`. The `Rectangle` struct has a constructor that initializes the `Width` and `Height` fields, as well as an `Area` method that calculates the area of the rectangle.

When you create a new instance of the `Rectangle` struct, you must provide values for the `Width` and `Height` fields in the constructor. The `Area` method calculates the area of the rectangle based on the `Width` and `Height` fields of the struct.

The 'rect' variable holds an instance of the 'Rectangle' struct with a width of '10' and a height of '20'. The 'Console.WriteLine' statement outputs the `Width`, `Height`, and `Area` of the `rect` variable to the console. The output of the program would be:

```
Width: 10, Height: 20, Area: 200
```

## **Classes Vs Structs**

In C#, classes and structs are two different ways of defining custom types. Both classes and structs can have fields, properties, methods, and constructors, but there are some important differences between the two.

**Here are some key differences between classes and structs in C#:**

1. Reference type vs value type: Classes are reference types, which means that instances of a class are allocated on the heap and passed by reference, while structs are value types, which means that instances of a struct are allocated on the stack and passed by value.

2. Inheritance: Classes support inheritance, which allows you to create a new class that is a modified version of an existing class. Structs do not support inheritance.

3. Default constructor: Classes have a default constructor that is generated automatically if you do not define any constructors. Structs do not have a default constructor, and you must define one yourself if you want to create instances of a struct without providing any arguments.

4. Performance: Structs are generally faster and more memory-efficient than classes for small data structures, because they are allocated on the stack and do not require the overhead of heap allocation and garbage collection.

**Here's an example of a class in C#:**

```

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public void PrintDetails()
    {
        Console.WriteLine("Name: {0}, Age: {1}", Name, Age);
    }
}

...

Person p = new Person("John", 30);
p.PrintDetails();
```

In this example, the `Person` class represents a person with a given name and age. The `Person` class has a constructor that initializes the `Name` and `Age` properties, as well as a `PrintDetails` method that outputs the `Name` and `Age` properties to the console.

**Here's an example of a struct in C#:**

```
public struct Point
{
    public int X { get; set; }
    public int Y { get; set; }

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    public void Move(int deltaX, int deltaY)
    {
        X += deltaX;
        Y += deltaY;
    }
}

...

Point p = new Point(10, 20);
p.Move(5, 5);
Console.WriteLine("X: {0}, Y: {1}", p.X, p.Y);

```

In this example, the `Point` struct represents a point in two-dimensional space, with `X` and `Y` coordinates. The `Point` struct has a constructor that initializes the `X` and `Y` properties, as well as a `Move` method that updates the `X` and `Y` properties with a given delta value.

When you create a new instance of the `Point` struct, you must provide values for the `X` and `Y` properties in the constructor. The `Move` method updates the `X` and `Y` properties of the `p` struct.

## **Interfaces**

* An interface in C# functions as a contractual blueprint, delineating a collection of methods, properties, and events that a class or struct must adhere to by supplying implementations.
* Using the interface keyword, interfaces are crafted with declarations of members but without any implementations.
* Implementing any interface member leads to a compile-time error.
* Interface members are inherently public and cannot possess explicit access modifiers.
* Interfaces are incapable of containing fields.
* When a class or struct inherits from an interface, it must furnish implementations for all interface members, otherwise, a compiler error ensues.
* Although a class or struct can inherit from multiple interfaces concurrently, it cannot inherit from more than one class simultaneously.
* Interfaces have the capability to inherit from other interfaces, mandating implementations for all interface members throughout the entire inheritance chain.
* Instantiating an interface is impossible; however, an interface reference variable can point to an object derived from a class implementing that interface.

**Here's an example of an interface in C#:**

```

public interface IShape
{
    double GetArea();
}

public class Circle : IShape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public double GetArea()
    {
        return Math.PI * Radius * Radius;
    }
}

public class Rectangle : IShape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public double GetArea()
    {
        return Width * Height;
    }
}

...

IShape shape1 = new Circle(5);
IShape shape2 = new Rectangle(10, 20);
Console.WriteLine("Area of shape1: {0}", shape1.GetArea());
Console.WriteLine("Area of shape2: {0}", shape2.GetArea());
```

In this example, the `IShape` interface defines a single method `GetArea` that must be implemented by any class or struct that implements the `IShape` interface.

* The `Circle` class and `Rectangle` class both implement the `IShape` interface and provide their own implementation of the `GetArea` method.

* The `Circle` class has a `Radius` property and calculates the area of a circle based on the `Radius` property.

* The `Rectangle` class has `Width` and `Height` properties and calculates the area of a rectangle based on the `Width` and `Height` properties.

* The `shape1` and `shape2` variables are both of type `IShape` and hold instances of `Circle` and `Rectangle`, respectively. The `GetArea` method of each instance is called and outputs the area of the shape to the console.

Interfaces are commonly used in C# to define a common behavior that multiple classes or structs can implement, which enables polymorphism and helps promote code reusability.

## **Explicit interface implementation**

Explicit interface implementation allows a class to implement interface methods explicitly. This means that the methods of the interface are only accessible through a reference to the interface.

Explicit interface implementation is achieved by specifying the interface name followed by a dot and then the method name in the class definition. Here's an example:

```
interface IMyInterface
{
    void MyMethod();
}

class MyClass1 : IMyInterface
{
    void IMyInterface.MyMethod()
    {
        Console.WriteLine("Implementation of MyMethod in MyClass1");
    }
}
```

In this example, the class `MyClass` implements the interface `IMyInterface` using explicit interface implementation. The `MyMethod` method is defined with the interface name followed by a dot, which specifies that it's an explicit interface implementation.

To use the `MyMethod` method from an instance of `MyClass`, you would need to cast the instance to `IMyInterface`. Here's an example:

```
MyClass1 myClass1 = new MyClass1();
((IMyInterface)myClass1).MyMethod(); // Call MyMethod through the interface
```

In this example, we create an instance of `MyClass` and then cast it to `IMyInterface` to access the `MyMethod` method.

Explicit interface implementation is often used to avoid naming conflicts when a class implements multiple interfaces with methods that have the same name.

## **Abstract Classes**

An abstract class is a class that cannot be instantiated directly. Instead, it serves as a blueprint for derived classes that can be instantiated. An abstract class is declared using the `abstract` keyword.

Abstract classes may contain abstract members, such as methods, properties, or indexers, that do not provide an implementation in the abstract class. Instead, these members must be implemented in the derived classes. The `abstract` keyword is used to declare abstract members.

**Here's an example of an abstract class:**

```
abstract class Shape
{
    public abstract double Area { get; }
    public abstract double Perimeter { get; }
}

class Rectangle : Shape
{
    private double length;
    private double width;

    public Rectangle(double length, double width)
    {
        this.length = length;
        this.width = width;
    }

    public override double Area
    {
        get { return length * width; }
    }

    public override double Perimeter
    {
        get { return 2 * (length + width); }
    }
}
```

* In this example, `Shape` is an abstract class that defines two abstract members: `Area` and `Perimeter`. These members do not have an implementation in the `Shape` class. Instead, they must be implemented in derived classes.

* The `Rectangle` class is derived from the `Shape` class. It provides an implementation for the `Area` and `Perimeter` members, which were declared as abstract in the `Shape` class. Note that the `override` keyword is used to indicate that the `Rectangle` class is providing an implementation for the abstract members.

Abstract classes can be useful for creating hierarchies of related classes. By defining a set of abstract members in an abstract base class, you can ensure that derived classes provide implementations for those members. This can help to create a more consistent and maintainable class hierarchy.

**To summarize:**

* The abstract keyword is used to create abstract classes.
* An abstract class is incomplete and hence cannot be instantiated.
* An abstract class can only be used as base class.
* An abstract class cannot be sealed.
* An abstract class may contain abstract members(methods, properties, indexers, and events), but not mandatory.
* A non-abstract class derived from an abstract class must provide implementations for all inherited abstract members-
* If a class inherits an abstract class, there are 2 options available for that class

**Option 1:** Provide Implementation for all the abstract members inherited from the base abstract class.

**Option 2:** If the class does not wish to provide Implementation for all the abstract members inherited from the abstract class, then the class has to be marked as abstract.

## **Abstract Classes Vs Interfaces**

An abstract class is a class that cannot be instantiated directly and can contain both abstract and non-abstract members. It is typically used to define a base class that provides common functionality to derived classes. Derived classes must implement the abstract members, while non-abstract members can be inherited or overridden. An abstract class can have fields, constructors, and non-abstract methods, and it can provide default implementations for some of its methods.

On the other hand, an interface is a contract that specifies a set of members that a class must implement. It is used to define a set of behaviors or capabilities that a class must have. An interface contains only method and property signatures, and no implementation details. A class can implement multiple interfaces, but it cannot inherit from multiple classes.

**Here are some of the key differences between abstract classes and interfaces in C#:**

* Instantiation: An abstract class cannot be instantiated directly, whereas an interface cannot be instantiated at all.
* Members: An abstract class can contain both abstract and non-abstract members, whereas an interface can only contain method and property signatures.
* Inheritance: A class can inherit from one abstract class, whereas it can implement multiple interfaces.
* Access Modifiers: An abstract class can have access modifiers on its members, whereas an interface's members are always public.

Default Implementation: An abstract class can provide a default implementation for some of its methods, whereas an interface cannot provide any implementation at all.

**Here is a simple example with Interface and an Abstract Class**

```
// Abstract class
public abstract class Animal
{
    public abstract void MakeSound();

    public void Eat()
    {
        Console.WriteLine("The animal is eating.");
    }
}

// Interface
public interface ICanJump
{
    void Jump();
}

// Derived class that inherits from Animal and implements ICanJump
public class Kangaroo : Animal, ICanJump
{
    public override void MakeSound()
    {
        Console.WriteLine("The kangaroo makes a sound.");
    }

    public void Jump()
    {
        Console.WriteLine("The kangaroo jumps.");
    }
}

```

In this example, we have an abstract class 'Animal' that defines an abstract method `MakeSound()` and a non-abstract method `Eat()`. The Animal class cannot be instantiated directly, and must be inherited by a derived class that provides an implementation for the abstract method.

We also have an interface `ICanJump` that defines a method '`Jump()`'. This interface is implemented by the derived class `Kangaroo`.

The `Kangaroo` class inherits from `Animal` and implements `ICanJump`. It provides an implementation for the `MakeSound()` method and the `Jump()` method.

We can use this code to create instances of the `Kangaroo` class and call its methods:

```
Kangaroo kangaroo = new Kangaroo();
kangaroo.MakeSound();  // Output: The kangaroo makes a sound.
kangaroo.Jump();       // Output: The kangaroo jumps.
kangaroo.Eat();        // Output: The animal is eating.
```

As you can see, the `Kangaroo` class inherits the 'Eat()' method from the 'Animal' class, and implements the 'Jump()' method from the 'ICanJump' interface. This is an example of how abstract classes and interfaces can be used together to provide a flexible and extensible design.

## **Diamond Problem**

The diamond problem is a common issue that can occur when a programming language allows multiple class inheritance. It arises when a derived class inherits from two or more base classes that have a common ancestor. The problem is called the "diamond problem" because the inheritance diagram looks like a diamond shape.

**Here is an example of the diamond problem in C#:**

```
using System;

class A
{
    public virtual void Foo() { Console.WriteLine("A.Foo()"); }
}

class B : A
{
    public override void Foo() { Console.WriteLine("B.Foo()"); }
}

class C : A
{
    public override void Foo() { Console.WriteLine("C.Foo()"); }
}

class D : B, C
{
}

class CS32_DiamondProblem
{
   public static void Main()
    {
        D d = new D();
        d.Foo();
    }
}
```

In this example, we have four classes **A**, **B**,**C** and **D**,**B** and **C** inherit from **A**, and **D** inherits from both **B** and **C**. **A** has a method **Foo()**, and both **B** and **C** override this method. Now, when we create an instance of **D** and call its **Foo()** method, which implementation of **Foo()** should be used? The answer is not clear because **D** inherits from both **B** and **C**, and both **B** and **C** provide an implementation of **Foo()**.

This ambiguity in multiple inheritance is the diamond problem. It can cause confusion and make the code difficult to understand and maintain. To avoid this problem, some programming languages like C# do not allow multiple class inheritance. Instead, they provide an alternative mechanism called interfaces, which allows a class to inherit from multiple interfaces but only one base class. Interfaces provide a way to specify a set of behaviors that a class must implement, without defining any implementation details. This helps to avoid the diamond problem and provide a more flexible and maintainable design.

## **Multiple inheritance**

C# does not support multiple class inheritance, meaning a class can only inherit from one base class at a time. This is to avoid the diamond problem and to promote a simpler and more maintainable code structure. However, C# does provide a way to simulate multiple inheritance using interfaces and composition.

**Here's an example of how to use inheritance and composition to achieve the functionality of multiple class inheritance in C#:**

```
interface IAnimal
{
    void Eat();
}

class Animal : IAnimal
{
    public void Eat()
    {
        Console.WriteLine("The animal is eating.");
    }
}

interface ICanFly
{
    void Fly();
}

class Bird : ICanFly
{
    public void Fly()
    {
        Console.WriteLine("The bird is flying.");
    }
}

class Pegasus : IAnimal, ICanFly
{
    private Animal animal = new Animal();
    private Bird bird = new Bird();

    public void Eat()
    {
        animal.Eat();
    }

    public void Fly()
    {
        bird.Fly();
    }
}
```

In this example, we define two interfaces `IAnimal` and `ICanFly`, and two classes `Animal` and `Bird` that implement these interfaces. We also define a new class `Pegasus` that needs to inherit from both `Animal` and `Bird`. However, since C# does not support multiple inheritance, we instead use composition to achieve the desired functionality.

The `Pegasus` class has two private fields of type `Animal` and `Bird`, and it implements the `IAnimal` and `ICanFly` interfaces. It provides implementations for the `Eat()` and `Fly()` methods by delegating the calls to the corresponding methods of the `Animal` and `Bird` objects.

Now, we can create an instance of the 'Pegasus' class and call its `Eat()` and `Fly()` methods:

```
Pegasus pegasus = new Pegasus();
pegasus.Eat();  // Output: The animal is eating.
pegasus.Fly();  // Output: The bird is flying.
```

As you can see, we were able to simulate multiple class inheritance by using interfaces and composition. This approach allows us to achieve the desired functionality while avoiding the problems of multiple inheritance, such as the diamond problem.

## **Delegates**

A delegate is a type that represents references to methods with a particular signature. It allows you to treat methods as first-class objects, meaning you can pass methods as parameters to other methods, store them in variables, and invoke them later.

Delegates are useful when you want to define a contract or a callback mechanism for methods. They provide a way to decouple the calling code from the implementation of the method being called. By using delegates, you can write generic code that can work with any method that matches the delegate's signature.

**Example Program**

```
using System;


// Delegate Declaration.
public delegate void HelloFunctionDelegate(string Message);


class Pragim
{
    public static void Main()
    {
        // Create the instance of the delegate and pass in the function
        // name as the parameter to the constructor. The passed in
        // function signature must match the signature of the delegate
        HelloFunctionDelegate del = new HelloFunctionDelegate(Hello);
        // Invoke the delegate, which will invoke the method
        del("Hello from Delegte");
    }


    public static void Hello(string strMessge)
    {
        Console.WriteLine(strMessge);
    }
}
```

**To summarize**

A `delegate` is a type safe function pointer.That is, they hold reference(Pointer) to a function.

The `signature` of the delegate `must match` the signature of the function, the delegate points to, otherwise you get a compiler error. This is the reason delegates are called as type safe function pointers.

A Delegate is similar to a class. You can create an instance of it, and when you do so, you pass in the function name as a parameter to the delegate constructor, and it is to this function the delegate will point to.

`**Tip to remember delegate syntax**` Delegates syntax look very much similar to a method with a delegate keyword.

## **Delegates Example I**

Let's consider a simple example where we have a program that calculates the square and cube of a given number. We'll start without using delegates and then enhance it by adding delegates.

**Example without using delegates:**

```
using System;

class Program
{
    static void Main()
    {
        int number = 5;

        CalculateSquare(number);
        CalculateCube(number);
    }

    static void CalculateSquare(int number)
    {
        int square = number * number;
        Console.WriteLine($"Square of {number} is: {square}");
    }

    static void CalculateCube(int number)
    {
        int cube = number * number * number;
        Console.WriteLine($"Cube of {number} is: {cube}");
    }
}

```

In the above program, we have two separate methods, `CalculateSquare` and `CalculateCube`, that perform the calculations. This approach works fine, but what if we want to perform additional calculations or modify the behavior of the calculations at runtime?

**Now let's enhance the program by using delegates:**

```
using System;

delegate int Calculation(int number);

class Program
{
    static void Main()
    {
        int number = 5;

        Calculation squareCalculation = Square;
        Calculation cubeCalculation = Cube;

        PerformCalculation(number, squareCalculation);
        PerformCalculation(number, cubeCalculation);
    }

    static void PerformCalculation(int number, Calculation calculation)
    {
        int result = calculation(number);
        Console.WriteLine($"Result: {result}");
    }

    static int Square(int number)
    {
        return number * number;
    }

    static int Cube(int number)
    {
        return number * number * number;
    }
}

```

In this enhanced version, we define a delegate type called `Calculation` that represents methods taking an integer as a parameter and returning an integer. We then create delegate instances `squareCalculation` and `cubeCalculation` that point to the `Square` and `Cube` methods, respectively.

The `PerformCalculation` method takes a `Calculation` delegate as a parameter and invokes it, providing the desired behavior. By using delegates, we can now pass different calculation methods to `PerformCalculation` without modifying its implementation, making it more flexible and extensible.

This example demonstrates how delegates allow us to encapsulate different behaviors into separate methods and easily switch between them based on our requirements.

## **Multicast Delegates**

Multicast delegates in C# are delegates that can hold references to multiple methods, allowing you to invoke multiple methods with a single delegate invocation. They provide a way to combine multiple methods into a single delegate, and when invoked, all the referenced methods are called in the order they were added.

To define a multicast delegate, you need to use the `delegate` keyword and specify the delegate signature.

**Here's an example:**

```
delegate void MyDelegate(string message);
```

In this example, `MyDelegate` is a delegate type that represents methods taking a string parameter and returning void.

To create a multicast delegate, you can use the += operator to combine multiple methods:

```
void Method1(string message)
{
    Console.WriteLine("Method 1: " + message);
}

void Method2(string message)
{
    Console.WriteLine("Method 2: " + message);
}

// Creating a multicast delegate instance
MyDelegate multicastDelegate = Method1;
multicastDelegate += Method2;
```

In the above code, we create a multicast delegate instance `multicastDelegate`' and combine two methods `Method1` and `Method2` using the `+=` operator.

When invoking a multicast delegate, all the referenced methods are called in the order they were added:

```
multicastDelegate("Hello, delegates!");
```

**Output**

```
Method 1: Hello, delegates!
Method 2: Hello, delegates!

```

As you can see, both `Method1` and `Method2` are invoked, and they each receive the same argument.

**You can also use the `-=` operator to remove methods from a multicast delegate:**

```
multicastDelegate -= Method2;
```

After removing `Method2` from the delegate, invoking it will only call `Method1`.

It's important to note that when invoking a multicast delegate, if any of the referenced methods throw an exception, the exception is propagated back to the caller, and the subsequent methods in the delegate invocation will not be executed.

Multicast delegates are commonly used in scenarios where you want to notify multiple event handlers or implement a publish-subscribe mechanism, where multiple subscribers need to be notified of an event.

## **Exception Handling**

Exception handling in C# allows you to catch and handle runtime errors, or exceptions, that occur during the execution of your program. It helps you gracefully handle exceptional situations and prevent your program from crashing.

In C#, exceptions are represented by classes derived from the `System.Exception` base class. The most common way to handle exceptions is by using try-catch blocks.

**Examples:**

Trying to read from a file that does not exist, throws `FileNotFoundException`.
Trying to read from a database table that does not exist, throws a `SqlException`.

**Here's the basic structure of a try-catch block:**

```
try
{
    // Code that may throw an exception
}
catch (ExceptionType1 ex)
{
    // Code to handle exceptions of type ExceptionType1
}
catch (ExceptionType2 ex)
{
    // Code to handle exceptions of type ExceptionType2
}
// Add more catch blocks as needed
finally
{
    // Optional: Code that always executes, regardless of whether an exception occurred or not
}
```

**Here's how exception handling works:**

1. The code inside the try block is executed.
2. If an exception occurs during the execution of the try block, the execution is immediately transferred to the catch block that matches the type of the thrown exception.
3. The catch block handles the exception by executing the specified code. You can access the exception object (typically named ex) to obtain information about the exception, such as the error message or stack trace.
4. If multiple catch blocks are present, the catch blocks are evaluated in order, and only the first catch block that matches the exception type is executed. Subsequent catch blocks are skipped.
5. After the catch block(s) are executed, the program continues execution after the catch block(s) or the finally block (if present).
6. The finally block, if specified, is optional and is executed regardless of whether an exception occurred or not. It is commonly used to perform cleanup operations or release resources.

**Here's an example that demonstrates exception handling:**

```
try
{
    int numerator = 10;
    int denominator = 0;
    int result = numerator / denominator; // Division by zero, will throw an exception
    Console.WriteLine("Result: " + result); // This line will not be reached
}
catch (DivideByZeroException ex)
{
    Console.WriteLine("Error: " + ex.Message);
}
finally
{
    Console.WriteLine("Cleanup operations");
}
```

In this example, a `DivideByZeroException`is thrown because we are attempting to divide by zero. The catch block for `DivideByZeroException` catches the exception and displays an error message. The finally block is executed afterwards, regardless of the exception.

Exception handling allows you to gracefully handle exceptional situations and provides an opportunity to recover from errors or perform necessary cleanup operations. It is essential for writing robust and reliable code.

## **Inner Exceptions**

In C#, an inner exception is an exception that is nested within another exception. It allows you to provide more detailed information about the cause of an exception by preserving the original exception that triggered the current exception.

When an exception is thrown, you can pass the original exception as an argument to the constructor of the new exception, creating a chain of exceptions. The original exception becomes the inner exception of the new exception. This nesting of exceptions can continue, creating a hierarchy of inner exceptions.

**Here's an example that demonstrates the usage of inner exceptions:**

```
try
{
    try
    {
        // Some code that may throw an exception
        throw new ArgumentException("Invalid argument");
    }
    catch (Exception ex)
    {
        // Wrap the caught exception with a new exception
        throw new InvalidOperationException("Operation failed", ex);
    }
}
catch (Exception ex)
{
    // Display the exception details, including inner exceptions
    Console.WriteLine("Exception: " + ex.Message);
    Console.WriteLine("Inner Exception: " + ex.InnerException?.Message);
}
```

In this example, the inner exception is created by passing the caught `ArgumentException` as an argument to the constructor of the `InvalidOperationException`. The `InvalidOperationException` becomes the new exception, with the `ArgumentException` nested inside it as the inner exception.

When the outermost exception is caught, you can access the inner exception using the `InnerException` property. You can retrieve the message, stack trace, or any other information from the inner exception to gain insight into the cause of the exception.

**The output of the above example will be:**

```
Exception: Operation failed
Inner Exception: Invalid argument
```

By using inner exceptions, you can provide a more complete picture of what went wrong in your program, making it easier to debug and understand the root cause of the exception. It is especially useful when exceptions occur in different layers or components of your application, allowing you to propagate the original exception while providing additional context at each level.

## **Custom Exceptions**

In C#, you can define your own custom exceptions by creating classes that derive from the `System.Exception` class or one of its derived classes. Custom exceptions allow you to encapsulate specific error conditions or exceptional situations that are meaningful in your application domain.

To create a custom exception, you typically create a new class that inherits from `Exception` or one of its subclasses, such as `ApplicationException`.

**Here's an example:**

```
using System;

public class CustomException : Exception
{
    public CustomException()
    {
    }

    public CustomException(string message)
        : base(message)
    {
    }

    public CustomException(string message, Exception innerException)
        : base(message, innerException)
    {
    }
}
```

In the above example, we define a `CustomException` class that extends the `Exception` class. It provides three constructors: a parameterless constructor, a constructor that accepts a message, and a constructor that accepts a message and an inner exception.

**You can then use your custom exception like any other exception:**

```
try
{
    // Some code that may throw a custom exception
    throw new CustomException("Custom exception occurred");
}
catch (CustomException ex)
{
    // Handle the custom exception
    Console.WriteLine("Custom Exception: " + ex.Message);
}
catch (Exception ex)
{
    // Handle other exceptions
    Console.WriteLine("Exception: " + ex.Message);
}
```

In this example, we throw a `CustomException` with a specific message. The catch block for `CustomException` is responsible for handling the custom `exception`, while the catch block for Exception (the base class) can handle any other exceptions that may occur.

When creating custom exceptions, it's a good practice to provide meaningful constructors and properties that allow you to pass relevant information about the exception. You can also add additional properties or methods to your custom exception class to provide more context or behavior specific to your application's needs.

Custom exceptions help make your code more expressive and provide a way to differentiate between different types of exceptional conditions in your application. They also allow you to catch and handle specific exceptions or propagate them up the call stack for centralized error handling.

## **Exception Handling Abuse**

Exception handling abuse refers to the improper or excessive use of exceptions in a codebase, leading to poor performance, code complexity, and reduced maintainability. It occurs when exceptions are misused as a control flow mechanism or when they are used inappropriately for non-exceptional situations.

**Here are some examples of exception handling abuse:**

1. Using exceptions for regular program flow: Exceptions should be reserved for exceptional situations, such as errors or unexpected conditions. Abusing exceptions by using them as a normal flow control mechanism can lead to slower performance, as exception handling has an overhead, and can make the code harder to understand and maintain.

2. Catching and swallowing exceptions: Catching exceptions without properly handling or logging them can hide underlying issues and make it difficult to diagnose and debug problems. It is important to handle exceptions appropriately, which may involve logging the exception, providing user feedback, or taking corrective actions.

3. Using exceptions for expected conditions: Exceptions should not be used to handle expected or predictable situations. For example, if a method expects invalid input, it is better to use appropriate validation techniques or return specific error codes rather than relying on exceptions to handle these cases.

4. Overly granular exception handling: Having numerous, fine-grained catch blocks for individual exception types can make the code cluttered and harder to read. It is generally more effective to have broader catch blocks that handle related exceptions together, while still providing meaningful error handling or logging.

5. Performance impact of exceptions: Exception handling has a performance cost compared to regular code execution. When exceptions are used excessively in performance-critical sections of the code, it can impact the overall performance of the application. In such cases, it may be more efficient to use alternative error-handling mechanisms or to validate inputs and conditions proactively to avoid exceptions.

**To avoid exception handling abuse, it is important to follow best practices in exception handling:**

- Use exceptions for exceptional cases only.
- Handle exceptions at an appropriate level in the code, providing meaningful error handling or logging.
- Design the code to minimize the occurrence of exceptions by validating inputs and conditions before executing critical code sections.
- Consider performance implications when using exceptions in performance-sensitive areas.
- Use appropriate logging mechanisms to capture exception details for troubleshooting and debugging purposes.
- By adhering to these best practices, you can ensure that exceptions are used effectively and appropriately in your codebase, promoting maintainability, performance, and code clarity.

### **Examples**

Here's an example that demonstrates both proper exception handling and exception handling abuse:

```
try
{
    // Proper exception handling
    int dividend = 10;
    int divisor = 0;

    if (divisor == 0)
    {
        throw new ArgumentException("Divisor cannot be zero.");
    }

    int result = dividend / divisor;
    Console.WriteLine("Result: " + result);
}
catch (ArgumentException ex)
{
    // Properly handle the specific exception
    Console.WriteLine("ArgumentException: " + ex.Message);
}
catch (Exception ex)
{
    // Handle other exceptions
    Console.WriteLine("Exception: " + ex.Message);
}
finally
{
    // Perform cleanup operations
    Console.WriteLine("Cleanup operations");
}

try
{
    // Exception handling abuse
    int[] numbers = { 1, 2, 3 };
    for (int i = 0; i <= numbers.Length; i++)
    {
        try
        {
            int value = numbers[i];
            Console.WriteLine("Value: " + value);
        }
        catch (IndexOutOfRangeException)
        {
            // Swallow the exception and continue the loop
        }
    }
}
catch (Exception ex)
{
    // Handle other exceptions
    Console.WriteLine("Exception: " + ex.Message);
}
finally
{
    // Perform cleanup operations
    Console.WriteLine("Cleanup operations");
}

```

In the first part, we demonstrate proper exception handling. We check if the divisor is zero and throw an `ArgumentException` if it is. This represents a known error condition, and we handle it specifically in the catch block for `ArgumentException`. The catch block displays a meaningful error message.

In the second part, we demonstrate exception handling abuse. We have an array of numbers, and in the loop, we access elements beyond the array length, causing an `IndexOutOfRangeException`. However, instead of properly handling the exception or logging it, we catch the exception and do nothing `(// Swallow the exception and continue the loop)`. This hides the underlying issue and can lead to difficult-to-detect bugs.

Both examples include a `finally` block, which executes cleanup operations regardless of whether an exception occurred or not. It is good practice to use the `finally` block to release resources and ensure proper cleanup.

Remember, it's important to use exceptions for exceptional cases and handle them appropriately. Avoid using exceptions for regular program flow, and ensure that exceptions are not swallowed or ignored without proper handling or logging.

## **Why Enums**

Enums in C# (short for "enumerations") are a type that allows you to define a set of named integral constants. Enums provide a convenient way to work with a fixed set of related values, making your code more readable, maintainable, and type-safe.

To define an enum in C#, you use the `enum` keyword followed by the name of the enum and the list of named constants enclosed in curly braces. Each named constant represents a unique value within the enum.

**Here's the syntax for defining an enum:**

```
enum DaysOfWeek
{
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
}

```

In this example, we define an enum called DaysOfWeek that represents the days of the week. The enum contains named constants for each day.

You can use the enum in your code by referencing the enum type and accessing its named constants.

**For Example**

```
DaysOfWeek today = DaysOfWeek.Monday;
Console.WriteLine("Today is " + today);

```

In this code snippet, we declare a variable `today` of type `DaysOfWeek` and assign it the value `DaysOfWeek.Monday`. We then display the value of today, which outputs "Today is Monday".

Enums are treated as value types, and their underlying type is `int` by default. However, you can specify a different integral type explicitly if needed. For example:

```
enum Colors : byte
{
    Red,
    Green,
    Blue
}

```

In this example, we specify `byte` as the underlying type for the `Colors` enum, so each named constant within the enum will have a corresponding `byte` value.

Enums in C# also provide useful features, such as converting enum values to and from their underlying type, checking if a value exists in the enum, and iterating over all the values of an enum. These features make it easier to work with enum values in your code.

Enums are commonly used in scenarios where you need to represent a fixed set of options or choices, such as days of the week, colors, status codes, or any other discrete set of values. They help improve code readability, enforce type safety, and make your code more self-explanatory.

## **Enums Example**

**Here's an example that demonstrates the usage of enums in C#:**

```
using System;

enum DaysOfWeek
{
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
}

class Program
{
    static void Main()
    {
        // Using enum in code
        DaysOfWeek today = DaysOfWeek.Monday;
        Console.WriteLine("Today is " + today);

        // Enum comparison
        if (today == DaysOfWeek.Saturday || today == DaysOfWeek.Sunday)
        {
            Console.WriteLine("It's the weekend!");
        }
        else
        {
            Console.WriteLine("It's a weekday.");
        }

        // Enum iteration
        Console.WriteLine("All days of the week:");
        foreach (DaysOfWeek day in Enum.GetValues(typeof(DaysOfWeek)))
        {
            Console.WriteLine(day);
        }
    }
}

```

In this example, we define an enum called DaysOfWeek that represents the days of the week. We then use the enum in our code:

1. We declare a variable `today` of type `DaysOfWeek` and assign it the value `DaysOfWeek.Monday`. We display the value of `today`, which outputs "Today is Monday".

2. We perform an enum comparison to check if `today` is either `DaysOfWeek.Saturday` or `DaysOfWeek.Sunday`. Based on the result, we display whether it's the weekend or a weekday.

3. We demonstrate enum iteration by using `Enum.GetValues(typeof(DaysOfWeek))` to get an array of all the values of the `DaysOfWeek` enum. We then iterate over the array and display all the days of the week.

**The output of this example will be:**

```
Today is Monday
It's a weekday.
All days of the week:
Monday
Tuesday
Wednesday
Thursday
Friday
Saturday
Sunday

```

This example illustrates how enums can be used to represent a fixed set of options (days of the week) and how they can be accessed, compared, and iterated over in your code. Enums provide a convenient way to work with related constants and enhance the readability and maintainability of your code.

## **Enums Concepts**

If a program uses set of integral numbers, consider replacing them with enums, which makes the program more Readable Maintainable .

1. Enums are enumerations.
2. Enums are strongly typed constants. Hence, an explicit cast is needed to convert from enum type to an integral type and vice versa. Also, an enum of one type cannot be implicitly assigned to an enum of another type even though the underlying value of their members are the same.
3. The default underlying type of an enum is int.
4. The default value for first element is ZERO and gets incremented by 1.
5. It is possible to customize the underlying type and values.
6. Enums are value types.
7. Enum keyowrd (all small letteres) is used to create enumerations, where as Enum class, contains static GetValues() and GetNames() methods which can be used to list Enum underlying type values and Names.

```
// Default underlying type is int and the value starts at ZERO
public enum Gender
{
    Unknown,
    Male,
    Female
}


// Gender enum underlying type is now short and the value starts at ONE
public enum Gender : short
{
    Unknown = 1,
    Male = 2,
    Female = 3
}


// Enum values need not be in sequential order. Any valid underlying type value is allowed
public enum Gender : short
{
    Unknown = 10,
    Male = 22,
    Female = 35
}


// This enum will not compile, bcos the maximum value allowed for short data type is 32767.
public enum Gender : short
{
    Unknown = 10,
    Male = 32768,
    Female = 35
}
```

> **Note:** Use short.MaxValue to find out the maximum value that a short data type can hold
>
> **An explicit cast is needed to convert from enum type to an integral type and vice versa.**

```
int i = Gender.Male;
The above line will not compile. A compiler error will be generated stating:
Cannot implicitly convert type 'Gender' to 'int'. An explicit conversion exists (are you missing a cast?)


Gender female = 2;
The above line will also not compile. A slightly different compiler error will be generated stating
Cannot implicitly convert type 'int' to 'Gender'. An explicit conversion exists (are you missing a cast?)
```

**Enum of one type cannot be implicitly assigned to an enum of another type even though the underlying value of their members are the same. An explicit cast is required as shown below.**

```
using System;
public class Enums
{
    public static void Main()
    {
        // This line will not compile. Cannot implicitly convert type 'Season' to 'Gender'.
        // An explicit conversion is required.
        // Gender gender = Season.Winter;


        // This line comiples as we have an explicit cast
        Gender gender = (Gender)Season.Winter;
    }
}
public enum Gender : int
{
    Unknown = 1,
    Male = 2,
    Female = 3
}
public enum Season : int
{
    Winter = 1,
    Spring = 2,
    Summer = 3
}
```

enum keyowrd (all small letteres) is used to create enumerations, where as Enum class, contains static `GetValues()`
and `GetNames()` methods which can be used to list Enum underlying type values and Names.

**Sample Program listing all enum member values and Names**

```
using System;
public class Enums
{
    public static void Main()
    {
        int[] Values = (int[])Enum.GetValues(typeof(Gender));
        Console.WriteLine("Gender Enum Values");
        foreach (int value in Values)
        {
            Console.WriteLine(value);
        }

        Console.WriteLine();
        string[] Names = Enum.GetNames(typeof(Gender));
        Console.WriteLine("Gender Enum Names");
        foreach (string Name in Names)
        {
            Console.WriteLine(Name);
        }
    }
}
public enum Gender : int
{
    Unknown = 1,
    Male = 2,
    Female = 3
}
```

## **Types v/s Type Members**

A type refers to a class, struct, interface, enum, delegate, or other similar constructs. It represents a blueprint or definition for creating objects or instances of that type. On the other hand, type members are the components or elements that make up a type. They define the characteristics, behavior, and data associated with instances of that type.

**Here are the key differences between types and type members:**

**1. Definition and Scope:**

- Type: A type is the overall construct that defines the blueprint for objects. It represents a category or classification of objects with shared characteristics and behaviors.
- Type Members: Type members are the individual components that belong to a type. They are defined within the context of a type and provide specific functionality or data for instances of that type. Type members can include fields, properties, methods,
  events, constructors, nested types, and more.

**2. Relationship:**

- Type: Types can have relationships with other types, such as inheritance, interface implementation, or composition. They can form hierarchies and participate in polymorphism.
- Type Members: Type members are associated with a specific type and are accessible through instances of that type. They contribute to the overall behavior and state of the objects created from the type.

**3. Accessibility:**

- Type: A type itself can have an accessibility modifier (e.g., public, internal, private), determining its visibility and accessibility from other parts of the code.
- Type Members: Each type member within a type can have its own accessibility modifier, controlling its visibility and accessibility within the type itself or from external code.

**4. Naming:**

- Type: A type is typically named using PascalCase, starting with an uppercase letter (e.g., MyClass, MyStruct, MyInterface).
- Type Members: Type members, such as fields, properties, and methods, are also named using PascalCase, but they usually start with a lowercase letter (e.g., myField, myProperty, myMethod).

In summary, a type in C# represents a category or classification of objects, whereas type members are the individual components that define the behavior and state of instances of that type. Type members are the building blocks of a type, allowing you to define and encapsulate data and functionality within the context of a specific type.

**Here's a small example that demonstrates the difference between a type and its type members:**

```
using System;

// Type: Person
class Person
{
    // Type member: Field
    private string name;

    // Type member: Property
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    // Type member: Method
    public void SayHello()
    {
        Console.WriteLine("Hello, my name is " + name);
    }
}

class Program
{
    static void Main()
    {
        // Creating an instance of the Person type
        Person person = new Person();

        // Accessing the type member 'Name' through the instance
        person.Name = "John Doe";

        // Accessing the type member 'SayHello' through the instance
        person.SayHello();
    }
}

```

* In this example, we have a type called **Person**. It represents a blueprint for creating person objects. The **Person** type has two **type members**: a private field name and a public property **Name**. Additionally, it has a public method **SayHello()**.

* In the **Main** method, we create an instance of the **Person** type using the **new** keyword. We then access the type member **Name** through the instance and assign it the value "John Doe". Next, we invoke the type member SayHello() through the instance, which outputs **"Hello, my name is John Doe"** to the console.

* In this example, **Person** is the type, and **Name** and **SayHello** are the type members that define the behavior and state associated with instances of the **Person** type. Each instance of **Person** will have its own copy of the 'name' field and can access the 'Name' property and **SayHello** method.

* This example demonstrates how the type members contribute to the behavior and functionality of instances created from the type. They encapsulate data (**name** field) and provide ways to interact with that data (**Name** property) and perform specific actions (**SayHello** method).

## **Access Modifiers Private, Public and Protected**

Access modifiers in C# are keywords used to specify the accessibility or visibility of types and members (fields, properties, methods, etc.) within a program. They control which parts of the code can access and interact with a particular type or member.

**C# provides several access modifiers:**

1. **public:** The public access modifier makes the type or member accessible from anywhere in the program, including other classes, assemblies, and namespaces.

2. **private:** The private access modifier restricts the accessibility of a type or member to within the same class or struct. It is the most restrictive access modifier and is typically used to encapsulate implementation details.

3. **protected:** The protected access modifier allows access to the type or member within the same class, derived classes, or classes within the same assembly. It cannot be used with top-level types (classes, structs).

4. **internal:** The internal access modifier limits the accessibility to within the same assembly. It allows types and members to be accessed from any class within the same assembly but not from external assemblies.

5. **protected internal:** The protected internal access modifier combines the accessibility of both protected and internal. It allows access from the same assembly or from derived classes, even if they are in a different assembly.

6. **private protected:** The private protected access modifier is a combination of private and protected and restricts access to derived types within the same assembly.

These access modifiers are used to enforce encapsulation, data hiding, and control the visibility of types and members according to the desired level of abstraction and accessibility in your codebase. By using access modifiers appropriately, you can control how types and members are accessed and manipulated, ensuring proper encapsulation and maintaining the integrity of your code.

**Here's an example that illustrates the use of different access modifiers:**

```
using System;

public class MyClass
{
    public int publicField;
    private string privateField;
    protected bool protectedField;
    internal double internalField;
    protected internal float protectedInternalField;
    private protected decimal privateProtectedField;
}

class Program
{
    static void Main()
    {
        MyClass myObject = new MyClass();

        myObject.publicField = 10;
        myObject.internalField = 3.14;
        myObject.protectedInternalField = 1.234f;

        Console.WriteLine(myObject.publicField);
        Console.WriteLine(myObject.internalField);
        Console.WriteLine(myObject.protectedInternalField);
    }
}

```

In this example, the `MyClass` type has different members with various access modifiers. From the `Main` method, we create an instance of `MyClass` and access the public, internal, and protected internal fields of the instance.

Note that the private and private protected fields cannot be accessed directly from the `Main` method because they are restricted to the declaring class or derived types within the same assembly.

By utilizing access modifiers appropriately, you can control the visibility and accessibility of your types and members, enforcing encapsulation and ensuring proper interaction and usage within your codebase.

## **Access Modifiers Internal and Protected Internal**

Let's take a closer look at the internal and protected internal access modifiers in C#:

**1. Internal Access Modifier:**

- The internal access modifier limits the visibility of a type or member to within the same assembly.
- Types and members marked as internal can be accessed from any class within the same assembly but are not accessible from external assemblies.
- This access modifier is useful for implementing encapsulation within an assembly and exposing only necessary types and members to other parts of the same assembly.

**Example:**

```
internal class InternalClass
{
    internal int InternalField;
    internal void InternalMethod()
    {
        // Method implementation
    }
}

```

**2. Protected internal Access Modifier:**

- The protected internal access modifier combines the accessibility of both protected and internal.
- Types and members marked as protected internal are accessible from within the same assembly and from derived classes, even if they are in a different assembly.
- This access modifier allows for a controlled level of access, typically used in scenarios where certain types or members should be accessible to derived classes and other parts of the same assembly.

**Example:**

```
public class BaseClass
{
    protected internal int ProtectedInternalField;
    protected internal void ProtectedInternalMethod()
    {
        // Method implementation
    }
}

public class DerivedClass : BaseClass
{
    public void AccessProtectedInternalMembers()
    {
        ProtectedInternalField = 10; // Accessible in derived class
        ProtectedInternalMethod();  // Accessible in derived class
    }
}
```

In summary, the internal access modifier limits visibility to within the same assembly, while the protected internal access modifier allows access from within the same assembly and from derived classes, even if they are in a different assembly. These access modifiers provide finer-grained control over the visibility and accessibility of types and members, contributing to encapsulation and appropriate exposure of functionality within a codebase.

## **Access Modifiers for types**

In C#, there are five access modifiers that can be applied to types (classes, structs, interfaces, enums):

1. **public**: The type is accessible from any other code in the same assembly or in other assemblies that reference it.

2. **internal**: The type is only accessible from code within the same assembly. It is not visible to code in other assemblies.

3. **protected**: The type is accessible from code within the same assembly and from derived types (subclasses) even if they are in other assemblies.

4. **protected internal**: The type is accessible from code within the same assembly and from derived types (subclasses) whether they are in the same assembly or in other assemblies.

5. **private**: The type is only accessible from within the same class or struct.

**Here's an example of how these access modifiers can be used:**

```
public class PublicClass
{
    // accessible from any code
}

internal class InternalClass
{
    // accessible only within the same assembly
}

protected class ProtectedClass
{
    // accessible within the same assembly and from derived types
}

protected internal class ProtectedInternalClass
{
    // accessible within the same assembly and from derived types, whether they are in the same assembly or not
}

private class PrivateClass
{
    // accessible only within the same class or struct
}

```

It's worth noting that the default access level for a type is internal if no access modifier is explicitly specified.

## **Attributes**

In C#, attributes provide a way to add metadata to types and their members. They are used to convey additional information about the elements of a program to the runtime or to other developers. Attributes can be predefined (such as [Serializable], [Obsolete], etc.) or custom-defined by users.

**Scope of Attributes:**

Attributes can be applied at various levels of scope:

1. **Assembly-Level**: Applied to the entire assembly using the [assembly: ...] syntax.
2. **Module-Level**: Applied to a module within an assembly.
3. **Type-Level**: Applied to a class, struct, enum, delegate, etc.
4. **Method-Level**: Applied to a method or constructor.
5. **Property-Level**: Applied to a property.
6. **Field-Level**: Applied to a field.
7. **Event-Level**: Applied to an event.
8. **Parameter-Level**: Applied to a method parameter.

**Custom Attributes in C#:**

Custom attributes are user-defined attributes created by deriving from the `System.Attribute` class. They can be used to add custom metadata to types, methods, properties, etc. Here's an example demonstrating the creation and usage of a custom attribute:

```
using System;

// Define a custom attribute
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = false)]
public class MyCustomAttribute : Attribute
{
    public string Description { get; }

    public MyCustomAttribute(string description)
    {
        Description = description;
    }
}

// Apply the custom attribute to a class and method
[MyCustom("This is a custom attribute applied to the class")]
class My_Class
{
    [MyCustom("This is a custom attribute applied to the method")]
    public void MyMethod()
    {
        Console.WriteLine("Inside MyMethod");
    }
}

class CustomAttribute
{
    public static void Main(string[] args)
    {
        // Get and display the custom attribute applied to the class
        var classAttribute = (MyCustomAttribute)Attribute.GetCustomAttribute(typeof(My_Class), typeof(MyCustomAttribute));
        if (classAttribute != null)
        {
            Console.WriteLine("Class Attribute Description: " + classAttribute.Description);
        }

        // Get and display the custom attribute applied to the method
        var methodInfo = typeof(My_Class).GetMethod("MyMethod");
        var methodAttribute = (MyCustomAttribute)Attribute.GetCustomAttribute(methodInfo, typeof(MyCustomAttribute));
        if (methodAttribute != null)
        {
            Console.WriteLine("Method Attribute Description: " + methodAttribute.Description);
        }
    }
}
```

**In this example:**

* We define a custom attribute `MyCustomAttribute` that takes a description string as a parameter.
* We apply the custom attribute to both a class (`MyClass`) and a method (`MyMethod`).
* In the `Main` method, we retrieve and display the description specified in the custom attribute applied to the class and method.

## **Reflection**

**Reflection** is the ability of inspecting an assemblie's metadata at runtime. It is used to find all types in an assembly and/or dynamically invoke methods in an assembly. This includes information about the type, properties, methods, and events of an object. With Reflection, we can dynamically create an instance of a type, bind the type to an existing object, or get the type from an existing object and invoke its methods or access its fields and properties.

**There are several uses of reflection.**

1. When you drag and drop a button on a win forms or an asp.net application. The properties window uses reflection to show all the properties of the Button class. So,reflection is extensivley used by IDE or a UI designers.

2. Late binding can be achieved by using reflection. You can use reflection to dynamically create an instance of a type, about which we don't have any information at compile time. So, reflection enables you to use code that is not available at compile time.

3. Consider an example where we have two alternate implementations of an interface. You want to allow the user to pick one or the other using a config file. With reflection, you can simply read the name of the class whose implementation you want to use from the config file, and instantiate an instance of that class. This is another example for late binding using reflection.

<b>**So, in short reflection can be used for type discovery (i.e finding methods, properties, events, fields, constructors etc) and late binding.**</b>

In this session we will learn how to list a specifc class methods, properties, fields etc using reflection. All the classes and methods related to reflection are present in System.Reflection namespace.

The Type class is the most importanct class.

<b>**Consider the Customer class example. This class has got**</b>

1. Two constructors
2. Two auto implemeneted properties
3. Two methods

```
using System;
using System.Reflection;
namespace Pragim
{
    public class MainClass
    {
        private static void Main()
        {
            // Get the Type Using GetType() static method
            Type T = Type.GetType("Pragim.Customer");
            // Print the Type details
            Console.WriteLine("Full Name = {0}",T.FullName);
            Console.WriteLine("Just the Class Name = {0}",T.Name);
            Console.WriteLine("Just the Namespace = {0}", T.Namespace);
            Console.WriteLine();
            // Print the list of Methods
            Console.WriteLine("Methods in Customer Class");
            MethodInfo[] methods = T.GetMethods();
            foreach (MethodInfo method in methods)
            {
                // Print the Return type and the name of the method
                Console.WriteLine(method.ReturnType.Name + " " + method.Name);
            }
            Console.WriteLine();
            //  Print the Properties
            Console.WriteLine("Properties in Customer Class");
            PropertyInfo[] properties = T.GetProperties();
            foreach (PropertyInfo property in properties)
            {
                // Print the property type and the name of the property
                Console.WriteLine(property.PropertyType.Name + " " + property.Name);
            }
            Console.WriteLine();
            //  Print the Constructors
            Console.WriteLine("Constructors in Customer Class");
            ConstructorInfo[] constructors = T.GetConstructors();
            foreach (ConstructorInfo constructor in constructors)
            {
                Console.WriteLine(constructor.ToString());
            }
        }
    }
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }


        public Customer(int ID, string Name)
        {
            this.Id = ID;
            this.Name = Name;
        }


        public Customer()
        {
            this.Id = -1;
            this.Name = string.Empty;
        }


        public void PrintID()
        {
            Console.WriteLine("ID = {0}", this.Id);
        }
        public void PrintName()
        {
            Console.WriteLine("Name = {0}", this.Name);
        }
    }
}
```

In this example to get the type of customer class we have used <b>'**GetType()**'</b> static method defined on the <b>'**Type**'</b> class. We pass in the fully qualified name of the type including the namespace as a parameter to the GetType() method.

- Type T = Type.GetType("Pragim.Customer");

<b>**To get the type information we have the following 2 ways as well.Use typeof keyowrd**</b>

- Type T = typeof(Customer);

<b>**Use GetType() on the instance of the customer class.**</b>

- Customer C1 = new Customer();
- Type T = C1.GetType();

To get the methods information, we use Type.GetMethods(), which returns MethodInfo[] array and along the same lines we use Type.GetProperties() to get properties information, but Type.GetProperties() returns PropertyInfo[] array.

## **Generics**

Generics are introduced in C# 2.0. Generics allow us to design classes and methods decoupled from the data types. Generic classes are extensively used by collection classes available in System.Collections.Generic namespace.

In this example, AreEqual(int value1, int value2) only works with int data type. If, we pass any other data type, we get a compiler error. So, AreEqual() method in Calculator class is tightly coupled with the int data type, and prevents it from being used with any other data type.

```
using System;
namespace Pragim
{
    public class MainClass
    {
        private static void Main()
        {
            bool Equal = Calculator.AreEqual(1, 2);
            if (Equal)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }
        }
    }
    public class Calculator
    {
        public static bool AreEqual(int value1, int value2)
        {
            return value1 == value2;
        }
    }
}
```

It's a compile time error to invoke AreEqual() method with string parameters.

```
bool Equal = Calculator.AreEqual("A", "B");
```

One way of making AreEqual() method reusable, is to use object type parameters. Since, every type in .NET directly or indirectly inherit from System.Object type, AreEqual() method works with any data type, but the problem is performance degradation due to boxing and unboxing happening.

Also, AreEuqal() method is no longer type safe. It is now possible to pass integer for the first parameter, and a string for the second parameter. It doesn't really make sense to compare strings with integers.

```
using System;
namespace Pragim
{
    public class MainClass
    {
        private static void Main()
        {
            bool Equal = Calculator.AreEqual("A", "B");
            if (Equal)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }
        }
    }
    public class Calculator
    {
        public static bool AreEqual(object value1, object value2)
        {
            return value1 == value2;
        }
    }
}

```

**So, the probem with using System.Object type is that**

1. AreEqual() method is not type safe
2. Performance degradation due to boxing and unboxing.

```
Both of these issues can be solved with generics and still make AreEqual() method work with different data types. The re written example using generics is shown below.
using System;
namespace Pragim
{
    public class MainClass
    {
        private static void Main()
        {
            bool Equal = Calculator.AreEqual<int>(2, 1);
            if (Equal)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }
        }
    }
    public class Calculator
    {
        public static bool AreEqual<T>(T value1, T value2)
        {
            return value1.Equals(value2);
        }
    }
}
```

To make AreEqual() method generic, we specify a type parameter using angular brackets as shown below.

```
public static bool AreEqual<T>(T value1, T value2)
```

At the point, When the client code wants to invoke this method, they need to specify the type, they want the method to operate on. If the user wants the AreEqual() method to work with integers, they can invoke the method specifying int as the datatype
using angular brackets as shown below.

```
bool Equal = Calculator.AreEqual<int>(2, 1);
```

To operate with string data type

```
bool Equal = Calculator.AreEqual<string>("A", "B");
```

In this example, we made the method generic. Along the same lines, it is also possible to make classes, interfaces and delegates generic.

## **Reason to override ToString method**

The `ToString()` method is a predefined method in the `System.Object` class, which is the base class for all types in C#. By default, when you call `ToString()` on an object, it returns a string representation of that object's type.

However, it is often useful and meaningful to provide a customized string representation of an object. This is where overriding the ToString() method becomes valuable. By overriding this method in your own classes, you can define how an object should be represented as a string.

Here are a few reasons why you should consider overriding the ToString() method:

1. **Readability and debugging:** By providing a meaningful string representation, it becomes easier to read and understand the object's state when inspecting it during debugging. Instead of getting a default string like `MyNamespace.MyClass`, you can have a more descriptive output that helps in identifying the object's properties or important values.

2. **Logging and diagnostics:** When logging or reporting errors or important information, having a customized `ToString()` method helps in providing relevant details about the object's state. This can be helpful for debugging or troubleshooting purposes.

3. **Interoperability:** The `ToString()` method is commonly used when converting an object to a string representation for various purposes, such as serialization, data storage, or communication with external systems. By overriding ToString(), you can control how your object is represented in those scenarios, ensuring compatibility and consistency.

4. **Consistent behavior:** Overriding `ToString()` allows you to define a consistent behavior across objects of the same type. It ensures that when you call 'ToString()' on different instances of your class, you get a predictable and standardized output. This can be particularly useful when working with collections or comparing objects.

**To override the `ToString()` method, you need to include it in your class definition and provide your own implementation.**

```
using System;

class CS51_OveridetoStringMethod
{
    // Example usage:
    public static void Main(string[] args)
    {
        MyClass111 myObject = new MyClass111(); // Corrected class name
        myObject.Name = "John";
        myObject.Age = 30;

        // Call the overridden ToString() method
        Console.WriteLine(myObject.ToString());
    }
}

public class MyClass111
{
    public string Name { get; set; }
    public int Age { get; set; }

    public override string ToString()
    {
        return $"Name: {Name}, Age: {Age}";
    }
}
```

In this example, the `ToString()` method is overridden to return a customized string representation of the `MyClass` object, including the `Name` and `Age` properties.

By providing a meaningful and customized implementation of `ToString()`, you improve the readability, debugging experience, and interoperability of your code. It allows you to represent your objects in a way that best suits the requirements and context of your application.

## **Reason to override Equals method**

The `Equals()` method is another predefined method in the `System.Object` class that is responsible for comparing two objects for equality. By default, the `Equals()` method performs a reference equality check, meaning it checks if two object references point to the same memory location.

However, in many cases, you may want to define your own notion of equality for objects based on specific criteria or properties. This is where overriding the `Equals()` method becomes necessary. By overriding this method in your own classes, you can provide a custom implementation for equality comparison.

**Here are a few reasons why you should consider overriding the `Equals()` method:**

1. **Semantic equality:** Objects may have different memory locations but still represent the same logical entity. By overriding `Equals()`, you can define your own notion of equality based on the object's properties or specific criteria. This allows you to compare objects based on meaningful characteristics, such as comparing two objects of a Person class based on their unique identifier or other relevant properties.

2. **Consistent behavior:** Overriding `Equals()` allows you to provide consistent equality checks for objects of the same type. It ensures that when you compare instances of your class, you get the expected behavior and consistent results. This is particularly important when using objects in collections or when performing equality checks in algorithms or data structures.

3. **Compatibility with collections:** Many collection classes, such as HashSet<T>, Dictionary<TKey, TValue>, and others, rely on the `Equals()` method to determine equality and uniqueness of objects. By overriding `Equals()`, you enable your objects to work correctly with these collections and allow them to properly identify duplicates or perform lookups.

4. **Correct behavior with value types:** When working with value types (structs), the default equality check is based on their individual fields. By overriding `Equals()` in value types, you can ensure that equality is correctly determined based on the specific fields and values relevant to the type.

To override the `Equals()` method, you need to include it in your class definition and provide your own implementation.

```
using System;

public class Person111
{
    public string Name { get; set; }
    public int Age { get; set; }

    public override bool Equals(object obj)
    {
        if (obj == null || GetType() != obj.GetType())
            return false;

        Person111 otherPerson = (Person111)obj;
        return Name == otherPerson.Name && Age == otherPerson.Age;
    }

    public override int GetHashCode()
    {
        // Implement a custom GetHashCode() method for consistency with Equals()
        return (Name.GetHashCode() * 397) ^ Age.GetHashCode();
    }
}

class CS52_OverrideEqualsMethod
{
    // Example usage:
     void Main(string[] args)
    {
        Person111 person1 = new Person111 { Name = "Alice", Age = 30 };
        Person111 person2 = new Person111 { Name = "Alice", Age = 30 };
        Person111 person3 = new Person111 { Name = "Bob", Age = 25 };

        // Testing equality
        Console.WriteLine($"person1.Equals(person2): {person1.Equals(person2)}"); // true
        Console.WriteLine($"person1.Equals(person3): {person1.Equals(person3)}"); // false

        // Testing GetHashCode()
        Console.WriteLine($"person1.GetHashCode(): {person1.GetHashCode()}"); // Same as person2.GetHashCode()
        Console.WriteLine($"person3.GetHashCode(): {person3.GetHashCode()}"); // Should be different from person1.GetHashCode()
    }
}
```

In this example, the `Equals()` method is overridden to compare `Person` objects based on their `Name` and `Age` properties. Additionally, the GetHashCode() method is also overridden to ensure consistency with the `Equals()` method, as required by best practices.

By providing a customized `Equals()` implementation, you enable your objects to be compared for equality based on the defined criteria or properties, ensuring that equality checks align with the semantics of your class. This allows you to work with collections, perform accurate equality comparisons, and provide consistent behavior in various scenarios.

## **Difference between Convert.ToString and ToString method**

**The `Convert.ToString()` and `ToString()` methods serve different purposes in C#:**

1. **Convert.ToString()** : The `Convert.ToString()` method is a static method provided by the System.Convert class. It is used to convert a value of any type to its string representation. The `Convert.ToString()` method handles null values and returns an empty string for null references. If the value being converted is not null, the method uses the value's `ToString()` method to obtain the string representation.

**Here's an example of using `Convert.ToString()`** :

```
int number = 42;
string numberString = Convert.ToString(number);

```

**In this example, the `Convert.ToString()` method is used to convert the integer value 42 to its string representation.**

2. **ToString()**: The `ToString()` method is a virtual method defined in the System.Object class, which is the base class for all types in C#. It is intended to be overridden in derived classes to provide a customized string representation of an object. By default, the `ToString()` method returns the fully qualified name of the object's type.

**Here's an example of overriding the `ToString()` method in a custom class:**

```
public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public override string ToString()
    {
        return $"Name: {Name}, Age: {Age}";
    }
}

Person person = new Person { Name = "John", Age = 30 };
string personString = person.ToString();

```

In this example, the `ToString()` method is overridden in the Person class to provide a customized string representation containing the person's name and age.

**To summarize:**

* **Convert.ToString()** is a static method that converts a value of any type to its string representation. It handles null values and uses the value's `ToString()` method internally.
* **ToString()** is a virtual method that is overridden in derived classes to provide a customized string representation of an object. It is called on an instance of a specific type and returns the string representation defined in the overriding implementation.
* In most cases, if you want to obtain a string representation of an object, it is recommended to use the `ToString()` method directly, especially if you have overridden it in your class to provide a customized output. `Convert.ToString()` is typically used when you need to convert a value of an arbitrary type to its string representation, including handling null values.

## **Difference between string and stringbuilder**

**`System.String` and System.Text.StringBuilder are both classes in C# that deal with manipulating strings, but they have different characteristics and purposes:**

**1.** **System.String:**

- **Immutable:** **System.String** objects are immutable, meaning their values cannot be changed after they are created. Any operation that appears to modify a **System.String**actually creates a new **System.String** instance.
- **Thread-safe:** **System.String** objects are inherently thread-safe because they are immutable. Multiple threads can read the same **System.String** instance without concerns for concurrency issues.
- **Efficient for concatenation of small strings:** When concatenating a few small strings, the C# compiler automatically optimizes the concatenation process using **System.String.Concat()** or string interpolation.
- **Suitable for scenarios with minimal string manipulation:** **System.String** is commonly used when you have static or unchanging string data, such as storing or displaying text, performing equality comparisons, or using string manipulation methods like **ToUpper(), ToLower(), Substring()** etc.

**2. System.Text.StringBuilder:**

- **Mutable:** **System.Text.StringBuilder** objects are mutable, meaning you can modify their contents directly without creating new instances. This is achieved through methods like Append(), Insert(), Remove(), Replace(), etc.
- **Efficient for frequent string manipulation:** **System.Text.StringBuilder** is designed for scenarios where you need to frequently concatenate or modify strings. It avoids the overhead of creating new **System.String**instances by modifying the underlying character buffer.
- **Not inherently thread-safe:** **System.Text.StringBuilder** is not inherently thread-safe. If you need to use it in a multi-threaded scenario, you should synchronize access to the **System.Text.StringBuilder** instance.
- **Suitable for building large strings or dynamic content:** **System.Text.StringBuilder** is commonly used when you need to construct or modify strings dynamically, such as when building long SQL queries, generating large XML documents, or processing data with iterative string manipulation.

In general, if you have a limited number of string operations or deal with small strings, using **System.String** is usually sufficient. However, if you need to frequently modify or concatenate strings, especially when dealing with large or dynamic content, using **System.Text.StringBuilder** is more efficient and appropriate.

Here's an example that demonstrates the difference between **System.String** and **System.Text.StringBuilder** in a scenario where you need to concatenate a large number of strings:

```
using System;
using System.Text;

public class StringConcatenationExample
{
    public static void Main()
    {
        // Using System.String
        string result = "";
        for (int i = 0; i < 10000; i++)
        {
            result += "value" + i.ToString() + " ";
        }
        Console.WriteLine("Using System.String:");
        Console.WriteLine("Concatenated string length: " + result.Length);

        // Using System.Text.StringBuilder
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < 10000; i++)
        {
            sb.Append("value");
            sb.Append(i.ToString());
            sb.Append(" ");
        }
        string sbResult = sb.ToString();
        Console.WriteLine("Using System.Text.StringBuilder:");
        Console.WriteLine("Concatenated string length: " + sbResult.Length);
    }
}

```

In this example, we have a loop that concatenates a large number of strings (10,000 iterations). The first part uses **System.String** and the + operator to concatenate the strings. The second part uses **System.Text.StringBuilder** to achieve the same result.

When you run the code, you'll notice the following differences:

- **Using System.String:** The concatenation process involves creating a new **System.String** instance for each concatenation operation. This leads to repeated memory allocations and copying of strings, resulting in poor performance. The time taken to concatenate all the strings grows exponentially as the number of iterations increases.

- **Using System.Text.StringBuilder:** The **System.Text.StringBuilder** avoids creating new instances for each concatenation. Instead, it modifies the underlying character buffer directly. This approach significantly improves performance and memory usage. The time taken to concatenate all the strings remains constant regardless of the number of iterations.

By comparing the length of the resulting concatenated strings, you'll see that both methods produce the same output, but the performance and efficiency differ significantly. In scenarios where you need to concatenate a large number of strings, using **System.Text.StringBuilder** is more efficient and recommended.

## **Partial classes in C#**

In C#, there is a feature called "**partial classes**" that allows you to split the definition of a class across multiple files. This means that you can have different parts of a class defined in separate files, but they are treated as a single class by the compiler.

Partial classes are primarily used in large projects or codebases where multiple developers are working on the same class simultaneously. It provides a way to divide the implementation of a class into logical sections or modules without having to modify a single, monolithic file.

**Here's an example to illustrate the usage of partial classes:**

```
public partial class Customer
{
    public int CustomerId { get; set; }
    public string Name { get; set; }
}

```

```
public partial class Customer
{
    public bool IsValid()
    {
        // Validation logic for the Customer class
        return !string.IsNullOrEmpty(Name);
    }
}

```

- In this example, we have a **Customer** class that is split into two files: **Customer.cs** and **CustomerValidation.cs**

- The **Customer.cs** file contains the basic properties of the customer, such as **CustomerId** and **Name**.

- The **CustomerValidation.cs** file contains a partial class with a method **IsValid()**. This method performs validation on the **Customer** class, checking if the Name property is not null or empty.

- At compile time, these two files are combined into a single class, as if they were defined in one file. So, you can create an instance of the **Customer** class and call the **IsValid()** method to perform the validation.

```
Customer customer = new Customer();
customer.Name = "John Doe";
bool isValid = customer.IsValid(); // Returns true

customer.Name = "";
isValid = customer.IsValid(); // Returns false

```

By using partial classes, you can keep the definition and validation logic of the **Customer** class in separate files, which can make it easier to manage and maintain code in large projects.

## **Creating partial classes in C#**

**1.** All the parts spread across different files, must use the partial keyword. Otherwise a compiler error is raised.
   Missing partial modifier. Another partial declaration of this type exists

**2.** All the parts spread across different files, must have the same access modifiers. Otherwise a compiler error is raised.
   Partial declarations have conflicting accessibility modifiers

**3.** If any of the parts are declared abstract, then the entire type is considered abstract.

**4.** If any of the parts are declared sealed, then the entire type is considered sealed.

**5.** If any of the parts inherit a class, then the entire type inherits that class.

**6.** C# does not support multiple class inheritance. Different parts of the partial class, must not specify different base
   classes. The following code will raise a compiler error stating - Partial declarations must not specify different base classes.

```
public partial class SamplePartialClass : Employee
{
}
public partial class SamplePartialClass : Customer
{
}
public class Employee
{
}
public class Customer
{
}
```

**7.** Different parts of the partial class can specify different base interfaces, and the final type implements all of the interfaces listed by all of the partial declarations. In the example below, SamplePartialClass needs to provide implementation for both IEmployee, and ICustomer interface methods.

```
public partial class SamplePartialClass : IEmployee
{
    public void EmployeeMethod()
    {
        //Method Implementation
    }
}
public partial class SamplePartialClass : ICustomer
{
    public void CustomerMethod()
    {
        //Method Implementation
    }
}
public interface IEmployee
{
    void EmployeeMethod();
}
public interface ICustomer
{
    void CustomerMethod();
}
```

**8.** Any members that are declared in a partial definition are available to all of the other parts of the partial class.

## **Partial methods in c#**

**A partial class or a struct can contain partial methods. A partial method is created using the partial keyword.** Let us understand partial methods with an example. Create a console application. Add a class file, with name **PartialClassFileOne.cs**, to the project. copy and paste the following code.

Notice, that, the **SampleMethod()** definition has the **partial keyword**, and does not have a body(implementation) only the signature.** The implementation for a partial method is optional. If we don't provide the implementation, the compiler removes the signature and all calls to the method.

**The implementation can be provided in the same physical file, or in another physical file**, that contains the partial class. In this example, the partial SampleMethod() is invoked in the PublicMethod().

**Copy and paste the following code in the Main() method of the console application.** When we run the application now, notice that, we don't get a compiler error, in spite of not having an implementation for the partial SampleMethod(). Since, the implementation for the partial method is missing, the compiler will remove the signature and all calls to the method.

```
SampleClass SC = new SampleClass();
SC.PublicMethod();
```

Now, add a class file, with name **PartialClassFileTwo.cs**. Copy and paste the following code. The implementation for the partial method is provided here.

```
partial class SampleClass
{
    // Partial method implemented
    partial void SampleMethod()
    {
        Console.WriteLine("Partial SampleMethod Invoked");
    }
}

```

**Now, run the console application and notice the output.** The partial method and the public method messages are printed on the console.

**A partial method declaration consists of two parts.**

1. The definition (only the method signature ending with a semi-colon, without method body)
2. The implementation.
   These may be in separate parts of a partial class, or in the same part.

**Partial methods are private by default**, and it is a compile time error to include any access modifiers, including private. The following code will raise an error stating - A partial method cannot have access modifiers or the virtual, abstract, override, new, sealed, or extern modifiers.

```
partial class SampleClass
{
    private partial void SampleMethod();
}
```

**It is a compile time error, to include declaration and implementation at the same time for a partial method.** Code below produces a compile time error - No defining declaration found for implementing declaration of partial method 'PartialMethodsDemo.SampleClass.SampleMethod()'

```
partial class SampleClass
{
    partial void SampleMethod()
    {
        Console.WriteLine("SampleMethod Implemented");
    }
}
```

**A partial method return type must be void. Including any other return type is a compile time error**- Partial methods must have a void return type

```
partial class SampleClass
{
    partial int SampleMethod();
}
```

* **A partial method must be declared within a partial class or partial struct.** A non partial class or struct cannot include partial methods.
* Signature of the partial method declaration, must match with the signature of the implementation.
* A partial method can be implemented only once. Trying to implement a partial method more than once, raises a compile time error - A partial method may not have multiple implementing declarations.

## **How and where are indexers used in .net**

Indexers in .NET are used to provide array-like access to objects or collections. They allow instances of a class or struct to be indexed in a way that is similar to accessing elements of an array using square brackets.

**Here's how indexers are used in .NET:**

**1.** **Declaration**: To define an indexer, you need to declare it within a class or struct using the this keyword followed by the indexer parameter(s) in square brackets. The indexer can have one or more parameters, specifying the type and name of each parameter.

```
public T this[int index]
{
    get { /* return the value at the specified index */ }
    set { /* set the value at the specified index */ }
}

```

**2.** **Implementation:** Inside the indexer declaration, you provide the logic for accessing or modifying the indexed elements. The `get` block is executed when reading the value from the indexer, and the `set` block is executed when assigning a value to the indexer.

**3.** **Usage:** Once an indexer is defined, you can use it to access objects or collections using the indexing syntax, similar to arrays. The indexer is invoked by specifying the index values in square brackets after the instance name.

```
MyClass myObject = new MyClass();
var value = myObject[0];    // Invokes the indexer's get accessor
myObject[0] = newValue;     // Invokes the indexer's set accessor

```

Indexers can have multiple parameters, allowing you to define more complex indexing schemes. For example, an indexer for a two-dimensional matrix might have two parameters for row and column indices.

Indexers are commonly used in collection classes to provide convenient access to the elements they contain. They allow you to treat an instance of a class as if it were an array, making the code more intuitive and readable when working with collections of objects.

```
public class MyCollection
{
    private List<string> elements = new List<string>();

    public string this[int index]
    {
        get { return elements[index]; }
        set { elements[index] = value; }
    }
}

// Usage
MyCollection collection = new MyCollection();
collection[0] = "First";
string element = collection[0];

```

In the above example, `MyCollection` defines an indexer that allows you to access elements using an integer index. The underlying collection (`elements`) is an internal `List<string>`, but the indexer provides a more convenient and familiar syntax for working with the collection.

### **Example**

```
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Demo
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
    }

    public class Company
    {
        private List<Employee> listEmployees;

        public Company()
        {
            listEmployees = new List<Employee>();

            listEmployees.Add(new Employee
            { EmployeeId = 1, Name = "Mike", Gender = "Male" });
            listEmployees.Add(new Employee
            { EmployeeId = 2, Name = "Pam", Gender = "Female" });
            listEmployees.Add(new Employee
            { EmployeeId = 3, Name = "John", Gender = "Male" });
            listEmployees.Add(new Employee
            { EmployeeId = 4, Name = "Maxine", Gender = "Female" });
            listEmployees.Add(new Employee
            { EmployeeId = 5, Name = "Emiliy", Gender = "Female" });
            listEmployees.Add(new Employee
            { EmployeeId = 6, Name = "Scott", Gender = "Male" });
            listEmployees.Add(new Employee
            { EmployeeId = 7, Name = "Todd", Gender = "Male" });
            listEmployees.Add(new Employee
            { EmployeeId = 8, Name = "Ben", Gender = "Male" });
        }

        // Use "this" keyword to create an indexer
        // This indexer takes employeeId as parameter
        // and returns employee name
        public string this[int employeeId]
        {
            // Just like properties indexers have get and set accessors
            get
            {
                return listEmployees.
                    FirstOrDefault(x => x.EmployeeId == employeeId).Name;
            }
            set
            {
                listEmployees.
                    FirstOrDefault(x => x.EmployeeId == employeeId).Name = value;
            }
        }
    }
}
```

**Points to remember:**

1. In the Company class constructor, we are initializing variable "listEmployees" and adding employees to the list.
2. We then created an indexer using "this" keyword. This indexer takes employeeId as parameter and returns employee name.
   public string this[int employeeId]
3. Just like properties indexers have get and set accessors.
4. Indexers can also be overloaded. We will discuss about indexer overloading in our next video.

Now let's discuss about, **using the indexer**, that we just created. Copy and paste the following code in WebForm1.aspx.cs

```
Company company = new Company();
Response.Write("Name of Employee with Id = 2: " + company[2]);
Response.Write("<br/>");
Response.Write("Name of Employee with Id = 5: " + company[5]);
Response.Write("<br/>");
Response.Write("Name of Employee with Id = 8: " + company[8]);

Response.Write("<br/>");
Response.Write("<br/>");

Response.Write("Changing names of employees with Id = 2,5,8");
Response.Write("<br/>");
company[2] = "Employee 2 Name Changed";
company[5] = "Employee 5 Name Changed";
company[8] = "Employee 8 Name Changed";

Response.Write("Name of Employee with Id = 2: " + company[2]);
Response.Write("<br/>");
Response.Write("Name of Employee with Id = 5: " + company[5]);
Response.Write("<br/>");
Response.Write("Name of Employee with Id = 8: " + company[8]);
```

**Points to remember:**

1. EmployeeId's 2,5 and 8 are passed into the company object, to retrieve the respective employee names. To retrieve the names of the employees, the "get" accessor of the indexer is used.
2. To change the names of employees, we are again using the integral indexer defined on Company class.
   company[2] = "Employee 2 Name Changed";

Notice that, because of the `"employeeId"` indexer, I am able to use company object like an array.

## **Overloading indexers**

In C#, you can overload indexers by providing multiple indexer definitions within a class or struct, each with a different set of parameters. Overloading indexers allows you to define different ways of accessing or modifying elements based on different index types or combinations.

```
public class MyCollection
{
    private string[] elements = new string[10];

    // Overloaded indexer with int parameter
    public string this[int index]
    {
        get { return elements[index]; }
        set { elements[index] = value; }
    }

    // Overloaded indexer with string parameter
    public string this[string key]
    {
        get
        {
            // Custom logic for retrieving value based on key
            // ...
        }
        set
        {
            // Custom logic for setting value based on key
            // ...
        }
    }
}

```

In this example, the '`MyCollection`' class defines two indexers. The first indexer uses an '`int`' parameter for accessing elements by index, similar to an array. The second indexer uses a '`string`' parameter for accessing elements by a custom key.

```
MyCollection collection = new MyCollection();
collection[0] = "First";             // Uses the int indexer
string element = collection[0];      // Uses the int indexer

collection["Key"] = "Value";         // Uses the string indexer
string value = collection["Key"];    // Uses the string indexer

```

By overloading indexers, you can provide different ways of accessing or modifying elements based on different index types or combinations. This gives you more flexibility in designing classes or structs that provide indexed access to their elements.

## **Optional parameters**

We will discuss the different ways that are available to make method parameters optional.

There are 4 ways that can be used to make method parameters optional.

1. Use parameter arrays
2. Method overloading
3. Specify parameter defaults
4. Use OptionalAttribute that is present in System.Runtime.InteropServices namespace

### **Using parameter arrays, to make method parameters optional**

AddNumbers function, allows the user to add 2 or more numbers. firstNumber and secondNumber parameters are mandatory, where as restOfTheNumbers parameter is optional.

```
public static void AddNumbers(int firstNumber, int secondNumber,
    params object[] restOfTheNumbers)
{
    int result = firstNumber + secondNumber;
    foreach (int i in restOfTheNumbers)
    {
        result += i;
    }

    Console.WriteLine("Total = " + result.ToString());
}
```

**Please note that, a parameter array must be the last parameter in a formal parameter list.**

```
public static void AddNumbers(int firstNumber, params object[] restOfTheNumbers,
    int secondNumber)
{
    // Function implementation
}
```

If the user wants to add just 2 numbers, then he would invoke the method as shown below.

```
AddNumbers(10, 20);
```

On the other hand, if the user wants to add 5 numbers, then he would invoke the method as shown below.

```
AddNumbers(10, 20, 30, 40, 50);
or
AddNumbers(10, 20, new object[] { 30, 40, 50 });
```

### **Making method parameters optional using method overloading**

We will discuss making method parameters optional using method overloading

**This method allows us to add any number of integers.**

```
public static void AddNumbers(int firstNumber, int secondNumber,
    int[] restOfNumbers)
{
    int result = firstNumber + secondNumber;
    if (restOfNumbers != null)
    {
        foreach(int i in restOfNumbers)
        {
            result += i;
        }
    }

    Console.WriteLine("Sum = " + result);
}

```

**If we want to add 5 integers** - 10, 20, 30, 40 and 50. We call the method as shown below.

```
AddNumbers(10, 20, new int[]{30, 40, 50});
```

**At the moment all the 3 parameters are mandatory.** If I want to add just 2 numbers, then I can invoke the method as shown below. Notice that, I am passing null as the argument for the 3rd parameter.

```
AddNumbers(10, 20, null);
```

We can make the 3rd parameter optional by overloading AddNumbers() function as shown below.

```
public static void AddNumbers(int firstNumber, int secondNumber)
{
    AddNumbers(firstNumber, secondNumber, null);
}
```

Now, we have **2 overloaded versions** of AddNumbers() function. If we want to add just 2 numbers, then I can use the overloaded version of AddNumbers() function, that takes 2 parameters as shown below.

```
AddNumbers(10, 20);
```

If I want to add 3 or more numbers, then I can use the overloaded version of AddNumbers() function, that takes 3 parameters as shown below.

```
AddNumbers(10, 20, new int[] { 30, 40 });
```

### **Making method parameters optional by specifying parameter defaults**

We will discuss making method parameters optional by specifying parameter defaults.

```
public static void AddNumbers(int firstNumber, int secondNumber,
    int[] restOfTheNumbers)
{
    int result = firstNumber + secondNumber;
    foreach (int i in restOfTheNumbers)
    {
        result += i;
    }

    Console.WriteLine("Total = " + result.ToString());
}
```

**If we want to add 5 integers** - 10, 20, 30, 40 and 50. We call the method as shown below.

```
AddNumbers(10, 20, new int[]{30, 40, 50});
```

**At the moment all the 3 parameters are mandatory.** If I want to add just 2 numbers, then I can invoke the method as shown below. Notice that, I am passing an empty integer array as the argument for the 3rd parameter.

```
AddNumbers(10, 20, new int[]{});
```

**We can make the 3rd parameter optional by specifying a default value of null for the 3rd parameter.**

```
public static void AddNumbers(int firstNumber, int secondNumber,
    int[] restOfTheNumbers = null)
{
    int result = firstNumber + secondNumber;

    // loop thru restOfTheNumbers only if it is not null
    // otherwise you will get a null reference exception
    if (restOfTheNumbers != null)
    {
        foreach (int i in restOfTheNumbers)
        {
            result += i;
        }
    }
    Console.WriteLine("Total = " + result.ToString());
}
```

**Since we have specified a default value for the 3rd parameter**, it is optional. So, if we want to add just 2 numbers, we can use the function as shown below.

```
AddNumbers(10, 20);
```

**Optional parameters must appear after all required parameters**

The following method will not comiple. This is because, we are making parameter "a" optional, but it appears before the required parameters "b" and "c".

```
public static void Test(int a = 10, int b, int c)
{
    // Do something
}

```

The following method will compile, as optional parameter "a" is specified after all the required parameters ("b" & "c").

```
public static void Test(int b, int c, int a = 10)
{
    // Do something
}
```

Named Parameters

In the following method, parameters "b" & "c" are optional.

```
public static void Test(int a, int b = 10, int c = 20)
{
    Console.WriteLine("a = " + a);
    Console.WriteLine("b = " + b);
    Console.WriteLine("c = " + c);
}
```

When we invoke this method as shown below, "1" is paased as the argument for parameter "a" and "2" is passed as the argument for parameter "b" by default.

```
Test(1, 2);
```

My intention is to pass "2" as the argument for parameter "c". To achieve this we can make use of named parameters, as shown below. Notice that, I have specified the name of the parameter for which value "2" is being passed.

### **Making method parameters optional by using OptionalAttribute**

We will discuss making method parameters optional by using OptionalAttribute that is present in System.Runtime.InteropServices namespace

```
public static void AddNumbers(int firstNumber, int secondNumber,
    int[] restOfTheNumbers)
{
    int result = firstNumber + secondNumber;
    foreach (int i in restOfTheNumbers)
    {
        result += i;
    }

    Console.WriteLine("Total = " + result.ToString());
}
```

If we want to add 5 integers - 10, 20, 30, 40 and 50. We call the method as shown below.

**AddNumbers**(10, 20, new int[]{30, 40, 50});

**At the moment all the 3 parameters are mandatory.** If I want to add just 2 numbers, then I can invoke the method as shown below. Notice that, I am passing an empty integer array as the argument for the 3rd parameter.

```
AddNumbers(10, 20, new int[]{});
```

**We can make the 3rd parameter optional** by using OptionalAttribute that is present in System.Runtime.InteropServices namespace. Make sure you have "using" declaration for System.Runtime.InteropServices namespace.

```
public static void AddNumbers(int firstNumber, int secondNumber,
    [Optional] int[] restOfTheNumbers)
{
    int result = firstNumber + secondNumber;

    // loop thru restOfTheNumbers only if it is not null
    // otherwise you will get a null reference exception
    if (restOfTheNumbers != null)
    {
        foreach (int i in restOfTheNumbers)
        {
            result += i;
        }
    }

    Console.WriteLine("Total = " + result.ToString());
}
```

So, if we want to add just 2 numbers, we can now use the function as shown below.

```
AddNumbers(10, 20);
```

## **What is dictionary in c#**

In C#, a **Dictionary** is a collection type that stores key-value pairs, providing fast and efficient lookup based on the keys. It is part of the **System.Collections.Generic** namespace and is widely used to store and retrieve data using a unique key as the identifier.

**Key features of a `Dictionary` in C#:**

1. **Key-Value Pairs:** A **Dictionary** consists of a collection of key-value pairs. Each key must be unique within the dictionary, and each key is associated with a corresponding value.

2. **Fast Lookup:** **Dictionary** provides efficient lookup performance, allowing you to retrieve values based on their associated keys in constant time (O(1)). This makes it suitable for scenarios where you need to quickly access values using unique identifiers.

3. **Generic Type:** **Dictionary<TKey, TValue>** is a generic class, meaning you can specify the type of the keys and values it holds. For example, you can have a Dictionary<int, string> that stores integers as keys and strings as values.

4. **Mutable Collection:** **Dictionary** allows adding, removing, and updating key-value pairs. It provides methods and properties to manipulate the data stored within it.

5. **Unordered:** The elements in a Dictionary are not ordered. If you need to maintain the order of the elements, you can consider using SortedDictionary or SortedList.

**Here's an example of creating and using a Dictionary in C#:**

```
Dictionary<string, int> studentScores = new Dictionary<string, int>();

// Adding key-value pairs
studentScores["Alice"] = 85;
studentScores["Bob"] = 92;
studentScores["Charlie"] = 78;

// Accessing values by key
int aliceScore = studentScores["Alice"]; // Returns 85

// Checking if a key exists
bool hasBob = studentScores.ContainsKey("Bob"); // Returns true

// Updating values
studentScores["Charlie"] = 82;

// Removing a key-value pair
studentScores.Remove("Alice");

// Iterating over key-value pairs
foreach (KeyValuePair<string, int> pair in studentScores)
{
    Console.WriteLine($"{pair.Key}: {pair.Value}");
}

```

In this example, we create a **Dictionary** called **studentScores** that maps student names (keys) to their corresponding scores (values). We add key-value pairs using the square bracket syntax (**dictionary[key] = value**), retrieve values using the same syntax  (**dictionary[key]**), and perform operations like checking for key existence, updating values, and removing key-value pairs.

**Dictionary** is a powerful and widely used collection type in C# that provides efficient key-based lookup and manipulation of data. It's commonly used for scenarios where fast access to values based on unique keys is required, such as caching, lookups, and data mapping.

## **What is dictionary in c# continued**

**We will discuss the following methods of Dictionary class.**

1. TryGetValue()
2. Count()
3. Remove()
4. Clear()
5. Using LINQ extension methods with Dictionary
6. Different ways to convert an array into a dictionary

**1.** **TryGetValue()**: The **TryGetValue()** method allows you to retrieve the value associated with a specified key from the dictionary. It returns a Boolean value indicating whether the key was found or not, and if found, it assigns the corresponding value to an output parameter.

```
Dictionary<string, int> studentScores = new Dictionary<string, int>();
studentScores["Alice"] = 85;

if (studentScores.TryGetValue("Alice", out int score))
{
    Console.WriteLine($"Alice's score: {score}");
}
else
{
    Console.WriteLine("Alice's score not found.");
}

```

**2.** **Count()**: The **Count** property of the **Dictionary** class returns the number of key-value pairs present in the dictionary.

```
Dictionary<string, int> studentScores = new Dictionary<string, int>();
studentScores["Alice"] = 85;
studentScores["Bob"] = 92;
studentScores["Charlie"] = 78;

int count = studentScores.Count;
Console.WriteLine($"Number of students: {count}");

```

**3.** **Remove()**: The **Remove()** method removes the key-value pair associated with a specified key from the dictionary.

```
Dictionary<string, int> studentScores = new Dictionary<string, int>();
studentScores["Alice"] = 85;
studentScores["Bob"] = 92;
studentScores["Charlie"] = 78;

studentScores.Remove("Bob");

```

**4.** **Clear()**: The **Clear()** method removes all key-value pairs from the dictionary, making it empty.

```
Dictionary<string, int> studentScores = new Dictionary<string, int>();
studentScores["Alice"] = 85;
studentScores["Bob"] = 92;
studentScores["Charlie"] = 78;

studentScores.Clear();

```

**5.** **Using LINQ extension methods with Dictionary**: The Dictionary class can be used with LINQ extension methods like Where(), Select(), OrderBy(), etc., to query or transform the data within the dictionary.

```
Dictionary<string, int> studentScores = new Dictionary<string, int>();
studentScores["Alice"] = 85;
studentScores["Bob"] = 92;
studentScores["Charlie"] = 78;

// Example: Getting names of students with scores above 80
var highScoringStudents = studentScores.Where(pair => pair.Value > 80)
                                       .Select(pair => pair.Key);

```

**6.** **Different ways to convert an array into a dictionary**: There are several ways to convert an array into a dictionary. Here are two common approaches:

**Using a foreach loop:**

```
string[] fruits = { "apple", "banana", "orange" };

Dictionary<int, string> fruitDictionary = new Dictionary<int, string>();
for (int i = 0; i < fruits.Length; i++)
{
    fruitDictionary[i] = fruits[i];
}

```

**Using LINQ's ToDictionary() method:**

```
string[] fruits = { "apple", "banana", "orange" };

Dictionary<int, string> fruitDictionary = fruits.Select((fruit, index) => new { Key = index, Value = fruit })
                                                .ToDictionary(item => item.Key, item => item.Value);

```

These approaches create a dictionary where the indices of the array elements act as keys, and the array elements themselves act as values.


## **List collection class in c#**

The **List<T>** class is a dynamic and generic collection that represents a strongly typed list of objects. It is part of the System.Collections.Generic namespace and provides a wide range of methods and properties for working with lists of items.

**Key features of the`List<T>` class in C#:**

1. **Dynamic Size:** The `List<T>` class automatically adjusts its size as elements are added or removed. It provides efficient resizing capabilities, allowing you to work with collections of variable length.

2. **Generic Type:** `List<T>` is a generic class, which means you can specify the type of objects it will hold. For example, you can have a `List<int>` that stores integers or a `List<string>` that stores strings.

3. **Ordered Collection:** The elements in a `List<T>` are ordered and maintain the insertion order. You can access elements by their index, iterate over the list, and perform operations based on their order.

4. **Dynamic Operations:** `List<T>` offers various methods for adding, removing, inserting, and modifying elements. You can manipulate the list in a flexible and efficient manner.

**Here's an example of creating and using a List<T> in C#:**

```
List<string> names = new List<string>();

// Adding elements
names.Add("Alice");
names.Add("Bob");
names.Add("Charlie");

// Accessing elements by index
string firstElement = names[0];   // Returns "Alice"

// Count of elements
int count = names.Count;   // Returns 3

// Removing elements
names.Remove("Bob");
bool isCharlieRemoved = names.Remove("Charlie");  // Returns true

// Inserting elements at a specific index
names.Insert(1, "Dave");

// Iterating over the list
foreach (string name in names)
{
    Console.WriteLine(name);
}

```

In this example, we create a `List<string>` called **names** to store a collection of names. We add elements using the **Add()** method, access elements using indexing (**names[0]**), get the count of elements using the **Count** property, remove elements using the **Remove()** method, insert elements at a specific index using **Insert()**, and iterate over the list using a foreach loop.

The `List<T>` class provides many more methods and properties for sorting, searching, filtering, and modifying the collection. It offers a rich set of functionalities to work with dynamic lists of objects in a convenient and efficient manner.

> **Note**: It's worth mentioning that the `List<T>` class is implemented as an array internally, which allows for efficient indexing and element access. However, if you require frequent inserts or removals in the middle of the list, you might consider using a `LinkedList<T>` instead, which provides better performance for such operations.


## **List collection class in c# continued**

**1. Contains() function** - Use this function to check if an item exists in the list. This method returns true if the items exists, else false.

```
List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

bool containsThree = numbers.Contains(3);
Console.WriteLine(containsThree);  // Output: True

```

**2. Exists() function** - Use this function, to check if an item exists in the list based on a condition. This method returns true if the items exists, else false.

```
List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

bool existsGreaterThanFive = numbers.Exists(num => num > 5);
Console.WriteLine(existsGreaterThanFive);  // Output: False

```

**3. Find() function** - This method searches for an element that matches the conditions defined by the specified lambda expression and returns the first matching item from the list.

```
List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

int firstEvenNumber = numbers.Find(num => num % 2 == 0);
Console.WriteLine(firstEvenNumber);  // Output: 2

```

**4. FindLast() function** - This method searches for an element that matches the conditions defined by the specified lambda expression and returns the Last matching item from the list.

```
List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

int lastEvenNumber = numbers.FindLast(num => num % 2 == 0);
Console.WriteLine(lastEvenNumber);  // Output: 4

```

**5. FindAll() function** - This method returns all the items from the list that match the conditions specified by the lambda expression.

```
List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

List<int> evenNumbers = numbers.FindAll(num => num % 2 == 0);
foreach (int num in evenNumbers)
{
    Console.WriteLine(num);
}
// Output: 2
//         4

```

**6. FindIndex() function** - This method returns the index of the first item, that matches the condition specified by the lambda expression. There are 2 other overloads of this method which allows us to specify the range of elements to search, with in the list.

```
List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

int index = numbers.FindIndex(num => num > 3);
Console.WriteLine(index);  // Output: 3

```

**7.  FindLastIndex() function** - This method returns the index of the last item, that matches the condition specified by the lambda expression. There are 2 other overloads of this method which allows us to specify the range of elements to search, with in the list.

```
List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 4, 3, 2, 1 };

int lastIndex = numbers.FindLastIndex(num => num > 3);
Console.WriteLine(lastIndex);  // Output: 7

```

**8.  Convert an array to a List** - Use ToList() method

**9. Convert a list to an array** - Use ToArray() method

**10.  Convert a List to a Dictionary** - Use ToDictionary() method

## **Working with generic list class and ranges in c#**

**1. AddRange()** - Add() method allows you to add one item at a time to the end of the list, where as AddRange() allows you to add another list of items, to the end of the list.

**2. GetRange()** - Using an item index, we can retrieve only one item at a time from the list, if you want to get a list of items from the list, then use GetRange() function. This function expects 2 parameters, i.e the start index in the list and the number of elements to return.

**3. InsertRange()** - Insert() method allows you to insert a single item into the list at a specificed index, where as InsertRange() allows you, to insert another list of items to your list at the specified index.

**4. RemoveRange()** - Remove() function removes only the first matching item from the list. RemoveAt() function, removes the item at the specified index in the list. RemoveAll() function removes all the items that matches the specified condition. RemoveRange() method removes a range of elements from the list. This function expects 2 parameters, i.e the start index in the list and the number of elements to remove. If you want to remove all the elements from the list without specifying any condition, then use Clear() function.

**Example**

```
public class Program
{
    public static void Main()
    {
        // Create Customer Objects
        Customer customer1 = new Customer()
        {
            ID = 101,
            Name = "Mark",
            Salary = 4000,
            Type = "RetailCustomer"
        };

        Customer customer2 = new Customer()
        {
            ID = 102,
            Name = "Pam",
            Salary = 7000,
            Type = "RetailCustomer"
        };

        Customer customer3 = new Customer()
        {
            ID = 103,
            Name = "Rob",
            Salary = 5500,
            Type = "RetailCustomer"
        };

        Customer customer4 = new Customer()
        {
            ID = 104,
            Name = "John",
            Salary = 6500,
            Type = "CorporateCustomer"
        };

        Customer customer5 = new Customer()
        {
            ID = 105,
            Name = "Sam",
            Salary = 3500,
            Type = "CorporateCustomer"
        };


        List<Customer> listCustomers = new List<Customer>();
        // Add() method allows you to add one at a time to the end of the list
        listCustomers.Add(customer1);
        listCustomers.Add(customer2);
        listCustomers.Add(customer3);

        List<Customer> listCorporateCustomers = new List<Customer>();
        listCorporateCustomers.Add(customer4);
        listCorporateCustomers.Add(customer5);

        // AddRange() allows you to add another list of items, to the end of the list
        listCustomers.AddRange(listCorporateCustomers);

        foreach (Customer customer in listCustomers)
        {
            Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}, Type = {3}",
                customer.ID, customer.Name, customer.Salary, customer.Type);
        }
        Console.WriteLine("------------------------------------------------------");

        // GetRange() function returns a list of items from the list.
        List<Customer> corporateCustomers = listCustomers.GetRange(3, 2);
        foreach (Customer customer in corporateCustomers)
        {
            Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}, Type = {3}",
                customer.ID, customer.Name, customer.Salary, customer.Type);
        }
        Console.WriteLine("------------------------------------------------------");

        // Remove() function removes only the first matching item from the list.
        listCustomers.Remove(customer1);

        // RemoveAt() function, removes the item at the specified index in the list.
        listCustomers.RemoveAt(0);

        // RemoveAll() function removes all the items that matches the specified condition.
        listCustomers.RemoveAll(x => x.Type == "RetailCustomer");

        foreach (Customer customer in listCustomers)
        {
            Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}, Type = {3}",
                customer.ID, customer.Name, customer.Salary, customer.Type);
        }
        Console.WriteLine("------------------------------------------------------");

        // RemoveRange() method removes a range of elements from the list.
        // This function expects 2 parameters, i.e the start index in the
        // list and the number of elements to remove.
        listCustomers.RemoveRange(0, 2);

        // Insert() method allows you to insert a single item at a time into
        // the list at a specificed index
        listCustomers.Insert(0, customer1);
        listCustomers.Insert(1, customer2);
        listCustomers.Insert(2, customer3);

        // InsertRange() allows you, to insert another list of items to your list at the specified index
        listCustomers.InsertRange(0, listCorporateCustomers);

        foreach (Customer customer in listCustomers)
        {
            Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}, Type = {3}",
                customer.ID, customer.Name, customer.Salary, customer.Type);
        }
        Console.WriteLine("------------------------------------------------------");

        // If you want to remove all the elements from the list without specifying
        // any condition, then use Clear() function.
        listCustomers.Clear();

        Console.WriteLine(" Total Items in the List = " + listCustomers.Count);
    }
}

public class Customer
{
    public int ID { get; set; }
    public string Name { get; set; }
    public int Salary { get; set; }
    public string Type { get; set; }
}

```

## **Sort a list of simple types in c#**

Sorting a list of simple types like int, string, char etc, is straight forward. Just invoke Sort() method on the list instance and the data will be automatically sorted in ascending order.

```
List<int> numbers = new List<int> { 1, 8, 7, 5, 2, 3, 4, 9, 6 };
numbers.Sort();
```

If you want the data to be retrieved in descending order, use Reverse() method on the list instance.

```
numbers.Reverse();
```

However, when you do the same thing on a complex type, we get a runtime invalid operation exception - Failed to compare 2 elements in the array. This because, .NET runtime does not know, how to sort complex types. We have to tell the way we want data to be sorted in the list by implementing IComparable interface. We will discuss this in a later video session.

**Here is the example code**

```
public class Program
{
    public static void Main()
    {
        List<int> numbers = new List<int> { 1, 8, 7, 5, 2, 3, 4, 9, 6 };

        Console.WriteLine("Numbers before sorting");
        foreach (int i in numbers)
        {
            Console.WriteLine(i);
        }

        // Sort() will sort data in ascending order
        numbers.Sort();

        Console.WriteLine("Numbers after sorting");
        foreach (int i in numbers)
        {
            Console.WriteLine(i);
        }

        // Use Reverse() method to retrieve data in descending order
        numbers.Reverse();

        Console.WriteLine("Numbers in descending order");
        foreach (int i in numbers)
        {
            Console.WriteLine(i);
        }

        List<string> alphabets = new List<string>() { "B", "F", "D", "E", "A", "C" };

        Console.WriteLine("Alphabets before sorting");
        foreach (string alphabet in alphabets)
        {
            Console.WriteLine(alphabet);
        }

        alphabets.Sort();

        Console.WriteLine("Alphabets after sorting");
        foreach (string alphabet in alphabets)
        {
            Console.WriteLine(alphabet);
        }

        alphabets.Reverse();

        Console.WriteLine("Alpabets in descending order");
        foreach (string alphabet in alphabets)
        {
            Console.WriteLine(alphabet);
        }

        Customer customer1 = new Customer()
        {
            ID = 101,
            Name = "Mark",
            Salary = 4000
        };

        Customer customer2 = new Customer()
        {
            ID = 102,
            Name = "Pam",
            Salary = 7000
        };

        Customer customer3 = new Customer()
        {
            ID = 103,
            Name = "Rob",
            Salary = 5500
        };

        List<Customer> listCustomers = new List<Customer>();
        listCustomers.Add(customer1);
        listCustomers.Add(customer2);
        listCustomers.Add(customer3);

        Console.WriteLine("Customers before sorting");
        foreach (Customer customer in listCustomers)
        {
            Console.WriteLine(customer.Name);
        }

        // Invoking Sort() on list of complex types will
        // throw invalid operation exception, unless
        // IComparable interface is implemented
        listCustomers.Sort();

        Console.WriteLine("Customers after sorting");
        foreach (Customer customer in listCustomers)
        {
            Console.WriteLine(customer.Name);
        }
    }
}

public class Customer
{
    public int ID { get; set; }
    public string Name { get; set; }
    public int Salary { get; set; }

}
```

## **Sort a list of complex types in c#**

To sort a list of complex types without using **LINQ**, the complex type has to implement **IComparable** interface and provide implementation for **CompareTo()** method. CompareTo() method returns an integer, and the meaning of the return value is shown below.

* **Return value greater than ZERO**- The current instance is greater than the object being compared with.
* **Return value less than ZERO**- The current instance is less than the object being compared with.
* **Return value is ZERO** - The current instance is equal to the object being compared with.

**Alternatively you can also invoke CompareTo() method.**

Salary property of the Customer object is int. CompareTo() method is already implemented on integer type, so we can invoke this method and return it's value as shown below.

`return this.Salary.CompareTo(obj.Salary);`

```
public class Customer : IComparable<Customer>
{
    public int ID { get; set; }
    public string Name { get; set; }
    public int Salary { get; set; }

    public int CompareTo(Customer obj)
    {
        //if (this.Salary > obj.Salary)
        //    return 1;
        //else if (this.Salary < obj.Salary)
        //    return -1;
        //else
        //    return 0;

        // OR, Alternatively you can also invoke CompareTo() method.
        return this.Salary.CompareTo(obj.Salary);
    }
}

```

If you prefer not to use the **Sort functionality provided by the Customer class**, then you can provide your own by implementing **IComparer** interface. For example, if I want the customers to sorted by name instead of salary.

**Step 1:** Implement IComparer interface

```
public class SortByName : IComparer<Customer>
{
    public int Compare(Customer x, Customer y)
    {
        return x.Name.CompareTo(y.Name);
    }
}
```

**Step 2:** Pass an instance of the class that implements IComparer interface, as an argument to the Sort() method.

```
SortByName sortByName = new SortByName();
listCutomers.Sort(sortByName);
```

**Here is the Main() method code:**

```
public class Program
{
    public static void Main()
    {
        Customer customer1 = new Customer()
        {
            ID = 101,
            Name = "Mark",
            Salary = 4000
        };

        Customer customer2 = new Customer()
        {
            ID = 102,
            Name = "John",
            Salary = 7000
        };

        Customer customer3 = new Customer()
        {
            ID = 103,
            Name = "Ken",
            Salary = 5500
        };

        List<Customer> listCutomers = new List<Customer>();
        listCutomers.Add(customer1);
        listCutomers.Add(customer2);
        listCutomers.Add(customer3);

        Console.WriteLine("Customers before sorting");
        foreach (Customer customer in listCutomers)
        {
            Console.WriteLine(customer.Name + " - " + customer.Salary);
        }

        // Sort() method should sort customers by salary
        listCutomers.Sort();

        Console.WriteLine("Customers after sorting");
        foreach (Customer customer in listCutomers)
        {
            Console.WriteLine(customer.Name + " - " + customer.Salary);
        }

        // To sort customers by name instead of salary
        SortByName sortByName = new SortByName();
        listCutomers.Sort(sortByName);

        Console.WriteLine("Customers after sorting by Name");
        foreach (Customer customer in listCutomers)
        {
            Console.WriteLine(customer.Name + " - " + customer.Salary);
        }
    }
}
```

## **Sort a list of complex types using Comparison delegate**

One of the overloads of the `Sort()` method in List class expects Comparison delegate to be passed as an argument. Let us understand using this overloaded version.

```
public void Sort(Comparison<T> comparison)

```

**Approach 1:**

**Step 1:** Create a function whose signature matches the signature of System.Comparison delegate. This is the method where we need to write the logic to compare 2 customer objects.

```
private static int CompareCustomers(Customer c1, Customer c2)
{
    return c1.ID.CompareTo(c2.ID);
}

```

**Step 2:** Create an instance of System.Comparison delegate, and then pass the name of the function created in Step1 as the argument. So, at this point "Comparison" delegate is pointing to our function that contains the logic to compare 2 customer objects.

```
Comparison<Customer> customerComparer = new Comparison<Customer>(CompareCustomers);
```

**Step 3:** Pass the delegate instance as an argument, to Sort() function.

```
listCutomers.Sort(customerComparer);
```

At this point, listCutomers should be sorted using the logic defined in CompareCustomers() function.

**Approach 2:**

**In Approcah1 this is what we have done**

1. Created a private function that contains the logic to compare customers
2. Created an instance of Comparison delegate, and then passed the name of the private function to the delegate.
3. Finally passed the delegate instance to the Sort() method.

The above code can be simplified using delegate keyword as shown below.

```
listCutomers.Sort(delegate(Customer c1, Customer c2)
                    {
                        return (c1.ID.CompareTo(c2.ID));
                    });

```

**Approach 3:** The code in Approach 2, can be further simplified using lambda expression as shown below.

```
listCutomers.Sort((x, y) => x.ID.CompareTo(y.ID));
```

**Example:**

```

public class Program
{
    public static void Main()
    {
        Customer customer1 = new Customer()
        {
            ID = 101,
            Name = "Mark",
            Salary = 4000
        };

        Customer customer2 = new Customer()
        {
            ID = 103,
            Name = "John",
            Salary = 7000
        };

        Customer customer3 = new Customer()
        {
            ID = 102,
            Name = "Ken",
            Salary = 5500
        };

        List<Customer> listCutomers = new List<Customer>();
        listCutomers.Add(customer1);
        listCutomers.Add(customer2);
        listCutomers.Add(customer3);

        Console.WriteLine("Customers before sorting");
        foreach (Customer customer in listCutomers)
        {
            Console.WriteLine(customer.ID);
        }

        // Approach 1
        // Step 2: Create an instance of Comparison delegate
        //Comparison<Customer> customerComparer =
        //    new Comparison<Customer>(CompareCustomers);

        // Step 3: Pass the delegate instance to the Sort method
        //listCutomers.Sort(customerComparer);

        // Approach 2: Using delegate keyword
        //listCutomers.Sort(delegate(Customer c1, Customer c2)
        //{
        //    return (c1.ID.CompareTo(c2.ID));
        //});

        // Aaproach 3: Using lambda expression
        listCutomers.Sort((x, y) => x.ID.CompareTo(y.ID));

        Console.WriteLine("Customers after sorting by ID");
        foreach (Customer customer in listCutomers)
        {
            Console.WriteLine(customer.ID);
        }

        listCutomers.Reverse();
        Console.WriteLine("Customers in descending order of ID");
        foreach (Customer customer in listCutomers)
        {
            Console.WriteLine(customer.ID);
        }
    }

    // Approach 1 - Step 1
    // Method that contains the logic to compare customers
    private static int CompareCustomers(Customer c1, Customer c2)
    {
        return c1.ID.CompareTo(c2.ID);
    }
}

public class Customer
{
    public int ID { get; set; }
    public string Name { get; set; }
    public int Salary { get; set; }
}
```

## **Some useful methods of List collection class**

**1. TrueForAll()** - Returns true or false depending on whether if every element in the list matches the conditions defined by the specified predicate.

**2. AsReadOnly()** - Returns a read-only wrapper for the current collection. Use this method, if you don't want the client code to modify the collection i.e add or remove any elements from the collection. The ReadOnlyCollection will not have methods to add or remove items from the collection. You can only read items from this collection.

**3. TrimExcess()** - Sets the capacity to the actual number of elements in the List, if that number is less than a threshold value.

**According to Microsoft Developer Network:**

* This method can be used to minimize a collection's memory overhead if no new elements will be added to the collection. The cost of reallocating and copying a large List<T> can be considerable, however, so the TrimExcess method does nothing if the list is at more than 90 percent of capacity. This avoids incurring a large reallocation cost for a relatively small gain. The current threshold is 90 percent, but this could change in the future.

```
public class Program
{
    public static void Main()
    {
        Customer customer1 = new Customer()
        {
            ID = 101,
            Name = "Mark",
            Salary = 5200
        };

        Customer customer2 = new Customer()
        {
            ID = 103,
            Name = "John",
            Salary = 7000
        };

        Customer customer3 = new Customer()
        {
            ID = 102,
            Name = "Ken",
            Salary = 5500
        };

        List<Customer> listCutomers = new List<Customer>(100);
        listCutomers.Add(customer1);
        listCutomers.Add(customer2);
        listCutomers.Add(customer3);

        Console.WriteLine("Are all salaries greater than 5000: "
            + listCutomers.TrueForAll(x => x.Salary > 5000));

        // ReadOnlyCollection will not have Add() or Remove() methods
        System.Collections.ObjectModel.ReadOnlyCollection<Customer>
            readOnlyCustomers = listCutomers.AsReadOnly();

        Console.WriteLine("Total Items in ReadOnlyCollection = " +
            readOnlyCustomers.Count);

        // listCutomers list is created with an initial capacity of 100
        // but only 3 items are in the list. The filled percentage is
        // less than 90 percent threshold.
        Console.WriteLine("List capacity before invoking TrimExcess = " +
                listCutomers.Capacity);
        // Invoke TrimExcess() to set the capacity to the actual
        // number of elements in the List
        listCutomers.TrimExcess();
        Console.WriteLine(listCutomers.Capacity);
    }
}

public class Customer
{
    public int ID { get; set; }
    public string Name { get; set; }
    public int Salary { get; set; }
}
```

## **When to use a dictionary over list in c#**

The choice between using a `Dictionary<TKey, TValue>` and a `List<T>` in C# depends on the specific requirements and nature of your data. Here are some considerations to help you decide when to use each:

**Use a `Dictionary<TKey, TValue>` when:**

1. Key-Value Pair Relationship: You need to store data in a key-value pair format, where each value is associated with a unique key.
2. Efficient Lookup: You frequently perform lookups based on keys to retrieve corresponding values. Dictionaries offer fast key-based access, typically with an average time complexity of O(1).
3. Fast Insertion and Removal: Dictionaries provide efficient insertion and removal of key-value pairs, typically with an average time complexity of O(1).
4. Unique Keys: Keys in a dictionary must be unique. If you attempt to add a duplicate key, it will overwrite the existing value.
5. Unordered Collection: Dictionaries don't maintain the order of elements. If you need to preserve the order of elements, you should consider using other collection types, such as `List<T>` or `LinkedList<T>`.

**Use a `List<T>` when:**

1. Sequential Access: You primarily need to access elements in a sequential manner or iterate through them in the order they were added.
2. Index-Based Access: You frequently access elements by their index, rather than by a key.
3. Duplicate Elements: Lists allow duplicate elements, so you can have multiple occurrences of the same value.
4. Order Preservation: Lists maintain the order of elements, making them suitable for scenarios where element order is important.
5. Simple Data Structure: If you only need a straightforward collection of elements without the need for key-value pairs or efficient lookup, a list can be a simpler choice.

In summary, use a `Dictionary<TKey, TValue>` when you have a key-value relationship and require fast lookup and efficient insertion/removal based on keysUse a List<T>`when you need ordered access, duplicate elements, or a simpler data structure without the need for key-based operations.

It's important to evaluate your specific use case and consider the trade-offs between performance, data structure requirements, and functionality when choosing between a dictionary and a list.

## **Generic queue collection class**

The generic `Queue<T>` class is a collection class that represents a first-in, first-out (FIFO) data structure. It provides methods for adding elements to the end of the queue and removing elements from the front. Let's explore the `Queue<T>` class and its commonly used methods:

**1. Creating a Queue:**

```
Queue<int> numbers = new Queue<int>();

```

**2. Enqueue - Adding Elements to the Queue:**

```
numbers.Enqueue(5);
numbers.Enqueue(10);
numbers.Enqueue(15);

```

**3. Dequeue - Removing and Retrieving Elements from the Queue:**

```
Dequeue - Removing and Retrieving Elements from the Queue:
```

**4. Peek - Retrieving the Next Element without Removing it:**

```
int nextNumber = numbers.Peek();
Console.WriteLine(nextNumber);  // Output: 10

```

**5. Count - Getting the Number of Elements in the Queue:**

```
int count = numbers.Count;
Console.WriteLine(count);  // Output: 2

```

**6. Clear - Removing all Elements from the Queue:**

```
numbers.Clear();

```

**7. Contains - Checking if an Element is in the Queue:**

```
bool containsNumber = numbers.Contains(10);
Console.WriteLine(containsNumber);  // Output: True

```

**8. ToArray - Converting the Queue to an Array:**

```
int[] numberArray = numbers.ToArray();

```

**9. Enumerating the Queue - Using foreach Loop:**

```
foreach (int number in numbers)
{
    Console.WriteLine(number);
}
```

The  `Queue<T>`  class provides a convenient and efficient way to manage elements in a FIFO manner. It is commonly used in scenarios where the order of processing or handling elements is crucial, such as implementing task queues, message queues, or event queues.

Remember that the generic `Queue<T>` class can hold elements of any type `(T)`, and the methods available in the class allow you to enqueue, dequeue, peek, and perform other operations on the elements efficiently.

### **Example**

```
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create a queue of strings
        Queue<string> names = new Queue<string>();

        // Enqueue elements to the queue
        names.Enqueue("Alice");
        names.Enqueue("Bob");
        names.Enqueue("Charlie");

        // Get the count of elements in the queue
        int count = names.Count;
        Console.WriteLine($"Number of elements in the queue: {count}");

        // Peek at the next element without removing it
        string nextName = names.Peek();
        Console.WriteLine($"Next name in the queue: {nextName}");

        // Dequeue elements from the queue
        while (names.Count > 0)
        {
            string dequeuedName = names.Dequeue();
            Console.WriteLine($"Dequeued name: {dequeuedName}");
        }

        // Check if an element is in the queue
        bool containsBob = names.Contains("Bob");
        Console.WriteLine($"Does the queue contain 'Bob'? {containsBob}");

        // Clear the queue
        names.Clear();

        // Convert the queue to an array
        string[] namesArray = names.ToArray();

        // Enumerate the queue using foreach loop
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }
    }
}
```

**Output**

```
Number of elements in the queue: 3
Next name in the queue: Alice
Dequeued name: Alice
Dequeued name: Bob
Dequeued name: Charlie
Does the queue contain 'Bob'? False

```

In this example, we create a `Queue<string>` named `names` and enqueue three names. We then demonstrate various operations on the queue such as counting the number of elements, peeking at the next element, dequeuing elements, checking for an element's presence, clearing the queue, converting the queue to an array, and iterating over the elements using a `foreach` loop.

## **Generic stack collection class**

The generic `Stack<T>` class is a collection class that represents a last-in, first-out (LIFO) data structure. It provides methods for adding elements to the top of the stack and removing elements from the top. Let's explore the `Stack<T>`class and its commonly used methods:

**1. Creating a Stack:**

```
Stack<int> numbers = new Stack<int>();

```

**2. Push- Adding Elements to the Stack:**

```
numbers.Push(5);
numbers.Push(10);
numbers.Push(15);

```

**3. Pop - Removing and Retrieving Elements from the Stack:**

```
int topNumber = numbers.Pop();
Console.WriteLine(topNumber);  // Output: 15

```

**4. Peek - Retrieving the Top Element without Removing it:**

```
int nextNumber = numbers.Peek();
Console.WriteLine(nextNumber);  // Output: 10

```

**5. Count - Getting the Number of Elements in the Stack:**

```
int count = numbers.Count;
Console.WriteLine(count);  // Output: 2

```

**6.  Clear - Removing all Elements from the Stack:**

```
numbers.Clear();

```

**7. Contains - Checking if an Element is in the Stack:**

```
bool containsNumber = numbers.Contains(10);
Console.WriteLine(containsNumber);  // Output: True

```

**8. ToArray - Converting the Stack to an Array:**

```
int[] numberArray = numbers.ToArray();

```

**9. Enumerating the Stack - Using foreach Loop:**

```
foreach (int number in numbers)
{
    Console.WriteLine(number);
}

```

The `Stack<T>` class provides a convenient and efficient way to manage elements in a LIFO manner. It is commonly used in scenarios where the order of processing or handling elements is crucial, such as implementing function call stacks, undo/redo functionality, or depth-first search algorithms.

Remember that the generic `Stack<T>` class can hold elements of any type `('T')`, and the methods available in the class allow you to push, pop, peek, and perform other operations on the elements efficiently.

### **Example**

```
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create a stack of integers
        Stack<int> numbers = new Stack<int>();

        // Push elements onto the stack
        numbers.Push(5);
        numbers.Push(10);
        numbers.Push(15);

        // Get the count of elements in the stack
        int count = numbers.Count;
        Console.WriteLine($"Number of elements in the stack: {count}");

        // Peek at the top element without removing it
        int topNumber = numbers.Peek();
        Console.WriteLine($"Top number in the stack: {topNumber}");

        // Pop elements from the stack
        while (numbers.Count > 0)
        {
            int poppedNumber = numbers.Pop();
            Console.WriteLine($"Popped number: {poppedNumber}");
        }

        // Check if an element is in the stack
        bool contains10 = numbers.Contains(10);
        Console.WriteLine($"Does the stack contain 10? {contains10}");

        // Clear the stack
        numbers.Clear();

        // Convert the stack to an array
        int[] numberArray = numbers.ToArray();

        // Enumerate the stack using foreach loop
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}

```

**Output**

```
Number of elements in the stack: 3
Top number in the stack: 15
Popped number: 15
Popped number: 10
Popped number: 5
Does the stack contain 10? False

```

In this example, we create a `Stack<int>` named `numbers` and push three numbers onto the stack. We then demonstrate various operations on the stack such as counting the number of elements, peeking at the top element, popping elements, checking for an element's presence, clearing the stack, converting the stack to an array, and iterating over the elements using a `foreach` loop.

## **Real time example of queue collection class in c#**

When you walk into a bank or a passport office, you will collect a token and wait in the queue for your token number to be called. From the application perspective, when a token is issued, the token number will be added to the end of the Queue. When a representative at the counter is available to server a customer, he will push the "Next" button and the token number that is present at the beginning of the queue, will be dequeued. So, this is one example, where a Queue collection class can be effectively used.

**Webform1 HTML Code**

```
<table style="border:1px solid black; font-family:Arial; text-align:center">
    <tr>
        <td>
            Counter 1
        </td>
        <td>
            Counter 2
        </td>
        <td>
            Counter 3
        </td>
    </tr>
    <tr>
        <td>
            <asp:TextBox ID="txtCounter1" Width="150px" Font-Size="Large" runat="server"
                            BackColor="#000099" ForeColor="White">
            </asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtCounter2" Width="150px" Font-Size="Large" runat="server"
                            BackColor="#000099" ForeColor="White">
            </asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtCounter3" Width="150px" Font-Size="Large" runat="server"
                            BackColor="#000099" ForeColor="White">
            </asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Button ID="btnCounter1" Width="150px" runat="server" Text="Next"
                onclick="btnCounter1_Click" />
        </td>
        <td>
            <asp:Button ID="btnCounter2" Width="150px" runat="server" Text="Next"
                onclick="btnCounter2_Click" />
        </td>
        <td>
            <asp:Button ID="btnCounter3" Width="150px" runat="server" Text="Next"
                onclick="btnCounter3_Click" />
        </td>
    </tr>
    <tr>
        <td colspan="3">
            <asp:TextBox ID="txtNextToken" Font-Size="Large" Width="500px" runat="server"
                        BackColor="#003300" ForeColor="White">
            </asp:TextBox>
        </td>
    </tr>
    <tr>
        <td colspan="3">
            <asp:ListBox ID="listTokens" Width="100px" Font-Size="Medium" runat="server">
            </asp:ListBox>
        </td>
    </tr>
    <tr>
        <td colspan="3">
            <asp:Button ID="btnPrintToken" runat="server" Text="Print Token"
                onclick="btnPrintToken_Click" />
        </td>
    </tr>
    <tr>
        <td colspan="3">
            <asp:Label ID="lblCurrentStatus" runat="server" Font-Size="Medium">
            </asp:Label>
        </td>
    </tr>
</table>
```

**WebForm1.aspx.cs**

```
public partial class WebForm1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["TokenQueue"] == null)
        {
            Queue<int> tokenQueue = new Queue<int>();
            Session["TokenQueue"] = tokenQueue;
        }
    }

    protected void btnCounter1_Click(object sender, EventArgs e)
    {
        ServerNextCustomer(txtCounter1, 1);
    }

    protected void btnCounter2_Click(object sender, EventArgs e)
    {
        ServerNextCustomer(txtCounter2, 2);
    }

    protected void btnCounter3_Click(object sender, EventArgs e)
    {
        ServerNextCustomer(txtCounter3, 3);
    }

    protected void btnPrintToken_Click(object sender, EventArgs e)
    {
        Queue<int> tokenQueue = (Queue<int>)Session["TokenQueue"];
        lblCurrentStatus.Text = "There are " + tokenQueue.Count.ToString()
            + " customers before you in the queue";

        if (Session["lastTokenNumberIssued"] == null)
        {
            Session["lastTokenNumberIssued"] = 0;
        }

        int nextTokenNumberToIssue = (int)Session["lastTokenNumberIssued"] + 1;
        Session["lastTokenNumberIssued"] = nextTokenNumberToIssue;
        tokenQueue.Enqueue(nextTokenNumberToIssue);

        AddTokenNumbersToListBox(tokenQueue);
    }

    private void AddTokenNumbersToListBox(Queue<int> tokenQueue)
    {
        listTokens.Items.Clear();
        foreach (int token in tokenQueue)
        {
            listTokens.Items.Add(token.ToString());
        }
    }

    private void ServerNextCustomer(TextBox textBox, int counterNumnber)
    {
        Queue<int> tokenQueue = (Queue<int>)Session["TokenQueue"];
        if (tokenQueue.Count > 0)
        {
            int tokenNumberToBeServed = tokenQueue.Dequeue();
            textBox.Text = tokenNumberToBeServed.ToString();
            txtNextToken.Text = "Token Number : " + tokenNumberToBeServed.ToString()
                + ", please go to Counter " + counterNumnber.ToString();
            AddTokenNumbersToListBox(tokenQueue);
        }
        else
        {
            textBox.Text = "No cutomers in Queue";
        }
    }
}
```

## **Real time example of stack collection class in c#**

**Two common scenarios, where a stack can be used.**

1. Implementing UNDO functionality
2. Implementing browser back button

**Step 1:** Create an asp.net web application. Use "WebFormsDemo" as the project name.

**Step 2:** Add a class file with name = "BasePage.cs". Copy and paste the following code.

```
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebFormsDemo
{
    public class BasePage : System.Web.UI.Page
    {
        protected override void OnLoad(EventArgs e)
        {
            if (Session["URLStack"] == null)
            {
                Stack<string> urlStack = new Stack<string>();
                Session["URLStack"] = urlStack;
            }

            if (Request.UrlReferrer != null && !this.Page.IsPostBack
                && Session["BackButtonClicked"] == null)
            {
                Stack<string> urlStack = (Stack<string>)Session["URLStack"];
                urlStack.Push(Request.UrlReferrer.AbsoluteUri);
            }

            if (Session["BackButtonClicked"] != null)
            {
                Session["BackButtonClicked"] = null;
            }
        }
    }
}
```

**Step 3:** Add a master page(HTML) with name = Site.Master. Copy and paste the following code.

```
<table style="width: 500px; border: 1px solid black">
    <tr>
        <td colspan="2">
            <asp:Label ID="lblMessage" runat="server" ForeColor="Red">
            </asp:Label>
        </td>
    </tr>
    <tr>
        <td style="width: 100px">
            <table style="border: 1px solid black; font-family: Arial">
                <tr>
                    <td>
                        Links
                    </td>
                </tr>
                <tr>
                    <td>
                        <a href="http://localhost/WebFormsDemo/WebForm1.aspx">WebForm1 </a>
                    </td>
                </tr>
                <tr>
                    <td>
                        <a href="http://localhost/WebFormsDemo/WebForm2.aspx">WebForm2 </a>
                    </td>
                </tr>
                <tr>
                    <td>
                        <a href="http://localhost/WebFormsDemo/WebForm3.aspx">WebForm3 </a>
                    </td>
                </tr>
                <tr>
                    <td>
                        <a href="http://localhost/WebFormsDemo/WebForm4.aspx">WebForm4 </a>
                    </td>
                </tr>
            </table>
        </td>
        <td style="width: 400px">
            <asp:Button ID="btnBack" runat="server" Text="Back" OnClick="btnBack_Click" />
            <asp:ContentPlaceHolder ID="ContentPlaceHolder1" runat="server">
            </asp:ContentPlaceHolder>
        </td>
    </tr>
</table>
```

**Step 4:** Copy and paste the following code in `Site.Master.cs`

```
public partial class Site : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }

    protected void btnBack_Click(object sender, EventArgs e)
    {
        Session["BackButtonClicked"] = "YES";
        if (Session["URLStack"] != null)
        {
            Stack<string> urlStack = (Stack<string>)Session["URLStack"];
            if (urlStack.Count > 0)
            {
                string url = urlStack.Pop();
                Response.Redirect(url);
            }
            else
            {
                lblMessage.Text = "There are no pages in the history";
            }
        }
    }
}
```

That's it, navigate to localhost and click on the links to navigate to WebForm2.aspx, WebForm3.aspx & WebForm4.aspx

Now click on the back button, on the page(Not the browser back button), and notice that we are able to navigate back

## **Multithreading in C#**

**Before we discuss multithreading, first let's understand the following terms**

1. **Process** - Process is what the operating system uses to facilitate the execution of a program by providing the resources required. Each process has a unique process Id associated with it. You can view the process within which a program is being executed using windows task manager.

2. **Thread** - Thread is a light weight process. A process has at least one thread which is commonly called as main thread which actually executes the application code. A single process can have multiple threads.

Multithreading in C# allows you to execute multiple threads concurrently, enabling parallel execution of code and efficient utilization of system resources. It enables you to perform tasks simultaneously, handle I/O operations efficiently, and improve the responsiveness of your applications.

**Multithreading Example:** Create a new windows forms application with 2 buttons and a listbox control as shown in the image below, and set the following properties.

For the first button control, set
Name = btnTimeConsumingWork
Text = Do Time Consuming Work

For the second button control, set
Name = btnPrintNumbers
Text = Print Numbers

Double click on each of the buttons to generate their respective click event handlers.

For the listbox control, set
Name = listBoxNumbers

**Copy and paste the following code in Form1.cs file**

```
using System;
using System.Threading;
using System.Windows.Forms;

namespace ThreadingExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTimeConsumingWork_Click(object sender, EventArgs e)
        {
            btnTimeConsumingWork.Enabled = false;
            btnPrintNumbers.Enabled = false;

            DoTimeConsumingWork();

            btnTimeConsumingWork.Enabled = true;
            btnPrintNumbers.Enabled = true;
        }

        private void DoTimeConsumingWork()
        {
            // Make the thread sleep, to introduce artifical latency
            Thread.Sleep(5000);
        }

        private void btnPrintNumbers_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 10; i++)
            {
                listBoxNumbers.Items.Add(i);
            }
        }
    }
}
```

1. At this point if we run the program, **one thread** is automatically created. This thread is called as the **Main thread or UI thread**. This is the thread that is responsible for doing all the work.
2. Now when you click **"Do Time Consuming Work"**, the first 2 lines of code to disable the button is executed. As a result both the buttons are disabled. 
3.  **DoTimeConsumingWork()** method is called next, and at this point the application is unresponsive as it is waiting for the method to complete. Note that the buttons are still disabled and you cannot click on any of them.
4. Finally, once the **DoTimeConsumingWork()** method completes the buttons are enabled and the application is responsive.

Now change the code in **btnTimeConsumingWork_Click()** event handler method as shown below.

```
private void btnTimeConsumingWork_Click(object sender, EventArgs e)
{
    btnTimeConsumingWork.Enabled = false;
    btnPrintNumbers.Enabled = false;

    // Create another THREAD to offload the work of
    // executing the time consuming method to it.
    // As a result the UI thread, is free to execute the
    // rest of the code and our application is more responsive.
    Thread backGroundThread = new Thread(DoTimeConsumingWork);
    backGroundThread.Start();
    //DoTimeConsumingWork();

    btnTimeConsumingWork.Enabled = true;
    btnPrintNumbers.Enabled = true;
}
```

So one of the benefits of multithreaded programming is that it makes your application more responsive. In our next video, we will discuss the rest of the advantages and disadvantages of multithreaded programming.

## **Advantages and disadvantages of multithreading**

**Advantages of multithreading:**

1. To maintain a responsive user interface
2. To make efficient use of processor time while waiting for I/O operations to complete.
3. To split large, CPU-bound tasks to be processed simultaneously on a machine that has multiple CPUs/cores.

**Disadvantages of multithreading:**

1. On a single-core/processor machine threading can affect performance negatively as there is overhead involved with context-switching.
2. Have to write more lines of code to accomplish the same task.
3. Multithreaded applications are difficult to write, understand, debug and maintain.

Please Note: Only use multithreading when the advantages of doing so outweigh the disadvantages.

## **ThreadStart delegate**

**Let us understand the purpose of ThreadStart delegate with an example**.

```
using System;
using System.Threading;
namespace ThreadStartDelegateExample
{
    class Program
    {
        public static void Main()
        {
            Thread T1 = new Thread(Number.PrintNumbers);
            T1.Start();
        }
    }

    class Number
    {
        public static void PrintNumbers()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
```

**In the example above to create a THREAD**, we created an instance of Thread class and to it's constructor we have passed the name of the function that we want the thread to execute.

```
Thread T1 = new Thread(Number.PrintNumbers);
```

**We can rewrite the above line using ThreadStart delegate as shown below.**

```
Thread T1 = new Thread(new ThreadStart(Number.PrintNumbers));
```

**Why a delegate need to be passed as a parameter to the Thread class constructor?**

The purpose of creating a Thread is to execute a function. A delegate is a type safe function pointer, meaning it points to a function that the thread has to execute. In short, all threads require an entry point to start execution. Any thread you create will need an explicitly defined entry point i.e a pointer to the function where they should begin execution. So threads always require a delegate.

**In the code below, we are not explicitly creating the ThreadStart delegate, then how is it working here?**


```
Thread T1 = new Thread(Number.PrintNumbers);

```

It's working in spite of not creating the ThreadStart delegate explicitly because the framework is doing it automatically for us.

**We can also rewrite the same line using delagate() keyword as shown below.**

```
Thread T1 = new Thread(delegate() { Number.PrintNumbers(); });
```

**We can also rewrite the same line using lambda expression as shown below.**

```
Thread T1 = new Thread(() => Number.PrintNumbers());
```

**Thread function need not be a static function always.** It can also be a non-static function. In case of non-static function we have to create an instance of the class. An example is shown below.

```
class Program
{
    public static void Main()
    {
        Number number = new Number();
        Thread T1 = new Thread(number.PrintNumbers);
        T1.Start();
    }
}

class Number
{
    public void PrintNumbers()
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);
        }
    }
}
```

## **ParameterizedThreadStart delegate**

Use **ParameterizedThreadStart delegate**to pass data to the thread function. Here is an example that shows the usage of ParameterizedThreadStart delegate.

```
using System;
using System.Threading;

namespace ThreadStartDelegateExample
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Please enter the target number");
            object target = Console.ReadLine();

            // Create an instance ParameterizedThreadStart delegate
            ParameterizedThreadStart parameterizedThreadStart =
                new ParameterizedThreadStart(Number.PrintNumbers);
            Thread T1 = new Thread(parameterizedThreadStart);
            // Pass the traget number to the start function, which
            // will then be passed automatically to PrintNumbers() function
            T1.Start(target);
        }
    }

    class Number
    {
        public static void PrintNumbers(object target)
        {
            int number = 0;
            if (int.TryParse(target.ToString(), out number))
            {
                for (int i = 1; i <= number; i++)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}

```

**The code in the Main() function can also be written as shown below.**

```
public static void Main()
{
    Console.WriteLine("Please enter the target number");
    object target = Console.ReadLine();

    Thread T1 = new Thread(Number.PrintNumbers);
    T1.Start(target);
}
```

**Here we are not explicitly creating an instance of ParameterizedThreadStart delegate. Then how is it working?**

It's working because, the compiler implicitly converts new Thread(Number.PrintNumbers) to new Thread(new ParameterizedThreadStart(Number.PrintNumbers)).

**When to use ParameterizedThreadStart over ThreadStart delegate?**

Use **ParameterizedThreadStart**delegate if you have some data to pass to the Thread function, otherwise just use **ThreadStart** delegate.

> **Please note:** Using **ParameterizedThreadStart** delegate and **Thread.Start(Object)** method to pass data to the Thread function is not type safe as they operate on object datatype and any type of data can be passed. If you try to change the data type of the target parameter of PrintNumbers() function from object to int, a compiler error will be raised as the signature of PrintNumbers() function does not match with the signature of ParameterizedThreadStart delegate.

## **Passing data to the Thread function in a type safe manner**

**To pass data to the Thread function in a type safe manner**, encapsulate the thread function and the data it needs in a helper class and use the ThreadStart delegate to execute the thread function. An example is shown below.

```
using System;
using System.Threading;
namespace ThreadingExample
{
    class Program
    {
        public static void Main()
        {
            // Prompt the user for the target number
            Console.WriteLine("Please enter the target number");
            // Read from the console and store it in target variable
            int target = Convert.ToInt32(Console.ReadLine());

            // Create an instance of the Number class, passing it
            // the target number that was read from the console
            Number number = new Number(target);
            // Specify the Thread function
            Thread T1 = new Thread(new ThreadStart(number.PrintNumbers));
            // Alternatively we can just use Thread class constructor as shown below
            // Thread T1 = new Thread(number.PrintNumbers);
            T1.Start();
        }
    }

    // Number class also contains the data it needs to print the numbers
    class Number
    {
        int _target;
        // When an instance is created, the target number needs to be specified
        public Number(int target)
        {
            // The targer number is then stored in the class private variable _target
            this._target = target;
        }

        // Function prints the numbers from 1 to the traget number that the user provided
        public void PrintNumbers()
        {
            for (int i = 1; i <= _target; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
```

## **Retrieving data from Thread function using callback method**

To retrieve data from a thread function using a callback method in C#, you can pass a callback delegate to the thread function. The thread function can then invoke the callback method and pass the data back to the caller. Here's an example to demonstrate this approach:

```
using System;
using System.Threading;

class Program
{
    static void Main()
    {
        // Start a new thread and pass a callback delegate
        Thread thread = new Thread(WorkerMethod);
        thread.Start(ResultCallback);

        // Main thread continues execution
        Console.WriteLine("Main thread");

        // Wait for the worker thread to complete
        thread.Join();
    }

    static void WorkerMethod(object callback)
    {
        // Simulate some time-consuming operation
        Thread.Sleep(2000);

        // Generate a result
        int result = 42;

        // Invoke the callback method and pass the result
        var callbackDelegate = (Action<int>)callback;
        callbackDelegate(result);
    }

    static void ResultCallback(int result)
    {
        // Handle the result received from the worker thread
        Console.WriteLine("Result received: " + result);
    }
}

```

In this example, the **WorkerMethod** is executed on a separate thread. It simulates a time-consuming operation and generates a result. The **ResultCallback** method serves as the callback method, which is invoked by the worker thread and receives the result.

In the **Main** method, a new thread is started by calling **WorkerMethod** and passing **ResultCallback** as the callback delegate. The main thread continues its execution and waits for the worker thread to complete using **thread.Join()**'.

Once the worker thread finishes its operation, it invokes the callback method by casting the callback delegate and passing the result. The **ResultCallback** method is then executed on the main thread, handling the received result.

**Output**

```
Main thread
Result received: 42

```

By using the callback approach, you can retrieve data from a thread function and process it in a separate method or context. This is useful when you need to perform some asynchronous operations and receive the results on a different thread or in a different part of your application.

## **Significance of Thread.Join and Thread.IsAlive functions**

**Join** blocks the current thread and makes it wait until the thread on which Join method is invoked completes. Join method also has a overload where we can specify the timeout. If we don't specify the timeout the calling thread waits indefinitely, until the thread on which Join() is invoked completes. This overloaded Join(int millisecondsTimeout) method returns boolean. True if the thread has terminated otherwise false. Join is particularly useful when we need to wait and collect result from a thread execution or if we need to do some cleanup after the thread has completed.

**IsAlive returns boolean**. True if the thread is still executing otherwise false.

**Program**

```
using System;
using System.Threading;

namespace ThreadingExample
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Main Started");
            Thread T1 = new Thread(Program.Thread1Function);
            T1.Start();

            Thread T2 = new Thread(Program.Thread2Function);
            T2.Start();

            if (T1.Join(1000))
            {
                Console.WriteLine("Thread1Function completed");
            }
            else
            {
                Console.WriteLine("Thread1Function hot not completed in 1 second");
            }

            T2.Join();
            Console.WriteLine("Thread2Function completed");

            for (int i = 1; i <= 10; i++)
            {
                if (T1.IsAlive)
                {
                    Console.WriteLine("Thread1Function is still doing it's work");
                    Thread.Sleep(500);
                }
                else
                {
                    Console.WriteLine("Thread1Function Completed");
                    break;
                }
            }

            Console.WriteLine("Main Completed");
        }

        public static void Thread1Function()
        {
            Console.WriteLine("Thread1Function started");
            Thread.Sleep(5000);
            Console.WriteLine("Thread1Function is about to return");
        }

        public static void Thread2Function()
        {
            Console.WriteLine("Thread2Function started");
        }
    }
}
```

## **Protecting shared resources from concurrent access in multithreading**

**We will discuss,**

1. What happens if shared resources are not protected from concurrent access in multithreaded program 
2. How to protect shared resources from concurrent access

**What happens if shared resources are not protected from concurrent access in multithreaded program**

**The output or behaviour of the program can become inconsistent. Let us understand this with an example.**

```
using System;
class Program
{
    static int Total = 0;
    public static void Main()
    {
        AddOneMillion();
        AddOneMillion();
        AddOneMillion();
        Console.WriteLine("Total = " + Total);
    }

    public static void AddOneMillion()
    {
        for (int i = 1; i <= 1000000; i++)
        {
            Total++;
        }
    }
}
```

The above program is a single-threaded program. In the **Main()** method, **AddOneMillion()** method is called 3 times, and it updates the Total field correctly as expected, and finally prints the correct total i.e 3000000.

**Now, let's rewrite the program using multiple threads.**

```
using System;
using System.Threading;
class Program
{
    static int Total = 0;
    public static void Main()
    {
        Thread thread1 = new Thread(Program.AddOneMillion);
        Thread thread2 = new Thread(Program.AddOneMillion);
        Thread thread3 = new Thread(Program.AddOneMillion);

        thread1.Start();
        thread2.Start();
        thread3.Start();

        thread1.Join();
        thread2.Join();
        thread3.Join();

        Console.WriteLine("Total = " + Total);
    }

    public static void AddOneMillion()
    {
        for (int i = 1; i <= 1000000; i++)
        {
            Total++;
        }
    }
}
```

Every time we run the above program, we get a different output. The inconsistent output is because the Total field which is a shared resource is not protected from concurrent access by multiple threads. The operator ++ is not thread safe. There are several ways to fix this. Let's explore 2 of the options.

Using **Interlocked.Increment()** method: Modify **AddOneMillion()** method as shown below. The Interlocked.Increment() Method, increments a specified variable and stores the result, as an atomic operation

```
public static void AddOneMillion()
{
    for (int i = 1; i <= 1000000; i++)
    {
        Interlocked.Increment(ref Total);
    }
}

```

**The other option is to use a lock.**

```
static object _lock = new object();

public static void AddOneMillion()
{
    for (int i = 1; i <= 1000000; i++)
    {
        lock (_lock)
        {
            Total++;
        }
    }
}
```

**Which option is better?From a performance perspective using Interlocked class is better over using locking.** Locking locks out all the other threads except a single thread to read and increment the Total variable. This will ensure that the Total variable is updated safely. The downside is that since all the other threads are locked out, there is a performance hit.

The Interlocked class can be used with addition/subtraction (increment, decrement, add, etc.) on and int or long field. The Interlocked class has methods for incrementing, decrementing, adding, and reading variables atomically.

**The following code prints the time taken in ticks.** 1 millisecond consists of 10000 ticks.

```
public static void Main()
{
    Stopwatch stopwatch = Stopwatch.StartNew();
    Thread thread1 = new Thread(Program.AddOneMillion);
    Thread thread2 = new Thread(Program.AddOneMillion);
    Thread thread3 = new Thread(Program.AddOneMillion);

    thread1.Start();
    thread2.Start();
    thread3.Start();

    thread1.Join();
    thread2.Join();
    thread3.Join();

    Console.WriteLine("Total = " + Total);

    stopwatch.Stop();
    Console.WriteLine("Time Taken in Ticks = " + stopwatch.ElapsedTicks);
}

```

> **Please Note:** You can use the TimeSpan object to find ticks per second, ticks per millisecond etc. Stopwatch class is in System.Diagnostics namespace.

## **Difference between Monitor and lock in C#**

**This means that, the following code**

```
static object _lock = new object();
public static void AddOneMillion()
{
    for (int i = 1; i <= 1000000; i++)
    {
        lock (_lock)
        {
            Total++;
        }
    }
}
```

**can be rewritten as shown below:**

```
static object _lock = new object();
public static void AddOneMillion()
{
    for (int i = 1; i <= 1000000; i++)
    {
        // Acquires the exclusive lock
        Monitor.Enter(_lock);
        try
        {
            Total++;
        }
        finally
        {
            // Releases the exclusive lock
            Monitor.Exit(_lock);
        }
    }
}
```

**In C# 4, it is implement slightly differently as shown below**

```
static object _lock = new object();
public static void AddOneMillion()
{
    for (int i = 1; i <= 1000000; i++)
    {
        bool lockTaken = false;
        // Acquires the exclusive lock
        Monitor.Enter(_lock, ref lockTaken);
        try
        {
            Total++;
        }
        finally
        {
            // Releases the exclusive lock
            if (lockTaken)
                Monitor.Exit(_lock);
        }
    }
}
```

**So, in short, lock is a shortcut and it's the option for the basic usage.** If you need more control to implement advanced multithreading solutions using TryEnter() Wait(), Pulse(), & PulseAll() methods, then the Monitor class is your option.

## **Deadlock in a multithreaded program**

Scenario when a deadlock can occur Let's say we have 2 threads

1. Thread 1
2. Thread 2

and 2 resources

1. Resource 1
2. Resource 2

**Thread 1 has already acquired a lock on Resource 1 and wants to acquire a lock on Resource 2**. At the same time Thread 2 has already acquired a lock on Resource 2 and wants to acquire a lock on Resource 1. Two threads never give up their locks, hence a deadlock.

**Consider a simple example involving two threads and two resources:**

```
using System;
using System.Threading;

class Program
{
    static object resource1 = new object();
    static object resource2 = new object();

    static void Main()
    {
        // Start two threads
        Thread thread1 = new Thread(DoWork1);
        Thread thread2 = new Thread(DoWork2);
        thread1.Start();
        thread2.Start();

        // Wait for both threads to complete
        thread1.Join();
        thread2.Join();

        Console.WriteLine("Program completed.");
    }

    static void DoWork1()
    {
        lock (resource1)
        {
            Console.WriteLine("Thread 1 acquired resource 1.");

            // Introduce delay to increase the chance of deadlock
            Thread.Sleep(100);

            lock (resource2)
            {
                Console.WriteLine("Thread 1 acquired resource 2.");
                // Do some work with resource 1 and resource 2
            }
        }
    }

    static void DoWork2()
    {
        lock (resource2)
        {
            Console.WriteLine("Thread 2 acquired resource 2.");

            // Introduce delay to increase the chance of deadlock
            Thread.Sleep(100);

            lock (resource1)
            {
                Console.WriteLine("Thread 2 acquired resource 1.");
                // Do some work with resource 1 and resource 2
            }
        }
    }
}

```

In this example, we have two threads (**thread1 and thread2**) that attempt to acquire two resources (**resource1 and resource2**) using locks. The **DoWork1** method acquires **resource1** and then attempts to acquire **resource2**, while the DoWork2 method acquires **resource2** and then attempts to acquire **resource1**.

If the timing and order of execution are unfortunate, a deadlock can occur. For example, if **thread1** acquires **resource1** and **thread2** acquires **resource2**, and then both threads try to acquire the second resource they need, they will end up waiting indefinitely for each other to release the resources, resulting in a deadlock.

To mitigate deadlocks, it is important to carefully manage locks and resource acquisition order. One common approach is to establish a consistent order for acquiring locks across multiple threads to prevent circular dependencies. Additionally, using timeouts or using mechanisms like **Monitor.TryEnter** instead of **lock** can help avoid deadlocks.

It's worth noting that deadlocks can be complex and depend on various factors such as timing, resource dependencies, and execution paths. Analyzing and resolving deadlocks often requires careful design, understanding of concurrency patterns, and utilizing debugging and profiling tools specific to your development environment.

## **How to resolve a deadlock in a multithreaded program**

**Resolving a deadlock in a multithreaded program in C# can be a challenging task, but here are some general steps you can follow to help identify and resolve the issue:**

1. **Identify the deadlocked threads:** Use debugging tools or techniques to identify which threads are involved in the deadlock. Deadlocks occur when threads are waiting for each other's resources or locks.

2. **Analyze the code and locking mechanisms:** Review the code and identify the sections where locks are acquired or released. Look for potential issues such as nested locks or inconsistent locking patterns.

3. **Determine the lock acquisition order:** Deadlocks often occur when threads acquire locks in different orders. Ensure that all threads acquire locks in a consistent order to prevent circular dependencies.

4. **Check for lock contention:** Analyze the sections of code where locks are acquired and check if multiple threads are contending for the same locks. Excessive lock contention can increase the likelihood of deadlocks.

5. **Minimize lock duration:** Reduce the amount of time threads hold locks by moving expensive operations outside the critical section. This can help minimize the chances of deadlocks and improve overall performance.

6. **Use lock timeouts:** Implement timeouts when acquiring locks. If a thread fails to acquire a lock within a specified time, it can release the lock and retry later, or take an alternative action to prevent deadlock.

7. **Consider lock-free or lock-reduced alternatives:** In some cases, it might be possible to use lock-free data structures or synchronization mechanisms, such as the Interlocked class or concurrent collections, to avoid locks altogether or reduce their usage.

8. **Use synchronization primitives correctly:** Ensure that synchronization primitives like Monitor (used with the lock keyword) or Mutex are used correctly and consistently across threads. Verify that Monitor.Enter and Monitor.Exit calls are properly matched, and that exceptions are not causing locks to be left in an inconsistent state.

9. **Test and iterate:** Make targeted changes to your code based on the analysis and then test it thoroughly. Repeat the process until the deadlock is resolved.

10. **Leverage debugging tools:** Take advantage of debugging tools like Visual Studio's debugger, breakpoints, and thread analysis to inspect the state of threads, locks, and resources at runtime. These tools can help identify the root cause of the deadlock.

Here's an example that demonstrates a common scenario where a deadlock can occur in a multithreaded program in C#. Let's consider two threads, Thread A and Thread B, accessing two resources, Resource 1 and Resource 2.

```
using System;
using System.Threading;

class DeadlockExample
{
   private static readonly object lock1 = new object();
   private static readonly object lock2 = new object();

   static void Main()
   {
       Thread threadA = new Thread(DoWorkA);
       Thread threadB = new Thread(DoWorkB);

       threadA.Start();
       threadB.Start();

       // Wait for both threads to complete
       threadA.Join();
       threadB.Join();

       Console.WriteLine("Program completed.");
   }

   static void DoWorkA()
   {
       lock (lock1)
       {
           Console.WriteLine("Thread A acquired lock1.");

           // Introducing a delay to increase the likelihood of deadlock
           Thread.Sleep(100);

           lock (lock2)
           {
               Console.WriteLine("Thread A acquired lock2.");
               // Perform work with Resource 1 and Resource 2
           }
       }
   }

   static void DoWorkB()
   {
       lock (lock2)
       {
           Console.WriteLine("Thread B acquired lock2.");

           // Introducing a delay to increase the likelihood of deadlock
           Thread.Sleep(100);

           lock (lock1)
           {
               Console.WriteLine("Thread B acquired lock1.");
               // Perform work with Resource 1 and Resource 2
           }
       }
   }
}

```

In this example, Thread A acquires **lock1** and then tries to acquire **lock2**, while Thread B acquires **lock2** and then tries to acquire **lock1**. This creates a circular dependency between the two threads, leading to a deadlock.

To resolve the deadlock, we can ensure that the threads acquire locks in a consistent order. Let's modify the code by making both threads acquire the locks in the same order:

```
static void DoWorkA()
{
    lock (lock1)
    {
        Console.WriteLine("Thread A acquired lock1.");

        // Introducing a delay to increase the likelihood of deadlock
        Thread.Sleep(100);

        lock (lock2)
        {
            Console.WriteLine("Thread A acquired lock2.");
            // Perform work with Resource 1 and Resource 2
        }
    }
}

static void DoWorkB()
{
    lock (lock1)  // Changed from lock2
  
  {
        Console.WriteLine("Thread B acquired lock1.");

        // Introducing a delay to increase the likelihood of deadlock
        Thread.Sleep(100);

        lock (lock2)  // Changed from lock1
        {
            Console.WriteLine("Thread B acquired lock2.");
            // Perform work with Resource 1 and Resource 2
        }
    }
}

```

By ensuring that both threads acquire the locks in the same order (lock1, lock2), we eliminate the circular dependency and resolve the deadlock situation.

It's important to note that the example above is a simple illustration. In real-world scenarios, resolving deadlocks can be more complex, and it often requires a deeper analysis of the code and synchronization mechanisms being used.

## **Anonymous methods in c#**

Anonymous methods in C# are a way to define inline delegate functions without explicitly declaring a separate method. They provide a convenient way to create and pass delegates as arguments to other methods or to assign them to variables. Anonymous methods were introduced in C# 2.0 and are often used in event handling and asynchronous programming.

**Here's the basic syntax for defining an anonymous method:**

```
delegate (parameters)
{
    // Code statements
};

```

The '`delegate`' keyword is followed by a set of parentheses that specify the method's parameters (if any). Inside the curly braces, you write the code statements that make up the body of the anonymous method.

**Here's an example that demonstrates the usage of an anonymous method:**

```
using System;

class Program
{
    delegate void PrintDelegate(string message);

    static void Main()
    {
        // Create an instance of the delegate using an anonymous method
        PrintDelegate printDelegate = delegate (string message)
        {
            Console.WriteLine("Anonymous method: " + message);
        };

        // Invoke the delegate
        printDelegate("Hello, world!");

        // Assign a new anonymous method to the delegate
        printDelegate = delegate (string message)
        {
            Console.WriteLine("New anonymous method: " + message);
        };

        // Invoke the delegate again with the new method
        printDelegate("Hola!");

        Console.ReadLine();
    }
}

```

In this example, we define a delegate '`PrintDelegate`' that takes a '`string`' parameter and returns '`void`'. We then create an instance of this delegate using an anonymous method. Inside the anonymous method, we provide the implementation to print the message with a specific prefix.

We invoke the delegate using the '`printDelegate`' instance, passing a message as an argument.

**The output will be:**

```
Anonymous method: Hello, world!
New anonymous method: Hola!

```

Note that anonymous methods can capture variables from their surrounding context, similar to lambda expressions. They have access to variables declared outside their scope and can modify them. This feature is known as "captured variables" and can be useful in certain scenarios.

Anonymous methods provide a concise way to define delegates inline, avoiding the need to define separate methods explicitly. However, with the introduction of lambda expressions in C# 3.0, they have become less commonly used. Lambda expressions provide a more compact and expressive syntax for creating inline delegate functions.

## **Lambda expression in c#**

Lambda expressions in C# are concise inline functions that allow you to write compact code for delegate types or functional interfaces. Lambda expressions were introduced in C# 3.0 and provide a more expressive and readable way to define delegates or function objects.

**The basic syntax for a lambda expression is as follows:**

```
(parameters) => expression

```

**Here's an example that demonstrates the usage of lambda expressions:**

```
using System;

class Program
{
    delegate void PrintDelegate(string message);

    static void Main()
    {
        // Create an instance of the delegate using a lambda expression
        PrintDelegate printDelegate = message =>
        {
            Console.WriteLine("Lambda expression: " + message);
        };

        // Invoke the delegate
        printDelegate("Hello, world!");

        Console.ReadLine();
    }
}

```

In this example, we define a delegate `PrintDelegate` that takes a `string` parameter and returns `void`. We create an instance of this delegate using a lambda expression. The lambda expression `message => { Console.WriteLine("Lambda expression: " + message); }` defines the behavior of the delegate. It takes a `message` parameter and prints it with a specific prefix.

We then invoke the delegate using the `printDelegate` instance, passing a message as an argument.

**The output will be:**

```
Lambda expression: Hello, world!

```

Lambda expressions can also be used with LINQ queries and functional programming concepts like higher-order functions. They provide a concise way to define inline functions without the need for explicit method declarations.

Lambda expressions can capture variables from their surrounding context, similar to anonymous methods. They have access to variables declared outside their scope and can modify them. This feature is known as "captured variables" and can be useful in scenarios where you need to maintain state within the lambda expression.

Lambda expressions offer a more powerful and flexible syntax compared to anonymous methods. They have become the preferred way to define inline functions in C#, as they provide improved readability and expressiveness.

## **Func delegate in c#**

**What is Func<T, TResult> in C#?**

In simple terms, Func<T, TResult> is just a generic delegate. Depending on the requirement, the type parameters (T and TResult) can be replaced with the corresponding type arguments.

For example, Func<Employee, string> is a delegate that represents a function expecting Employee object as an input parameter and returns a string.

```
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public static void Main()
    {
        List<Employee> listEmployees = new List<Employee>()
        {
            new Employee{ ID = 101, Name = "Mark"},
            new Employee{ ID = 102, Name = "John"},
            new Employee{ ID = 103, Name = "Mary"},
        };

        // Create a Func delegate
        Func<Employee, string> selector =
            employee => "Name = " + employee.Name;
        // Pass the delegate to the Select() LINQ function
        IEnumerable<string> names = listEmployees.Select(selector);

        // The above output can be achieved using
        // lambda expression as shown below
        // IEnumerable<string> names =
        // listEmployees.Select(employee => "Name = " + employee.Name);

        foreach (string name in names)
        {
            Console.WriteLine(name);
        }
    }

    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
```

**What is the difference between Func delegate and lambda expression?**

They're the same, just two different ways to write the same thing. The lambda syntax is newer, more concise and easy to write.

**What if I have to pass two or more input parameters?**

As of this recording there are 17 overloaded versions of Func, which enables us to pass variable number and type of input parameters. In the example below, Func<int, int, string> represents a function that expects 2 int input parameters and returns a string.

```
using System;
class Program
{
    public static void Main()
    {
        Func<int, int, string> funcDelegate = (firstNumber, secondNumber) =>
            "Sum = " + (firstNumber + secondNumber).ToString();

        string result = funcDelegate(10, 20);
        Console.WriteLine(result);
    }
}
```

## **Async and await in c#**

Let us create a simple Windows Forms Application that counts the number of characters in a given file. Let us assume the file is very big and it takes around 5 seconds to read and count the number of characters in the file. When the **"Process File Button" is clicked**, the application should display the message**"Processing File. Please wait"**.

Another improtant requirement is that the application should remain responsive throughout the entire process, i.e when the application is busy processing the file the application should not hang and we should still be able to interact with the application. We should be able to click with in the other controls on the form, move the form around on the screen, resize it if required etc.

**Let us first create the Windows Forms Application without using async and await keywords and see how it behaves. Here are the steps.**

**1.** **In your C:** drive, create a new folder. Name it **Data**. In the folder create a new Text Document. Name it **Data.txt.** Type some text in the file and save it. The application that we are going to create, counts the number of characters in this file.

**2.** Create a New **"Windows Forms Application"**. Name it AsyncExample.

**3.** Drag and Drop a "**Button**" on the Form and set the following properties

* Name = btnProcessFIle
* Font - Size = 10
* Text = Process File

**4.** Drag and Drop a "**Label**" on the Form and set the following properties

* Name = lblCount
* Font - Size = 10
* Text = ""

**5.** Double Click on the "**Button**" control to generate the "Click" event handler

**6.** Copy and paste the following code in Form1.cs

```
using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int CountCharacters()
        {
            int count = 0;
            // Create a StreamReader and point it to the file to read
            using (StreamReader reader = new StreamReader("C:\\Data\\Data.txt"))
            {
                string content = reader.ReadToEnd();
                count = content.Length;
                // Make the program look busy for 5 seconds
                Thread.Sleep(5000);
            }

            return count;
        }

        private void btnProcessFIle_Click(object sender, EventArgs e)
        {
            lblCount.Text = "Processing file. Please wait...";
            int count = CountCharacters();
            lblCount.Text = count.ToString() + " characters in file";
        }
    }
}
```

**7.** Run the application and click the "**Process File**" button. You will notice the following problems.

- The application does not display the status message i.e "Processing file. Please wait."
- While the application is busy processing the file, it becomes unresponsive. You cannot move the form window or resize it.

These problems can be very easily fixed by using the **async** and **await** keywords. Notice only the **btnProcessFIle_Click()**event handler method needs to change.

```
// Make the method async by using the async keyword
private async void btnProcessFIle_Click(object sender, EventArgs e)
{
    // Create a task to execute CountCharacters() function
    // CountCharacters() function returns int, so we created Task<int>
    Task<int> task = new Task<int>(CountCharacters);
    task.Start();

    lblCount.Text = "Processing file. Please wait...";
    // Wait until the long running task completes
    int count = await task;
    lblCount.Text = count.ToString() + " characters in file";
}

```

Now, when we click the "**Process File**" button, notice

- The application displays the status message ("**Processing file. Please wait**") immediately.

- Even when the application is busy processing the file, it is responsive. You can move the form window around or resize it.

**So what is the use of async and await keywords in C#**

async and await keywords are used to create asynchronous methods. The async keyword specifies that a method is an asynchronous method and the await keyword specifies a suspension point. The await operator signalls that the async method can't continue past that point until the awaited asynchronous process is complete. In the meantime, control returns to the caller of the async method.

An async method typically contains one or more occurrences of an await operator, but the absence of await expressions doesn’t cause a compiler error.

## **How to wait for a thread to finish without blocking**

**To use a Thread instead of a Task we only need to change btnProcessFile_Click() method as shown below.**

```
private void btnProcessFile_Click(object sender, EventArgs e)
{
    int count = 0;
    Thread thread = new Thread(() => { count = CountCharacters(); });
    thread.Start();

    lblCount.Text = "Processing file. Please wait...";
    lblCount.Text = count.ToString() + " characters in file";
}
```

At this point the application does not work as expected. We have two problems with the above code.

1. We do not see the message, "Processing file. Please wait." at all
2. It displays "0 characters in file"

**Why is this happening**

The Main thread i.e the UI thread has created a worker thread which executes CountCharacters() function. The worker thread takes at least 5 seconds to complete. In the mean time the Main thread continues executing the following 2 lines of code.

```
lblCount.Text = "Processing file. Please wait...";
lblCount.Text = count.ToString() + " characters in file";
```

**But why didn't we see the message "Processing file. Please wait..."**

This is because, the UI thread executes the above 2 lines of code so fast that the second message overwrites the first message and at that speed it is impossible for a human eye to spot the overwriting.

**How to solve the above two problems**

It is very simple. The Main thread has to wait for the worker thread to finish it's work before the UI thread can display the second message. We achieve this by using Join() method on the worker thread.

```
private void btnProcessFile_Click(object sender, EventArgs e)
{
    int count = 0;
    Thread thread = new Thread(() => { count = CountCharacters(); });
    thread.Start();

    lblCount.Text = "Processing file. Please wait...";
    // Join() blocks the Main thread (UI Thread)
    thread.Join();
    lblCount.Text = count.ToString() + " characters in file";
}
```

At this point run the application and test it. We have fixed the above two problems but introduced a new problem. While the application is busy processning the file, the UI is blocked i.e we cannot move the form around or resize it.

You may be thinking why can't we move the code that updates the label control Text property into the worker thread as shown below. This is dangerous because, the thread that has created the control must modify the control. In our case the Main thread (i.e UI Thread) is the thread that has created the label control so only the Main thread should set it's Text property and not the worker thread. If you run the application it may or may not work as expected. If it is working, it is only working by blind luck.

```
private void btnProcessFile_Click(object sender, EventArgs e)
{
    int count = 0;
    Thread thread = new Thread(() =>
    {
        count = CountCharacters();
        // This is dangerous
        lblCount.Text = count.ToString() + " characters in file";
    });
    thread.Start();

    lblCount.Text = "Processing file. Please wait...";
}
```

The right way to achieve this is by using BeginInvoke() method as shown below. BeginInvoke() method asks the UI thread to set the Text property of the label control in a type safe manner.

```
private void btnProcessFile_Click(object sender, EventArgs e)
{
    int count = 0;
    Thread thread = new Thread(() =>
    {
        count = CountCharacters();
        Action action = () => lblCount.Text = count.ToString() + " characters in file";
        this.BeginInvoke(action);
    });
    thread.Start();

    lblCount.Text = "Processing file. Please wait...";
}

```

In the example above, notice that the Action delegate points to a piece of code. The Action delegate is then passed to the BeginInvoke() method which asks the UI thread to execute that piece of code asynchronously in a type safe manner. The above code can also be rewritten as shown below.

```
int characterCount = 0;

private void btnProcessFile_Click(object sender, EventArgs e)
{

    Thread thread = new Thread(() =>
    {
        characterCount = CountCharacters();
        // Action delegate points to SetLabelTextProperty method
        // Signature of SetLabelTextProperty() method should match
        // with the signature of Action delegate
        Action action = new Action(SetLabelTextProperty);
        this.BeginInvoke(action);
    });
    thread.Start();

    lblCount.Text = "Processing file. Please wait...";
}

private void SetLabelTextProperty()
{
    lblCount.Text = characterCount.ToString() + " characters in file";
}
```

Asynchronous implementation is very easy with tasks, and async & await keywords. Though the above example is a very simple example, notice the code is already getting relatively complicated. Imagine if we have multiple threads, and we want to use the result of one thread from another thread and so on and so forth. It can get painful and complicated.

## **Tasks**

* In C#, a Task is a higher-level abstraction for running code asynchronously. A Task denotes a unit of work that needs to be executed asynchronously, and it may or may not return a value. A Task is usually created with the help of the Task Factory class, which provides several methods for creating and executing Tasks.

* Tasks use a Thread pool to execute their work, which means that the Tasks are executed on one of the Threads in the Thread pool. When a Task is created, it is added to the Thread pool's queue, and one of the Threads in the pool is used to execute the Task. Once the Task is completed, the Thread returns to the pool, ready to be used for another Task.

**Tasks have several advantages over Threads:**

* Tasks are more lightweight than Threads. Tasks use fewer system resources, such as memory and CPU time, compared to Threads.
* Tasks are easier to manage than Threads. Tasks provide a higher-level abstraction for asynchronous programming, which makes it easier to write and maintain code.
* Tasks can also provide better performance than Threads in certain situations. This is because Tasks use a Thread pool, which can manage Threads more efficiently than creating and destroying Threads for each unit of work.

```
using System;
using System.Threading;
using System.Threading.Tasks;

class CS64_Tasks
{
    public static void Main(string[] args)
    {
        // Start a new task
        Task task = Task.Run(() =>
        {
            // Simulate some work
            Thread.Sleep(2000);
            Console.WriteLine("Task completed.");
        });

        Console.WriteLine("Main thread continues...");

        // Wait for the task to complete
        task.Wait();

        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
}
```

### **Properties**

**1. AsyncState:**

- Description: Gets the state object passed to the `Task` constructor.

```
object stateObject = ...; // State object passed to the Task constructor
Task task = Task.Run(() =>
{
    // Perform some work
}, stateObject);
Console.WriteLine("AsyncState: " + task.AsyncState);

```

**2. CreationOptions:**

- Description: Gets the `TaskCreationOptions` used to create the task.

```
TaskCreationOptions options = TaskCreationOptions.LongRunning;
Task task = Task.Run(() =>
{
    // Perform some work
}, options);
Console.WriteLine("CreationOptions: " + task.CreationOptions);
```

**3. Exception**

- Description: Gets the `AggregateException` that caused the `Task` to end prematurely.

```
Task task = Task.Run(() =>
{
    throw new Exception("An error occurred.");
});
try
{
    task.Wait();
}
catch (AggregateException ex)
{
    Console.WriteLine("Exception: " + ex.InnerException.Message);
}
```

**4. Id**

- Description: Gets the unique ID of the `Task`.

```
Task task = Task.Run(() =>
{
    // Perform some work
});
Console.WriteLine("Id: " + task.Id);
```

**5. IsCanceled**

- Description: Gets whether the `Task` is in the canceled state.

```
Task task = Task.Run(() =>
{
    // Perform some work
});
Console.WriteLine("IsCanceled: " + task.IsCanceled);
```

**6. IsCompleted**

- Description: Gets whether the `Task` has completed execution.

```
Task task = Task.Run(() =>
{
    // Perform some work
});
Console.WriteLine("IsCompleted: " + task.IsCompleted);
```

**7. IsFaulted**

- Description: Gets whether the `Task` ended due to an unhandled exception.

```
Task task = Task.Run(() =>
{
    throw new Exception("Error occurred.");
});
if (task.IsFaulted)
{
    Console.WriteLine("Task failed due to an exception.");
}

```

**8. Status**

- Description: Gets the `TaskStatus` of the `Task`.

```
Task task = Task.Run(() =>
{
    // Perform some work
});
Console.WriteLine("Task status: " + task.Status);

```

**9. CompletedTask**

- Description: Returns a `Task` that has already completed successfully.

```
Task completedTask = Task.CompletedTask;
Console.WriteLine("CompletedTask: " + completedTask.Status);
```

**10. Factory**

- Description: Gets the `TaskFactory` that created the `Task`.

```
TaskFactory factory = Task.Factory;
Console.WriteLine("Factory: " + factory);
```

### **Methods**

**1. ContinueWith(Action<Task>)**

- Description: Specifies a continuation `Action` to execute when the `Task` completes.

```
Task task = Task.Run(() =>
{
    // Perform some work
});
task.ContinueWith((t) =>
{
    Console.WriteLine("Continuation executed.");
});
```

**2. ContinueWith(Action<Task>, CancellationToken)**

- Description: Specifies a continuation `Action` to execute when the `Task` completes, using a `CancellationToken`.


```
CancellationToken cancellationToken = new CancellationToken();
Task continuationTask = task.ContinueWith((t) =>
{
    // Continue with some action
}, cancellationToken);
```

**3. Wait()**

- Description: Waits for the `Task` to complete execution.

```
Task task = Task.Run(() =>
{
    // Perform some work
});
task.Wait();
Console.WriteLine("Task completed.");
```

**4. Wait(int)**

- Description: Waits for the `Task` to complete execution within a specified time interval.

```
Task task = Task.Delay(2000); // Delayed task
bool completed = task.Wait(3000);
Console.WriteLine("Task completed within time limit: " + completed);
```

**5. Wait(TimeSpan)**

- Description: Waits for the `Task` to complete execution within a specified time span.

```
Task task = Task.Delay(2000); // Delayed task
bool completed = task.Wait(TimeSpan.FromSeconds(3));
Console.WriteLine("Task completed within time limit: " + completed);
```

**6. WaitAll(Task[])**

- Description: Waits for all of the provided `Task` objects to complete execution.

```
Task[] tasks = new Task[3];
// Initialize tasks...
Task.WaitAll(tasks);
Console.WriteLine("All tasks completed.");
```

**7. WaitAny(Task[])**

- Description: Waits for any of the provided `Task` objects to complete execution.

```
Task[] tasks = new Task[3];
// Initialize tasks...
Task.WaitAny(tasks);
Console.WriteLine("At least one task completed.");
```

**8. Run(Action)**

- Description: Queues the specified action to run on the thread pool and returns a `Task` object.

```
Task task = Task.Run(() =>
{
    Console.WriteLine("Task started.");
    // Perform some work
});
```

**9. Run(Func<Task>)**

- Description: Queues the specified function to run on the thread pool and returns a `Task<T>` object.

```
Task<int> task = Task.Run(() =>
{
    // Perform some action and return a result
    return 42;
});
```

**10. Delay(int)**

- Description: Creates a `Task` that completes after a specified time delay.

```
Task.Delay(2000).ContinueWith(_ =>
{
    Console.WriteLine("Task completed after delay.");
});

```

**11. FromResult(TResult)**

- Description: Creates a `Task` that's completed with the specified result.

```
Task<int> resultTask = Task.FromResult(42);
```

**12. FromCanceled(CancellationToken)**

- Description: Creates a canceled `Task` with the specified cancellation token.

```
CancellationToken cancellationToken = new CancellationToken(true);
Task canceledTask
```

**13. FromException(Exception)** 

- Description: Creates a faulted Task with the specified exception.

```
Exception ex = new Exception("An error occurred.");
Task task = Task.FromException(ex);
```

**14. WhenAll(Task[])**

- Description: Creates a Task that will complete when all of the provided Task objects have completed.

```
Task[] tasks = new Task[3];
// Initialize tasks...
Task.WhenAll(tasks).ContinueWith(_ =>
{
    Console.WriteLine("All tasks completed.");
});
```

**15. WhenAny(Task[])** 

- Description: Creates a Task that will complete when any of the provided Task objects have completed.

```
Task[] tasks = new Task[3];
// Initialize tasks...
Task.WhenAny(tasks).ContinueWith(_ =>
{
    Console.WriteLine("At least one task completed.");
});
```

## **Concurrency vs Parallelism**

![image](images/1.png) <!-- height=300px, width=350px -->

**Concurrency**

* Concurrency involves executing multiple tasks simultaneously on a single core.
* It utilizes time slicing and context switching to give the illusion of parallel execution.
* The primary goal of Concurrency is to make applications usable and non-blocking, focusing on software design rather than hardware performance.

**Parallelism**

* Parallelism entails executing multiple tasks simultaneously on different hardware, such as multiple cores or machines.
* It aims to improve performance by leveraging multiple resources to execute tasks in parallel.
* Unlike Concurrency, which focuses on software design, Parallelism emphasizes hardware utilization and performance optimization.

### **Demo1 Asynchronous Task**

**Overview**

This C# console application demonstrates a simple scenario involving asynchronous tasks and user input. It orchestrates the download of two files with delays and then prompts the user for input.

```
using System;
using System.Threading.Tasks;

class CS65_CouncurrencyvsParallelDemo
{
    static void Main(string[] args)
    {
        // Download File 1 with a 10-second delay
        Task.Delay(10000).Wait();
        Console.WriteLine("Downloaded file1");

        // Download File 2 with another 10-second delay
        Task.Delay(10000).Wait();
        Console.WriteLine("Downloaded file2");

        // Prompt the user for input
        Console.WriteLine("Start Data input, Enter your Name:");
        string str = Console.ReadLine();
        Console.WriteLine(str);
        Console.Read();
    }
}
```

![image](images/2.png) <!-- height=200px, width=250px -->

**Execution Flow**

* The application starts by initiating the download of File 1.
* After a 10-second delay, File 1 is downloaded, and "Downloaded file1" is printed.
* Next, File 2 download is initiated with another 10-second delay.
* After downloading File 2, "Downloaded file2" is printed.
* Finally, the application prompts the user to enter their name, reads the input, and prints it back.

While this code accomplishes the intended tasks, it has blocking delays that make the application less user-friendly. Consider refactoring to utilize asynchronous programming techniques to improve responsiveness and user experience.

### **Demo2 Concurrency**

**Overview**

This C# console application demonstrates a simple asynchronous scenario involving the download of two files and user input. It utilizes asynchronous methods to perform non-blocking operations.

```
using System;
using System.Threading.Tasks;

class CS66_Concurrency
{
    static void Main(string[] args)
    {
        // Initiates the asynchronous download of File 1
        NewMethod();

        // Initiates the asynchronous download of File 2
        NewMethod1();

        // Prompts the user for input
        Console.WriteLine("Start Data input, Enter your Name:");
        string str = Console.ReadLine();
        Console.WriteLine(str);
        Console.Read();
    }

    // Asynchronous method for downloading File 1
    private static async void NewMethod1()
    {
        await Task.Delay(10000);
        Console.WriteLine("Downloaded file1");
    }

    // Asynchronous method for downloading File 2
    private static async void NewMethod()
    {
        await Task.Delay(10000);
        Console.WriteLine("Downloaded file2");
    }
}
```

![image](images/3.png) <!-- height=200px, width=250px -->

**Execution Flow**

* The application starts by initiating the asynchronous download of File 1 and File 2 simultaneously.
* Each download operation has a 10-second delay.
* After the specified delay, each file is downloaded, and the corresponding message is printed to the console.
* Finally, the application prompts the user to enter their name, reads the input, and prints it back.

This code demonstrates the use of asynchronous programming to perform non-blocking operations such as file downloads. As a result, the application remains responsive during the download tasks, providing a better user experience.

### **Demo3 Paralleslism**

**Overview**

This C# console application demonstrates the use of parallel execution to improve usability by downloading files asynchronously while allowing user input concurrently.

```
using System;
using System.Threading.Tasks;

class CS67_Parallel
{
    static void Main(string[] args)
    {
        // Initiate parallel execution of NewMethod and NewMethod1
        Task.Factory.StartNew(NewMethod);
        Task.Factory.StartNew(NewMethod1);

        // Prompt the user for input
        Console.WriteLine("Start Data input, Enter your Name:");
        string str = Console.ReadLine();
        Console.WriteLine(str);
        Console.Read();
    }

    // Method for downloading file1 asynchronously
    private static void NewMethod1()
    {
        Task.Delay(10000);
        Console.WriteLine("Downloaded file1");
    }

    // Method for downloading file2 asynchronously
    private static void NewMethod()
    {
        Task.Delay(10000);
        Console.WriteLine("Downloaded file2");
    }
}
```

![image](images/4.png) <!-- height=200px, width=250px -->

**Execution Flow**

* Two asynchronous tasks (`NewMethod` and `NewMethod1`) are initiated using `Task.Factory.StartNew`.
* The program prompts the user to enter their name while the files are downloading asynchronously in the background.
* Once the user enters their name, it's printed back to the console.

**Conclusion**

* Parallel execution is utilized to improve the usability of the application by downloading files asynchronously while allowing user input concurrently.
* The code demonstrates a basic example of parallelism in C# using tasks.
* However, the current implementation doesn't properly await the completion of asynchronous operations, potentially leading to unexpected behavior.
* Consider using async and await keywords along with proper Task.Delay awaiting to ensure correct asynchronous behavior.

### **Differentiate Concurrent and Parallel**

![image](images/5.png)

## **Async vs Thread**

**Asynchronous**

* Asynchronous programming involves executing tasks asynchronously, allowing the main thread to continue executing without waiting for the completion of asynchronous tasks.
* It utilizes keywords like async and await in C# to achieve non-blocking behavior, enhancing application usability.

**Threads**

* Threads are independent paths of execution within a process, allowing concurrent execution of multiple tasks.
* While threads can achieve parallelism by running tasks simultaneously on different cores, they can also introduce complexity and overhead.

**Differentiating Asynchronous Programming and Threads:**

* Asynchronous programming focuses on non-blocking behavior and usability, allowing tasks to run asynchronously without creating additional threads.
* Threads, on the other hand, involve creating separate paths of execution within a process, which can lead to increased complexity and resource overhead.

### **Demo1**

**Overview**

This C# console application demonstrates the difference between synchronous and asynchronous execution using the async and await keywords. It shows how using async allows the main thread to continue executing without waiting for an asynchronous method to finish, and it clarifies that asynchronous operations do not necessarily invoke additional threads.

```
using System;
using System.Threading.Tasks;

class CS68_AsyncvsThread
{
    static void Main(string[] args)
    {
        // Invokes SomeMethod synchronously
        SomeMethod();
        
        // Continues executing main method code
        Console.WriteLine("Main method code");
        Console.Read();
    }

    // Asynchronous method demonstrating async/await behavior
    static async void SomeMethod()
    {
        // Asynchronously waits for a delay of 5 seconds
        await Task.Delay(5000);
        
        // Executes after the delay
        Console.WriteLine("Async code finishes");
    }
}
```

**Debug**

* **Adding Breakpoint:**

  * Locate the line where you want to add the breakpoint.
  * Click on the margin area next to the line number. A red circle should appear, indicating the breakpoint has been set.

* **Debugging the Breakpoint:**

  * Run your application in debug mode by pressing F5 or clicking on the Debug button in the toolbar.
  * When the execution reaches the line with the breakpoint, the program will pause, and the code execution will be halted at that point.

* **Checking Threads in Thread Window:**

  * While the execution is paused at the breakpoint, navigate to the "Debug" menu in Visual Studio.
  * From the Debug menu, select "Windows", then "Threads". Alternatively, you can use the shortcut Ctrl + Alt + H.
  * The "Threads" window should appear, showing you a list of threads currently running in your application.

**Explanation**

* **Async Invocation:** When you invoke `SomeMethod` asynchronously, it means that the main thread will not wait for `SomeMethod` to complete before continuing with its execution. This is the basic premise of asynchronous programming.

* **Task.Delay:** When you use `Task.Delay` with a delay of 60 seconds, it doesn't necessarily mean that a new thread is createdTask.Delay` is a mechanism to introduce a delay without blocking the current thread. It essentially schedules a continuation to be executed after the specified delay.

* **Main Thread Execution:** While the main thread continues executing after invoking `SomeMethod`, `Task.Delay` operates in the background without blocking the main thread. This allows the main thread to continue its execution flow without waiting for the delay to complete.

* **Worker Thread:** After the 60-second delay imposed by `Task.Delay` finishes, there might be a worker thread involved. This worker thread is not necessarily created by your application explicitly. Instead, it could be a part of the underlying framework's thread pool mechanism.

* **Callback Execution:** The worker thread that executes after the delay is likely responsible for handling the continuation or callback associated with `Task.Delay`. This callback signals the completion of the delay and resumes execution from the point where the delay was awaited.

* **Purpose of the Worker Thread:** The purpose of this worker thread is to handle asynchronous callbacks and continuations in a non-blocking manner. It allows asynchronous operations, such as delays, to execute independently of the main thread and ensures that the main thread remains responsive.

* **Lightweight Thread:** The worker thread involved in handling the delay callback is typically lightweight and managed by the underlying runtime or framework. It's not a full-fledged operating system thread but rather a thread from a thread pool, designed for efficient task scheduling and execution.

**Conclusion**

* Asynchronous programming using async and await allows for non-blocking execution of code, enabling the main thread to continue its tasks while awaiting asynchronous operations.
* Contrary to popular belief, asynchronous operations do not always spawn additional threads. Instead, they utilize lightweight callback mechanisms to continue execution after awaiting asynchronous tasks.
* Understanding asynchronous programming is crucial for building responsive and scalable applications.

### **Demo2**

**Overview**

This C# console application demonstrates the difference between asynchronous execution using the `async` and `await` keywords and thread-based execution using the `Thread` class.

```
using System;
using System.Threading;
using System.Threading.Tasks;

class CS69_AsyncvsThread1
{
    static void Main(string[] args)
    {
        // Create a new thread to execute SomeMethod
        Thread x = new Thread(SomeMethod);
        x.Start();
        
        // Continues executing main method code
        Console.WriteLine("Main method code");
        Console.Read();
    }

    // Method executed on a separate thread
    static void SomeMethod()
    {
        // Simulate an asynchronous delay without using async/await
        Task.Delay(5000);
        
        // Executes after the delay
        Console.WriteLine("Async code finishes");
    }
}
```

**Debug**

* **Adding Breakpoint:**

  * Locate the line where you want to add the breakpoint.
  * Click on the margin area next to the line number. A red circle should appear, indicating the breakpoint has been set.

* **Debugging the Breakpoint:**

  * Run your application in debug mode by pressing F5 or clicking on the Debug button in the toolbar.
  * When the execution reaches the line with the breakpoint, the program will pause, and the code execution will be halted at that point.

* **Checking Threads in Thread Window:**

  * While the execution is paused at the breakpoint, navigate to the "Debug" menu in Visual Studio.
  * From the Debug menu, select "Windows", then "Threads". Alternatively, you can use the shortcut Ctrl + Alt + H.
  * The "Threads" window should appear, showing you a list of threads currently running in your application.

**Explanation**

* Many developers mistakenly believe that threads and asynchronous code are interchangeable or that using the async keyword internally creates threads. This misconception often arises from encountering situations where one thread is blocking, prompting developers to think that creating additional threads is the solution.

* **Traditional Solution: Creating Additional Threads**

  * When faced with a blocking thread, developers often resort to creating additional threads to offload the blocking code. This approach seems intuitive: if one thread is not enough, why not create more threads to handle the workload? While this solution may work in simple scenarios, it can lead to resource-intensive behavior, especially when scaling up.

**Execution Flow**

* A new thread (`x`) is created to execute `SomeMethod`.
* "Main method code" is printed to the console from the main thread.
* `SomeMethod` runs on the separate thread, simulating an asynchronous delay using Task.Delay.
* After the delay, "Async code finishes" is printed to the console from the separate thread.

**Conclusion**

* The code demonstrates the difference between asynchronous execution and thread-based execution.
* Asynchronous execution using `async` and `await` provides a cleaner and more efficient way to handle asynchronous operations compared to using threads * directly.
* Understanding the differences between these approaches is essential for building scalable and responsive applications.

### **Demo3**

**Overview**

This C# console application demonstrates the difference between asynchronous execution using the `async` and `await` keywords and thread-based execution using multiple instances of the Thread class within a loop.

```
using System;
using System.Threading;
using System.Threading.Tasks;

class CS70_AsyncvsThread2
{
    static void Main(string[] args)
    {
        // Create multiple threads to execute SomeMethod concurrently
        for(int i = 0; i < 1000; i++)
        {
            Thread x = new Thread(SomeMethod);
            x.Start();
        }
        
        // Continues executing main method code
        Console.WriteLine("Main method code");
        Console.Read();
    }

    // Method executed on separate threads
    static void SomeMethod()
    {
        // Simulate an asynchronous delay without using async/await
        Task.Delay(5000);
        
        // Executes after the delay
        Console.WriteLine("Async code finishes");
    }
}
```

**Debug**

* **Adding Breakpoint:**

  * Locate the line where you want to add the breakpoint.
  * Click on the margin area next to the line number. A red circle should appear, indicating the breakpoint has been set.

* **Debugging the Breakpoint:**

  * Run your application in debug mode by pressing F5 or clicking on the Debug button in the toolbar.
  * When the execution reaches the line with the breakpoint, the program will pause, and the code execution will be halted at that point.

* **Checking Threads in Thread Window:**

  * While the execution is paused at the breakpoint, navigate to the "Debug" menu in Visual Studio.
  * From the Debug menu, select "Windows", then "Threads". Alternatively, you can use the shortcut Ctrl + Alt + H.
  * The "Threads" window should appear, showing you a list of threads currently running in your application.

**Explanation**

* **Downsides of Creating Multiple Threads**

  * While creating additional threads can alleviate blocking issues, it comes with its own set of downsides:

    * **Resource Consumption:** Each thread consumes memory and utilizes processing cores. Creating multiple threads unnecessarily can lead to excessive resource consumption, impacting the performance and scalability of the application.
    * **Complexity:** Managing multiple threads introduces complexity into the codebase, increasing the likelihood of concurrency bugs, race conditions, and synchronization issues.
    * **Diminished Performance:** Contrary to the intended goal of improving performance, excessive thread creation can actually degrade performance due to increased overhead and contention for system resources.

**Execution Flow**

* Multiple instances of the `Thread` class are created within a loop to execute `SomeMethod` concurrently.
* "Main method code" is printed to the console.
* Each instance of `SomeMethod` runs on a separate thread, simulating an asynchronous delay using `Task.Delay`.
* After the delay, "Async code finishes" is printed to the console from each separate thread.

**Conclusion**

* The code demonstrates the difference between asynchronous execution and thread-based execution with multiple threads.
* Asynchronous execution using `async` and `await` provides a cleaner and more efficient way to handle asynchronous operations compared to using multiple threads directly.
* Understanding the differences between these approaches is essential for building scalable and responsive applications.

### **Demo4-StateMachine**

**Overview of Code**

This C# console application demonstrates the behavior of state machines in asynchronous methods using the async and await keywords.

```
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CS71_StateMachines
{
    void Main(string[] args)
    {
        Console.WriteLine("Code 1");
        Console.WriteLine("Code 2");
        SomeMethod();
        Console.WriteLine("Code 7");
        Console.WriteLine("Code 8");
        Console.Read();
    }
    static async void SomeMethod()
    {
        Console.WriteLine("Code 1");
        Console.WriteLine("Code 2");
        await Task.Delay(10000);
        Console.WriteLine("Code 5");
        Console.WriteLine("Code 6");
        Console.Read();
    }
}
```

**Debug**

* **Adding Breakpoint:**

  * Locate the line where you want to add the breakpoint.
  * Click on the margin area next to the line number. A red circle should appear, indicating the breakpoint has been set.

* **Debugging the Breakpoint:**

  * Run your application in debug mode by pressing F5 or clicking on the Debug button in the toolbar.
  * When the execution reaches the line with the breakpoint, the program will pause, and the code execution will be halted at that point.

* **Checking Threads in Thread Window:**

  * While the execution is paused at the breakpoint, navigate to the "Debug" menu in Visual Studio.
  * From the Debug menu, select "Windows", then "Threads". Alternatively, you can use the shortcut Ctrl + Alt + H.
  * The "Threads" window should appear, showing you a list of threads currently running in your application.

**Explanation**

* In asynchronous code, the program's logic is divided into smaller segments or chunks, each representing a distinct state or stage of execution.
* These segments are delineated by specific operations or await points, such as asynchronous method calls or delays.

* **Example Scenario:**

  * Consider a scenario where an asynchronous method includes a Task.Delay operation.
  * Before the Task.Delay, there may be code segments for initialization or setup (Code 1 and Code 2).
  * After the Task.Delay, there may be additional code segments for handling the delayed operation (Code 3 and Code 4).
  * Finally, there may be code segments for cleanup or post-processing (Code 5 and Code 6).

* **Execution Flow:**

  * When the main thread starts executing the asynchronous code, it begins with the initial code segments (Code 1 and Code 2).
  * As the execution progresses, the state machine directs the main thread to move to subsequent code segments based on the current state.
  * For example, after completing Code 1 and Code 2, the state machine instructs the main thread to execute Code 3 and Code 4, including the Task.Delay operation.
  * After the Task.Delay completes, the state machine transitions to the next state, instructing the main thread to execute Code 5 and Code 6.
  * This process continues until all code segments have been executed, completing the asynchronous operation.

**Conclusion:**

* State machines play a crucial role in asynchronous programming by organizing code segments and managing the flow of execution.
* By dividing the logic into smaller chunks and orchestrating their execution, state machines enable asynchronous behavior without the overhead of thread creation.
* Understanding how state machines operate internally helps developers grasp the mechanics behind asynchronous programming and leverage its benefits effectively.

### **Demo5-SynchronizationContext**

**What is Synchronization Context?**

* Synchronization Context is an important mechanism that controls the execution context of asynchronous operations.
* It defines how asynchronous tasks are scheduled and executed within a specific environment, such as a UI thread or a server-side application.

**Overview of Code**

This C# console application demonstrates the behavior of the SynchronizationContext in asynchronous methods using the async and await keywords.

```
using System;
using System.Threading;
using System.Threading.Tasks;

class CS72_SynchronizationContext
{
    static void Main(string[] args)
    {
        // Prints "Code 1" to the console
        Console.WriteLine("Code 1");

        // Prints "Code 2" along with the current thread ID to the console
        Console.WriteLine("Code 2" + Thread.CurrentThread.ManagedThreadId);

        // Calls the SomeMethod asynchronously
        SomeMethod();

        // Prints "Code 7" to the console
        Console.WriteLine("Code 7");

        // Prints "Code 8" to the console
        Console.WriteLine("Code 8");

        // Waits for user input before exiting
        Console.Read();
    }

    // Asynchronous method demonstrating the SynchronizationContext
    static async void SomeMethod()
    {
        // Prints "Code 1" to the console
        Console.WriteLine("Code 1");

        // Prints "Code 2" to the console
        Console.WriteLine("Code 2");

        // Asynchronously waits for a delay of 10 seconds
        await Task.Delay(10000);

        // Prints "Code 5" to the console
        Console.WriteLine("Code 5");

        // Prints "Code 6" along with the current thread ID to the console
        Console.WriteLine("Code 6" + Thread.CurrentThread.ManagedThreadId);

        // Waits for user input before exiting
        Console.Read();
    }
}
```

**Debug**

* **Adding Breakpoint:**

  * Locate the line where you want to add the breakpoint.
  * Click on the margin area next to the line number. A red circle should appear, indicating the breakpoint has been set.

* **Debugging the Breakpoint:**

  * Run your application in debug mode by pressing F5 or clicking on the Debug button in the toolbar.
  * When the execution reaches the line with the breakpoint, the program will pause, and the code execution will be halted at that point.

* **Checking Threads in Thread Window:**

  * While the execution is paused at the breakpoint, navigate to the "Debug" menu in Visual Studio.
  * From the Debug menu, select "Windows", then "Threads". Alternatively, you can use the shortcut Ctrl + Alt + H.
  * The "Threads" window should appear, showing you a list of threads currently running in your application.

**Explanation**

* **Example Scenario:**

  * Let's consider an example where asynchronous code includes segments executed before and after a delay operation.
  * Before the delay operation (Code 1 and Code 2), the thread ID is captured to identify the executing thread.
  * Similarly, after the delay operation (Code 5 and Code 6), the thread ID is captured again to compare with the initial thread.

* **Expected Behavior:**

  * Since the asynchronous operation is initiated from the main thread, it is expected that both Code 1 & Code 2 and Code 5 & Code 6 would execute on the same thread.
  * The thread ID captured before and after the delay operation should ideally be the same, indicating that the main thread continued its execution.

* **Observed Behavior:**

  * However, in certain scenarios, especially in environments where a Synchronization Context is not available or configured differently, asynchronous operations may execute on different threads.
  * In the example provided, Code 1 & Code 2 execute on the main thread (Thread ID 1), but Code 5 & Code 6 execute on a different thread (Thread ID 4).
  * This discrepancy in thread execution highlights the influence of Synchronization Context on the behavior of asynchronous operations.

**Conclusion:**

* Synchronization Context plays a pivotal role in determining how asynchronous operations are executed within a specific environment.
* Understanding the presence and behavior of Synchronization Context is essential for developers, particularly when working with asynchronous code in different frameworks or environments.
* By considering the role of Synchronization Context, developers can better understand and manage the behavior of asynchronous operations, ensuring optimal performance and behavior in their applications.