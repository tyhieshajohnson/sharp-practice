//C# Constants
//If you don't want others (or yourself) to overwrite existing values, you can add the const keyword in front of the variable type.
//This will declare the variable as "constant", which means unchangeable and read-only:
using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      const int myNum = 15;
      myNum = 20;
      Console.WriteLine(myNum);
    }
  }
}

//Note: You cannot declare a constant variable without assigning the value. If you do, an error will occur: A const field requires a value to be provided.

