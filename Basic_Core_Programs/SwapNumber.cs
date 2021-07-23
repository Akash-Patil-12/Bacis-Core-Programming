using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_Core_Programs
{
    class SwapNumber
    {
        //variable
        int number1 = 10, number2 = 20;
        /// <summary>
        /// swap to numbers without using other number 
        /// </summary>
        public void Swap()
        {
            Console.WriteLine("Before swaping number1 :" + number1 + " number2 :" + number2);
            number1 = number1 + number2;
            number2 = number1 - number2;
            number1 = number1 - number2;
            Console.WriteLine("After swaping number1 :" + number1 + " number2 :" + number2);
        }
    }
}