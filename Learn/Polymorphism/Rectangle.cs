namespace Polymorphism
{
    //Override Es necesario para ampliar o modificar la implementacion abstract o virtual de un metodo, propiedad, indexador o evento heredado.
    public class Rectangle : Shape
    {
        
        public double Height { get; set; }
        public double Width { get; set; }
        public Rectangle(double height, double width)
        {
            this.Height = height;
            this.Width = width;
        }            

        public override double Area()
        {
                return Height * Width;
        }

        public override string Draw()
        {
            return "Drawing Rectangle";
        }
    }
}