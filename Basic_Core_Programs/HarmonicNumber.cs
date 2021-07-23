using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_Core_Programs
{
    class HarmonicNumber
    {
        //variable
        decimal no, result;
        bool check = false;
        /// <summary>
        /// Takes input as no and display harmonic series and value 
        /// </summary>
        public void HarmonicSeries()
        {
            Console.WriteLine("Enter a number");
            no = Convert.ToInt32(Console.ReadLine());
            if (no <= 0)
            {
                Console.WriteLine("Enter number which is gratter than 0");
            }
            else
            {
                for (decimal count = 1; count <= no; count++)
                {
                    if (check == false)
                    {
                        Console.Write(1 + "/" + count);
                        result += (1 / count);
                        check = true;
                    }
                    else
                    {
                        Console.Write(" + " + 1 + "/" + count);
                        result += (1 / count);
                    }
                }
                Console.WriteLine();
                Console.WriteLine("Harmonic value is : " + result);
            }
        }
    }
}