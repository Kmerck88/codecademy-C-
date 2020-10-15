using System;

namespace Built_InMethods
{
    class Program
    {
        static void Main(string[] args)
        {
           // Starting variables 
      int numberOne = 12932;
      int numberTwo = -2828472;

      // Use built-in methods and save to variable 
  Math.Floor(Math.Sqrt(Math.Abs(numberOne)));


      // Use built-in methods and save to variable 
 Math.Floor(Math.Sqrt(Math.Abs(numberTwo)));


      // Print the lowest number

      Console.WriteLine(Math.Min(numberOne, numberTwo)); 
        }
    }
}
