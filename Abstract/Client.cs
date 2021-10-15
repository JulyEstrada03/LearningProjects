namespace Abstract
{
    // Definir las caracteristicas que van a tener la jerárquia.
    public abstract class Client
    {
        public abstract int Id { get; set; }
        public abstract string Name { get; set; } 

        public abstract string GetName();      
    }
}