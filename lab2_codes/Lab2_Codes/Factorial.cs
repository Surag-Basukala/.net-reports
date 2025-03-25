using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Codes
{
    public class Factorial
    {
        public void calcFactorial()
        {
            int i = 0, fact = 1;
            Console.WriteLine("Enter the number whose factorial to find: ");
            int input = Convert.ToInt32(Console.ReadLine());
            for(i=1;i<=input;i++)
            {
                fact = fact * i;
            }
            Console.WriteLine("The factorial of " + input + " is " + fact);
        }
    }
}
