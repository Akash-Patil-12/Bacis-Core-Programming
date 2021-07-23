using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_Core_Programs
{
    class Power
    {       
        //variable
        int no;
        /// <summary>
        /// Takes input as no and display the power 
        /// </summary>
        public void PowerShow()
        {
            Console.WriteLine("Enter a number");
            no = Convert.ToInt32(Console.ReadLine());
            for (int count = 0; count <= no; count++)
            {
                Console.WriteLine("Power of " + no + " ^ " + count + " :" + Math.Pow(no,count));
            }
        }
    }
}
