//C# Type Casting
//Type casting is when you assign a value of one data type to another type.

//In C#, there are two types of casting:

//Implicit Casting (automatically) - converting a smaller type to a larger type size
//char -> int -> long -> float -> double
using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      int myInt = 9;
      double myDouble = myInt;  // Automatic casting: int to double

      Console.WriteLine(myInt);
      Console.WriteLine(myDouble);
    }
  }
}

//Explicit Casting (manually) - converting a larger type to a smaller size type
//double -> float -> long -> int -> char
using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      double myDouble = 9.78;
      int myInt = (int) myDouble;  // Manual casting: double to int

      Console.WriteLine(myDouble);
      Console.WriteLine(myInt);
    }
  }
}

//Type Conversion Methods
//It is also possible to convert data types explicitly by using built-in methods, such as Convert.ToBoolean, Convert.ToDouble, Convert.ToString, Convert.ToInt32 (int) and Convert.ToInt64 (long):
using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      int myInt = 10;
      double myDouble = 5.25;
      bool myBool = true;

      Console.WriteLine(Convert.ToString(myInt));    // Convert int to string
      Console.WriteLine(Convert.ToDouble(myInt));    // Convert int to double
      Console.WriteLine(Convert.ToInt32(myDouble));  // Convert double to int
      Console.WriteLine(Convert.ToString(myBool));   // Convert bool to string
      }
  }
}

//Why Conversion?
//Many times, there's no need for type conversion. But sometimes you have to. Take a look at the next chapter, when working with user input, to see an example of this.
