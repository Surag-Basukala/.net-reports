using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Codes
{
    public class SumOfNaturalNumbers
    {
        public void naturalNumberSum()
        {
            int sum = 0,i = 0;
            Console.WriteLine("Enter the value of number of terms(n)");
            int n = Convert.ToInt32(Console.ReadLine());
            for(i=1;i<=n;i++)
            {
                sum = sum + i;
            }
            Console.WriteLine("The sum of natural number upto " + n + " is " + sum);
        }
    }
}
