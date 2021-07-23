using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_Core_Programs
{
    class FactorePrime
    {
        //variable
        int no;
        bool check;
        /// <summary>
        /// Display prime factorial of given number  
        /// </summary>
        public void Factorials()
        {
            Console.WriteLine("Enter a number");
            no = Convert.ToInt32(Console.ReadLine());
            if (no == 0)
            {
                Console.WriteLine("Enter number which is gratter than 0");
            }
            else
            {
                Console.WriteLine("Prime Factorials are as listed below");
                for (int count = 1; count <= no; count++)
                {
                    check = true;
                    if (count == 1)
                        continue;
                    else
                    {
                        for (int no = 2; no < count; no++)
                        {
                            if (count % no == 0)
                            {
                                check = false;
                                break;
                            }
                        }
                        if (check == true)
                            Console.WriteLine(count);
                    }
                }
            }
        }
    }
}