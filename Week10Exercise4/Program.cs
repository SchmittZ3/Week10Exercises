using System;
using System.Collections.Generic;

namespace Week10Exercise4
{
    internal class Program
    {
        //Write a program to remove from a sequence all the integers, which appear **odd number of times.**
        static void Main(string[] args)
        {
            int[] numbers = { 4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2, 6, 6, 6 };
            Dictionary<int, int> numCount = new Dictionary<int, int>();
            foreach (int number in numbers)
            {
                if (numCount.ContainsKey(number))
                {
                    numCount[number]++;
                }
                else
                {
                    numCount.Add(number, 1);
                }
            }

            foreach (var number in numCount)
            {
                if (number.Value % 2 != 0)
                {
                    numCount.Remove(number.Key);
                }
            }

            foreach (var number in numCount)
            {
                Console.Write("{0},", number.Key);
            }
        }


    }
}
