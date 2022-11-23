using System;
using System.Collections.Generic;
using System.Linq;

namespace Week10Exercise3
{
    //Write a program that counts, in a given array of integers, the **number of occurrences of each integer.**
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 3, 4, 4, 2, 3, 3, 4, 3, 2 };
            Array.Sort(numbers);
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
                Console.WriteLine("|{0} -> {1} times|", number.Key, number.Value);
            }
        }
    }
}
