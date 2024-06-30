// Typically in C#, you need a Main method which serves as the entry point for the program. This Main method resides in a class or struct. However, starting with C# 9.0 and .NET 5, top-level statements are supported which allow you to simplify the code for programs such as console applications. By default every console app has a class Program with a Main method which is the starting point. When you run your app, CLR calls this Main method. You can only have one Main method for a project across all the namespaces and classes. So for this tutorial, we will just change the mehod's name to Main in the document that you want to run as we used one document per each video.  
// In this case, you don't explicitly define a Main method or a class. The compiler implicitly wraps this code in a Main method and a class. This feature is designed to make it easier to get started with coding in C#, especially for small programs and scripts where a single file is all you need. These are called top-level statements.
// In .NET we have this concept of solution `.sln` which has one or more projects. In a very simple app, your solution only has only one project. But as your project grows, you might have multiple projects each responsible for a different thing within a single solution. '
// In this solution "c#CourseByMosh.sln" we only have one project "FundamentalsByMosh" which is a console application.

// System namespace contains fundamental types and base classes that define commonly-used value and reference data types, events and event handlers, interfaces, attributes, and processing exceptions. Basically, all the utility classes and primitive types are in this namespace.
// Install Roslynator.Refactorings NuGet package to get more refactoring options in VS code like in Visual Studio. Run "dotnet add package Roslynator.Refactorings" in your project directory to install it.
// Once installed reload your developer window and you can see the refactoring options in the context menu by using the shortcut Ctrl + . or right-clicking on the code.


namespace FundamentalsByMosh
{
    class YourFirstCSharpApp
    {
        static void Main1 (string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

}


