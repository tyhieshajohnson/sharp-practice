//Get User Input
//You have already learned that Console.WriteLine() is used to output (print) values. Now we will use Console.ReadLine() to get user input.
//In the following example, the user can input his or hers username, which is stored in the variable userName. Then we print the value of userName
using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      // Type your username and press enter
      Console.WriteLine("Enter username:");

      // Create a string variable and get user input from the keyboard and store it in the variable
      string userName = Console.ReadLine();

      // Print the value of the variable (userName), which will display the input value
      Console.WriteLine("Username is: " + userName);
    }
  }
}

//User Input and Numbers
//The Console.ReadLine() method returns a string. Therefore, you cannot get information from another data type, such as int. The following program will cause an error:
Console.WriteLine("Enter your age:");
int age = Console.ReadLine();
Console.WriteLine("Your age is: " + age);
//Note: Cannot implicitly convert type 'string' to 'int'

//Luckily, for you, you just learned from the previous chapter (Type Casting), that you can convert any type explicitly, by using one of the Convert.To methods:
using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Enter your age:");
      int age = Convert.ToInt32(Console.ReadLine()); /*The ToInt32 method in the provided code snippet is used to convert a user input, which is initially read as a string, into a 32-bit signed integer (int). */
      Console.WriteLine("Your age is: " + age);
    }
  }
}


