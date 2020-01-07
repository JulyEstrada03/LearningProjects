using System;
using System.Collections.Generic;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Polimorfismo!");
            Console.WriteLine("Es la habilidad de presentar la misma interface de diferente forma.");
            Console.WriteLine("Type Polimorfismo!");
            Console.WriteLine("1. Static / Compile time");

            TestData dataClass = new TestData();
            int add2 = dataClass.Add(45, 34, 67);  
            int add1 = dataClass.Add(23, 34);      

            Console.WriteLine("int add2 = dataClass.Add(45, 34, 67);");
            Console.WriteLine("int add1 = dataClass.Add(23, 34);");   
            
            Console.WriteLine("2. Dynamic / Runtime");


            List<Shape> ShapeList = new List<Shape>();
            Shape circle = new Circle();            
            Shape Rectangle = new Rectangle(5.3,3.4);
            Shape Square = new Square();
            ShapeList.Add(circle);
            ShapeList.Add(Rectangle);
            ShapeList.Add(Square);

            Console.WriteLine("Area:" + circle.Area());
            Console.WriteLine("Area:" + Rectangle.Area());
            Console.WriteLine("Area:" + Square.Area());

            foreach (Shape shape in ShapeList)
            {
               Console.WriteLine(shape.Draw());
            }

           
        }
    }
}
