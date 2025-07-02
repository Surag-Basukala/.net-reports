using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    public class Palindrome
    {
        public string checkPalindrome(int number)
        {
            int temp = number;

            int reverse = 0;
            while(number  > 0)
            {
                int digit = number % 10;
                reverse = (reverse * 10) + digit;
                number = number / 10;
            }
            
        if (temp == reverse)
            {
                return "The number is palindrome";
            }
            else
            {
                return "The number is not palindrome";
            }

        }
    }
}
