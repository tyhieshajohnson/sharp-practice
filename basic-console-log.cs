// Using directive to include the System namespace, which contains fundamental classes like Console
// The most common use of using is to import namespaces
//The using directive allows you to bring the types (classes, interfaces, etc.) defined in a namespace into scope, so you can refer to them without using the fully qualified name.
using System;

// Declaring a namespace named "HelloWorld" to organize code
//"namespace" is a way to organize and group related code elements, such as classes, structs, interfaces, enums, and other namespaces.
//It helps in avoiding naming conflicts between different parts of your code and enables you to organize your code hierarchically.
namespace HelloWorld
{
    // Declaring a class named "Program" inside the namespace
    //A class is a fundamental building block of object-oriented programming (OOP)
    class Program
    {
        // Main method, the entry point of the program
        // static: This keyword indicates that the method or member belongs to the type itself rather than to an instance of the type.
        // void: This is the return type of the method.
        static void Main(string[] args)
        {
            // Writing a message to the console
            // Main: refers to the entry point of a C# console application. It is the method that gets executed when the program is run.
            Console.WriteLine("Tyhiesha Johnson");
        }
    }
}
