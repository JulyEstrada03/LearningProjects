using System;

namespace Polymorphism
{
    //Override Es necesario para ampliar o modificar la implementacion abstract o virtual de un metodo, propiedad, indexador o evento heredado.
    public class Circle : Shape
    {
        public double Radius { get; set; }  
        public Circle()  
        {  
            Radius = 5;  
        }  
        public override double Area()  
        {  
            return (3.14) * Math.Pow(Radius, 2);  
        }  
        public override string Draw()
        {
            return "Drawing Circle";
        }
    }
}