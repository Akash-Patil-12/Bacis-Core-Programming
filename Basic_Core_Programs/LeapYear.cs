using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_Core_Programs
{
    class LeapYear
    {   
        //variable
        int year;
        bool check;
        /// <summary>
        /// Take input as year and display leap year or not leap year
        /// </summary>
        public void LeapYearCheck()
        {
            Console.WriteLine("Enter a year it must be 4 digit");
            year = Convert.ToInt32(Console.ReadLine());
            if (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0))
                check = true;
            else
                check = false;
            if (check)
                Console.WriteLine("Entered year :" + year + " is Leap year");
            else
                Console.WriteLine("Entered year :" + year + " is not a Leap year");
        }
    }
}
