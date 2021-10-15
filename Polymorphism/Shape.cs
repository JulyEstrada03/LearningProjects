namespace Polymorphism
{
    public class Shape
    {
        // Virtual se usa para modificar una declaración de metodo, propiedad, indizador o evento y permitir que se invalide en una clase derivada. 
        //in this case. We can override Area and Draw methods in the class that inherit of Shape.
        public virtual double Area()
        {
            return 0;
        }     

        public virtual string Draw()
        {
            return string.Empty;
        }       
    }
}