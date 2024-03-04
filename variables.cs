//C# Variables
//Variables are containers for storing data values.

//In C#, there are different types of variables (defined with different keywords), for example:

//1. int - stores integers (whole numbers), without decimals, such as 123 or -123
//2. double - stores floating point numbers, with decimals, such as 19.99 or -19.99
//3. char - stores single characters, such as 'a' or 'B'. Char values are surrounded by single quotes
//4. string - stores text, such as "Hello World". String values are surrounded by double quotes
//5. bool - stores values with two states: true or false

//Declaring (Creating) Variables:
//To create a variable, you must specify the type and assign it a value:
//Syntax: type variableName = value;

//Where type is a C# type (such as int or string), and variableName is the name of the variable (such as x or name). The equal sign is used to assign values to the variable.
using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      string name = "Tyhiesha";
      Console.WriteLine(name);  
     }
  }
}

//To create a variable that should store a number, look at the following example:
using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      int myNum = 15;
      Console.WriteLine(myNum);
     }
  }
}

//You can also declare a variable without assigning the value, and assign the value later:
using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      int myNum;
      myNum = 15;
      Console.WriteLine(myNum);
     }
  }
}

//Note that if you assign a new value to an existing variable, it will overwrite the previous value:

//Other types:
using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      double myDoubleNum = 5.99D;
      Console.WriteLine(myDoubleNum);
     }
  }
}

using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      char myLetter = 'D';
      Console.WriteLine(myLetter);
     }
  }
}

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      bool myBool = true;
      Console.WriteLine(myBool);
     }
  }
}

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      string myText = "Hello";
      Console.WriteLine(myText);
     }
  }
}

//
