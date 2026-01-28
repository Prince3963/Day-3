using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_30
{
    //Parent class
    public class InheritanceClass
    {
        public string? name;
        public int age;
        public string? country;
        public InheritanceClass()
        {
            Console.WriteLine("This is InheritClass class Constructor");
        }

        public void Display()
        {
            Console.WriteLine($"name = {name}, age = {age}, country = {country}");
        }
    }

    //Child class
    public class  Student : InheritanceClass
    {
        public Student()
        {
            Console.WriteLine("This is Student class Constructor");
        }
        public int Marks;
    }

    public class Teacher : InheritanceClass
    {
        public Teacher()
        {
            Console.WriteLine("This is Teacher class Constructor");
        }
        public int Salary;
    }
}
