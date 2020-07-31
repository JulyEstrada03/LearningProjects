using System;

namespace CoreEscuela
{
    class Escuela // Plantilla
    {
        //Atributos
        private string nombre;
        private string direccion;
        private int añoFundacion; // Pulicultural 

        //Encapsulamiento
        public string Nombre
        { 
            get{ return nombre;}  
            set{ nombre = value;}
        }
        public string Direccion{ get; set;}
        public int AñoFundacion{ get; set;}

        //Metodos o Funciones
        public void Timbrar(){ Console.Beep(2000,3000); }

    }
    class Program
    {        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var miEscuela = new Escuela();
            miEscuela.Nombre = "Platzi";
            miEscuela.Direccion = "Calle 128 sur";
            miEscuela.AñoFundacion = 1993;
            Console.WriteLine("Timbrandooo");
            miEscuela.Timbrar();
            
        }
    }
}
