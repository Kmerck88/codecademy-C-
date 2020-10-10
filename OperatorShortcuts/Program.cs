using System;

namespace OperatorShortcuts
{
    class Program
    {
        static void Main(string[] args)
        {
    // declare steps variable
    int steps = 0; 



      // Two steps forward 
      int twoSteps = steps += 2; 


      // One step back 
      int oneStepBack = steps -=1;  


      // Print result to the console
      Console.WriteLine(steps); 

    }
}
}

