using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    interface IMultipleInheritance
    {
        void Dog();
        
    }

    interface IMultipleInheritance2

    {
        void Cat();
        
    }

    class DerivedClass : IMultipleInheritance,IMultipleInheritance2
    {
        public void Dog()
        {
            Console.WriteLine("Dog Barks");
        }
        public void Cat()
        {
            Console.WriteLine("Cat Meows");
        }
    }
}
