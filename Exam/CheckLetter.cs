using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    public class CheckLetter
    {
        public string checkLetter(char ch)
        {
            if (ch >= 'A' && ch <= 'Z')
                return "The enter character is CAPITAL LETTER.";
            else if (ch >= 'a' && ch <= 'b')
                return "Ther entered character is small letter.";
            else if (ch >= '0' && ch <= '9')
                return "The entered character is number.";
            else
                return "The enter character is a special character.";

        }
    }
}
