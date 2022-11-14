using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class Persona
    {
        public string Name  {get; set;}
        public int Age{get; set;}


        public Persona(int edad,string nombre)
        {
            this.Age = edad;
            this.Name = nombre;
        }


        
    }
}
