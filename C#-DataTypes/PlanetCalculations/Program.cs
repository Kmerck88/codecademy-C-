using System;

namespace PlanetCalculations
{
    class Program
    {
        static void Main(string[] args)
        {
            // Your Age
      int userAge = 32; 


      // Length of years on Jupiter (in Earth years)
      double jupiterYears = 11.86; 


      // Age on Jupiter
     double jupiterAge = userAge / jupiterYears; 


      // Time to Jupiter
     double journeyToJupiter =  6.142466; 

      // New Age on Earth
      //We can find our new age on Earth by adding the time it took to get to Jupiter to our current age:
      double newEarthAge = userAge + journeyToJupiter;



      // New Age on Jupiter
    
double newJupiterAge = newEarthAge / jupiterYears; 

      // Log calculations to console
      Console.WriteLine(jupiterYears);
      Console.WriteLine(newEarthAge);
      Console.WriteLine(newJupiterAge);
        }
    }
}
