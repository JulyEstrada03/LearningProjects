namespace  CoreEscuela2.Entidades
{
    class Escuela
    {
        //Atributos
        string nombre;
        string ciudad;

        //Propiedades
        public string Nombre
        {
            get { return nombre;}
            set { nombre = value.ToUpper();}
        }

        public int AñoDeCreacion { get; set;}
        public string Pais { get; set; }
        public string Ciudad  { get; set; }
        public TiposEscuela TipoEscuela { get; set; }

        //Constructor
        /* public Escuela(string nombre, int añoDeCreacion)
        {
            this.nombre = nombre;
            this.AñoDeCreacion = añoDeCreacion;
        }
        */

        // Constructor por tuplas
        public Escuela(string nombre, int añoDeCreacion) => (Nombre, AñoDeCreacion) = (nombre, añoDeCreacion);

        // Constructor con parametros opcionales (Pais y Ciudad)
        public Escuela(string nombre, int añoDeCreacion, TiposEscuela tipos, string pais = "", string ciudad = "") 
        {
            (Nombre, AñoDeCreacion) = (nombre, añoDeCreacion);
            Pais = pais;
            this.ciudad = Ciudad;
        } 

        public override string ToString()
        {
            // \n = System.Environment.NewLine 
            return $"Nombre:{Nombre}, Tipo:{TipoEscuela}, \n Pais: {Pais}, Ciudad:{Ciudad}";
        }

    }
}