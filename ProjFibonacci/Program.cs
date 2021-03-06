﻿using System;
using System.Collections.Generic;

/// <summary>
/// Joshua Kaluba
/// 2016-03-19
/// My solution to the Fibonacci problem posted at https://projecteuler.net/problem=2
/// The problem is listed below:
/// Each new term in the Fibonacci sequence is generated by adding the previous two terms. 
/// By starting with 1 and 2, the first 10 terms will be:
/// 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...
/// By considering the terms in the Fibonacci sequence whose values do not exceed four million, 
/// find the sum of the even-valued terms.
/// </summary>

namespace ProjFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare a list to store the Fibonacci number sequence
            List<int> numbers = new List<int>();

            //Int to store our next number in our Fibonacci sequence
            int nextNumber = 0;

            //Starting index for the Numbers list
            int index = 1;

            //Int to store the sum of all even numbers in our Fibonacci sequence
            int result = 0;


            //Begin the list by adding the first numbers in the sequence
            numbers.Add(0);
            numbers.Add(1);

            //run the loop till 4million
            while (nextNumber < 4000000)
            {
                if (nextNumber % 2 == 0)
                {
                    //if our number is even, add to result
                    result = result + nextNumber;
                }

                //retrieve the next number in the Fibonacci sequence by adding the previous 2
                nextNumber = numbers[index] + numbers[index - 1];

                //add the next number to the list if our result is less than 4 million
                if(nextNumber<4000000)
                {
                    numbers.Add(nextNumber);                    
                }
                
                //increment the index
                index++;
            }

            Console.WriteLine(result.ToString());
            //Outputs 4613732.

            Console.Read();
        }
        
    }
}
