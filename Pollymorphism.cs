using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_30
{
    public class Pollymorphism
    {
        public string? name = "test";

        public virtual void Display()
        {
            Console.WriteLine($"name = {name}");
        }
    }
    public class Example : Pollymorphism
    {
        public override void Display()
        {
            Console.WriteLine($"name = {name}, Example");
        }
    }

    public class Example2 : Pollymorphism
    {
        public override void Display()
        {
            Console.WriteLine($"name = {name}, Example2");
        }
    }

    public class Example3 : Pollymorphism
    {
        public override void Display()
        {
            Console.WriteLine($"name = {name}, Example3");
        }
    }

}
