using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_30
{
    public class MethodOverloading
    {
        public void Add(int a, int b)
        {
            Console.WriteLine($"Addition of two integers: {a + b}");
        }

        public void Add(int a, int b, int c)
        {
            Console.WriteLine($"Addition of three integers: {a + b + c}");
        }
    }
}
