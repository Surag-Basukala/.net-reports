using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Codes
{
    public class OddEven
    {
        public bool checkOddEven()
        {
            Console.WriteLine("Enter a number:");
            int num = Convert.ToInt32(Console.ReadLine());
            if(num%2 == 0)
                { return true; }
            return false;
        }
    }
}
