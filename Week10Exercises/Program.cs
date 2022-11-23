using System;
using System.Collections.Generic;
using System.Linq;

namespace Week10Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> sequence = PositiveInt();
            Console.WriteLine("Sum: {0}", sequence.Sum());
            Console.WriteLine("Average: {0}", sequence.Average());
        }

        public static List<int> PositiveInt()
        {
            List<int> sequence = new List<int>();
            bool somethingEntered = true;

            while (somethingEntered == true)
            {
                Console.WriteLine("Please enter a positive integer: ");
                string userInput = Console.ReadLine();
                if (userInput == string.Empty)
                    somethingEntered = false;
                else
                {
                    int numberEntered = Convert.ToInt32(userInput);
                    if (numberEntered >= 1)
                    {
                        sequence.Add(numberEntered);
                    }
                    else if (numberEntered <= 0)
                    {
                        Console.WriteLine("Invalid entry. Please enter a positive integer greater than 1.");
                    }
                }
            }
            return sequence;

            /*
            Write a program that reads from the console a sequence of positive integer numbers. 
            The sequence ends when empty line is entered. 
            Calculate and print the sum and the average of the sequence. 
            Keep the sequence in List<int>.
            */






        }
    }
}
