//Line 1: using System means that we can use classes from the System namespace.
using System;
//Line 2: A blank line. C# ignores white space. However, multiple lines make the code more readable.

//Line 3: namespace is used to organize your code, and it is a container for classes and other namespaces.
namespace HelloWorld
//Line 4: The curly braces {} mark the beginning and the end of a block of code.
{
  //Line 5: class is a container for data and methods, which brings functionality to your program. 
  //Every line of code that runs in C# must be inside a class. In our example, we named the class Program.
  class Program
  {
    //Line 7: Another thing that always appears in a C# program is the Main method. Any code inside its curly brackets {} will be executed. 
    //You don't have to understand the keywords before and after Main. You will get to know them bit by bit while reading this tutorial.
    static void Main(string[] args)
    {
      //Line 9: Console is a class of the System namespace, which has a WriteLine() method that is used to output/print text. In our example, it will output "Hello World!".
      Console.WriteLine("Hello World!");    
    }
  }
}

//If you omit the using System line, you would have to write System.Console.WriteLine() to print/output text.

//Notes:
//Every C# statement ends with a semicolon ;
//C# is case-sensitive; "MyClass" and "myclass" have different meaning.
