using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_Core_Programs
{
    class ThreeNumber
    {
        //variable
        int number1 = 20, number2 = 30, number3 = 10;
        /// <summary>
        /// Display largest number amoung three number
        /// </summary>
        public void CheckLargest()
        {
            if (number1 > number2 && number1 > number3)
                Console.WriteLine(number1 + " is largest");
            if (number2 > number1 && number2 > number3)
                Console.WriteLine(number2 + " is largest");
            if (number3 > number1 && number3 > number2)
                Console.WriteLine(number3 + " is largest");
        }
    }
   
}
