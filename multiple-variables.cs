//C# Multiple Variables
//Declare Many Variables
//To declare more than one variable of the same type, use a comma-separated list:

using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      int x = 5, y = 6, z = 50;
      Console.WriteLine(x + y + z);
    }
  }
}

//You can also assign the same value to multiple variables in one line:
using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      int x, y, z;
      x = y = z = 50;
      Console.WriteLine(x + y + z);
    }
  }
}

//
