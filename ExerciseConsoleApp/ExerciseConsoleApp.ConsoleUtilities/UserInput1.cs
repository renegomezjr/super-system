﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseConsoleApp.ConsoleUtilities
{
    public static class UserInput1
    {
        public static int GetInt32(string prompt)
        {
            bool validInput = false;
            int returnValue = 0;

            while (!validInput)
            {
                Console.Write(prompt);
                validInput = int.TryParse(Console.ReadLine(), out returnValue);

                if (!validInput)
                {
                    Console.WriteLine("That was not an integer.\n");
                }
            }

            return returnValue;

        }
    }
}
