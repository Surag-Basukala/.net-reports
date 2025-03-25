using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Codes
{
    public class IsLeapYear
    {
        public void isLeapYear()
        {
            Console.Write("Enter a year: ");
            int year = Convert.ToInt32(Console.ReadLine());

            if (year % 4 == 0)
            {
                if (year % 100 == 0)
                {
                    if (year % 400 == 0)
                    {
                        Console.WriteLine("Leap Year");
                    }
                    else
                    {
                        Console.WriteLine("Not a Leap Year");
                    }
                }
                else
                {
                    Console.WriteLine("Leap Year");
                }
            }
            else
            {
                Console.WriteLine("Not A Leap Year");
            }

        }
    }
}