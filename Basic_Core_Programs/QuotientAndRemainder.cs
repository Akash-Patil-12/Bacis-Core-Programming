using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_Core_Programs
{
    class QuotientAndRemainder
    {
        //variable
        int quotient, remainder;
               /// <summary>
        /// Display quotient and remainder  
        /// </summary>
        public void MathOperation()
        {
            Console.WriteLine("Enter a value of divident");
            int divident = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a value of divisor");
            int divisor = Convert.ToInt32(Console.ReadLine());
            quotient = divident / divisor;
            remainder = divident % divisor;
            Console.WriteLine("Quotient :" + quotient);
            Console.WriteLine("Remainder :" + remainder);
        }
    }
}