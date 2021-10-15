using System;
using CoreEscuela2.Entidades;

namespace CoreEscuela2
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("Platzi Academy", 1993, TiposEscuela.Primaria, pais:"Colombia", ciudad:"Medellin" );
            escuela.Ciudad = "Medellin";
            escuela.Pais = "Colombia";
            escuela.TipoEscuela = TiposEscuela.Primaria;

            var arregloCursos = new Curso[3];

            arregloCursos[0] =  new Curso() {  Nombre = "101" };
            arregloCursos[1] =  new Curso() {  Nombre = "201" };
            arregloCursos[2] =  new Curso() {  Nombre = "301" };
            

            Console.WriteLine(escuela.ToString());
            System.Console.WriteLine("------------");

            for (int i = 0; i < arregloCursos.Length; i++)
            {
                Console.WriteLine(arregloCursos[i].Nombre + "-" + arregloCursos[i].UniqueID );
                Console.WriteLine($"{arregloCursos[i].Nombre}-{arregloCursos[i].UniqueID}" ); // Ultimas versiones de C#
                Console.WriteLine("Presione ENTER para continuar");
                Console.ReadLine();
            }       
        }
    }
}
