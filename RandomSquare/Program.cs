using System;
using System.Collections.Generic;

namespace RandomSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a loop that adds random numbers between 1-50
            Random rnd = new Random();
            var randomNumbers = new List<int>();
            var numbersSquared = new List<int>();
            var numbersSquaredEven = new List<int>();

            //create list of random Numbers
            for (int i = 0; i < 20; i++)
            {
                randomNumbers.Add(rnd.Next(1,50));
                
            }

            //square the numbers and add them to a list
            foreach (var number in randomNumbers)
            {
                numbersSquared.Add(number * number);
            }

            //Take the new squared list and remove all the odd numbers
            foreach (var numbersquared in numbersSquared)
            {
                if ( numbersquared % 2 == 0)
                {
                    numbersSquaredEven.Add(numbersquared);
                }
                
            }
            
            //Output the squared even numbers
            foreach (var numbersquaredeven in numbersSquaredEven)
            {
                Console.WriteLine(numbersquaredeven.ToString());
            } 
        }
    }
}
