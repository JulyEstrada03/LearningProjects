using System;

namespace Polymorphism
{
    //Override Es necesario para ampliar o modificar la implementacion abstract o virtual de un metodo, propiedad, indexador o evento heredado.
    public class Square : Shape
    {
        public double Length { get; set; }  
        public Square()  
        {  
            Length = 6;  
        }  
        public override double Area()  
        {  
            return Math.Pow(Length, 2);  
        }  

        public override string Draw()
        {
            return "Drawing Square";
        }
    }
}