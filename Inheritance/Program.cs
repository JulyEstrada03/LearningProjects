using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
           
            C c = new C();
            c.Name = "Class C";
            c.Location = "Colombia";
            c.Age = 26;

            Console.WriteLine(c.GetName());
            Console.WriteLine(c.GetLocation());
            Console.WriteLine(c.GetAge());
        }
    }
}
