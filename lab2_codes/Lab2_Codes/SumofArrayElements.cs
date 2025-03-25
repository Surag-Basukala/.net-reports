using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Codes
{
    public class SumofArrayElements
    {
        public void sumOfArrayElements()
        {
            int[] array = { 1, 5, 3, 8, 9 };
            int i = 0,sum = 0;
            for(i=0;i<array.Length; i++)
            {
                sum += array[i];
            }
            Console.WriteLine("The sum of the array elements is "+sum);

        }
    }
}
