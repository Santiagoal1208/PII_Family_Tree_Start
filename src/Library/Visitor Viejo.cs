using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;


namespace Library
{
    public class Visitor_Viejo : IVisitante<Persona>
    {
        

        private Persona Orpheus;

        private int años;
        private bool primero;

        public Visitor_Viejo()
        {
            this.primero=false;
        }

        public int Visitar(Component<Persona> n){
            Node<Persona> i =n as Node<Persona>;
            
            
            int x = i.Generic.Age;

            ReadOnlyCollection<Node<Persona>> lista= i.Children;


                
                if (this.años<x && this.primero)
                {
                    this.Orpheus=i.Generic;
                    this.años=x;
                }
                this.primero=true;
                //Console.WriteLine(x);
                foreach (Node<Persona> y in lista){
                    x=this.Visitar(y);
                }   
            
            return this.años;
        }
        public void Isummonthi(){
            Console.WriteLine("El hijo mayor es "+this.Orpheus.Name+" con "+this.Orpheus.Age+" años");
        }


    }
}
