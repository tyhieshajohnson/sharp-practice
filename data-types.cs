//C# Data Types
//As explained in the variables chapter, a variable in C# must be a specified data type:
using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      int myNum = 5;               // integer (whole number)
      double myDoubleNum = 5.99D;  // floating point number
      char myLetter = 'D';         // character
      bool myBool = true;          // boolean
      string myText = "Hello";     // string
      Console.WriteLine(myNum);
      Console.WriteLine(myDoubleNum);
      Console.WriteLine(myLetter);
      Console.WriteLine(myBool);
      Console.WriteLine(myText);
    }
  }
}

//Note: A data type specifies the size and type of variable values.
