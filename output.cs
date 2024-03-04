//C# Output
//To output values or print text in C#, you can use the WriteLine() method:
using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!"); /* to output values or print text*/
    }
  }
}

//You can add as many WriteLine() methods as you want. Note that it will add a new line for each method:
using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      Console.WriteLine("I am Learning C#");
      Console.WriteLine("It is awesome!");
    }
  }
}

//You can also output numbers, and perform mathematical calculations:
using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine(3 + 3);
    }
  }
}

//The Write Line Method:
//There is also a Write() method, which is similar to WriteLine().
//The only difference is that it does not insert a new line at the end of the output:

using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Write("Hello World! ");
      Console.Write("I will print on the same line.");
    }
  }
}
//Note that we add an extra space when needed (after "Hello World!" in the example above), for better readability.
