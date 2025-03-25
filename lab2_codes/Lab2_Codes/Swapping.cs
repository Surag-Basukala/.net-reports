using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Codes
{
    public class Swapping
    {
        public void swapping(int a, int b)
        {
            Console.WriteLine("The number before swapping are " + a +" and " + b);
            int temp = 0;
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine("The number after swapping are  " + a +" and " + b);
        }
        
    }
}
