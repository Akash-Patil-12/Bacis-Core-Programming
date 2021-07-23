using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_Core_Programs
{
    class Flip_Coin
    {
        Random random = new Random();
        //constants
        double TOTAL = 20;
        //varibles
        double countHead = 0, countTail = 0;
        double headPercentage, tailPercentage;
        /// <summary>
        /// count head and tail and also display percentage of it
        /// </summary>
        public void FlipCoin()
        {
            for (int count = 1; count <= TOTAL; count++)
            {
                double randomNumber = random.NextDouble();
                if (randomNumber < 0.5)
                    countHead++;
                else
                    countTail++;
            }
            Console.WriteLine("Head :" + countHead + " Tail :" + countTail);
            headPercentage = (countHead / TOTAL) * 100;
            tailPercentage = (countTail / TOTAL) * 100;
            Console.WriteLine("Percentage of Head is : " + headPercentage);
            Console.WriteLine("Percentage of Tail is :" + tailPercentage);
        }
    }
}
