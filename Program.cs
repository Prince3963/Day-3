// See https://aka.ms/new-console-template for more information

using _21_30;
using static _21_30.Pollymorphism;

public class Program
{
    private static void Main(string[] args)
    {
        //Student student = new Student();

        //Console.WriteLine();

        //Console.WriteLine("-----------------------------------------");
        //Console.WriteLine("Assigning values to Student class object properties");
        //student.name = "John";
        //student.age = 20;
        //student.country = "USA";
        //student.Marks = 95;
        //Console.WriteLine();
        //student.Display();

        //Console.WriteLine("-----------------------------------------");

        //Teacher teacher = new Teacher();
        //Console.WriteLine();
        //Console.WriteLine("-----------------------------------------");
        //Console.WriteLine("Assigning values to Teacher class object properties");
        //teacher.name = "Sneha";
        //teacher.age = 26;
        //teacher.country = "India";
        //teacher.Salary = 50000;
        //Console.WriteLine();
        //teacher.Display();
        Console.WriteLine("-----------------------------------------");


        //MethodHiding m = new MethodHiding();
        //DerivedClass d = new DerivedClass();
        //MethodHiding md = new DerivedClass();


        //m.Display();
        //d.Display();
        //md.Display();

        Pollymorphism[] poly = new Pollymorphism[4];

        poly[0] = new Pollymorphism();
        poly[1] = new Example();
        poly[2] = new Example2();
        poly[3] = new Example3();

        foreach (var p in poly)
        {
            p.Display();
        }
    }
}