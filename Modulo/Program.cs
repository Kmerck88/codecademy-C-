using System;

namespace Modulo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            /*You’re teaching computer science in a classroom and need to break up your students into teams.

The groups should have more than 2 students in each group, but no more than 5.*/
            int students = 18; 

            int groupSize = 4; 

            Console.WriteLine(students % groupSize); 
        }
    }
}
