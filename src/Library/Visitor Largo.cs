using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;


namespace Library
{
    public class Visitor_Largo : IVisitante<Persona>
    {
        

        private Persona Orpheus;

        public Visitor_Largo()
        {
            this.Orpheus= new Persona(9999999,"");
        }
        public int Visitar(Component<Persona> n){
            Node<Persona> i =n as Node<Persona>;
            
            
            int x = i.Generic.Name.Length;

            ReadOnlyCollection<Node<Persona>> lista= i.Children;


                
                if (this.Orpheus.Name.Length<x)
                {
                    this.Orpheus=i.Generic;

                }
                //Console.WriteLine(x);
                foreach (Node<Persona> y in lista){
                    x=this.Visitar(y);
                }   
            
            return this.Orpheus.Name.Length;
        }
        public void Isummonthi(){
            Console.WriteLine(this.Orpheus.Name +" tiene el nombre mas largo con "+this.Orpheus.Name.Length+" caracteres");
        }


    }
}
