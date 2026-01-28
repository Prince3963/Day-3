using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_30
{
    public class MethodHiding
    {
        public void Display()
        {
            Console.WriteLine("Base Class");
        }
    }

    public class DerivedClass() : MethodHiding
    {
        public new void Display()
        {
            Console.WriteLine("Derived Class");
        }
    }
}
