using System;

namespace CoreEscuela2.Entidades
{
    public class Curso
    {
        public string Nombre {get; set;} 
        public string UniqueID {get; private set;}// Solo puedo asignar el valor dentro de esta clase.
      
       public TiposJornada TiposJornada {get; set;}
        

        /* Constructor por tuplas
        public Curso()
        {
            UniqueID = Guid.NewGuid().ToString();
        } 
        */

        public Curso() => UniqueID = Guid.NewGuid().ToString();
        
    }
}