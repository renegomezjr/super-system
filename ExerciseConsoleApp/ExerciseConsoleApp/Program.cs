using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExerciseConsoleApp.ConsoleUtilities;

namespace ExerciseConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int runningTotal = 10;
            int userChoice = UserInput1.GetInt32("How many minutes would you like to exercise? ");
     

            runningTotal += userChoice;

            Console.WriteLine("You have exercised {0} minutes.", runningTotal);



        }
    }
}
