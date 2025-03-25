using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Codes
{
    public class Comparision
    {
        public void largest(int a, int b, int c)
        {
            if((a>b) & (a>c))
            {
                Console.WriteLine("The greatest number among "+a+", "+b+",and "+c+" is "+a);
            }
            else if(b>c)
            {
                Console.WriteLine("The greatest number among " + a + ", " + b + ",and " + c + " is " + b);
            }
            else
            {
                Console.WriteLine("The greatest number among " + a + ", " + b + ",and " + c + " is " + c);
            }
        }
    }
}
