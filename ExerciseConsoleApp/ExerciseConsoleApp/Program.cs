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
            int runningTotal = 0;
            bool keepGoing = true;
            
            while (keepGoing) {
                int userChoice = UserInput1.GetInt32("How many minutes did you exercise? ");

                runningTotal += userChoice;

                Console.WriteLine("You have exercised {0} minutes.", runningTotal);

                if(runningTotal >= 86)
                {
                    Console.WriteLine("Show off");
                }
                else if(runningTotal >= 60)
                {
                    Console.WriteLine("Nice work");
                }
                else
                {
                    Console.WriteLine("Well, something is better than nothing.");
                }

                Console.WriteLine("Would you like to add more time or enter \"quit\"? ");
                string moreInput = Console.ReadLine();
                if (moreInput.Equals("quit"))
                    keepGoing = false;
            }


        }
    }
}
