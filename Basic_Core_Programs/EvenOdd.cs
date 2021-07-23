using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_Core_Programs
{
    class EvenOdd
    {
        //variable
        int number;
        /// <summary>
        /// check number is even or odd
        /// </summary>
        public void CheckNumber()
        {
            Console.WriteLine("Enter a number");
            number = Convert.ToInt32(Console.ReadLine());
            if (number % 2 == 0)
                Console.WriteLine(number + " is even number");
            else
                Console.WriteLine(number + " is odd number");

        }
    }
}