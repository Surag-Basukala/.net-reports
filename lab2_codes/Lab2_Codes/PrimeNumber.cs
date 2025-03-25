using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Codes
{
    public class PrimeNumber
    {
        public void checkPrimeNumber()
        {
            Console.WriteLine("Enter a number:");
            int input = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            for(int i=1;i<=input;i++)
            {
                if(input%i == 0)
                {
                    count++;
                }
            }
            if(count == 2)
            {
                Console.WriteLine(input+" is a prime number.");
            }
            else
            {
                Console.WriteLine(input + " is not a prime number.");
            }
        }
    }
}
