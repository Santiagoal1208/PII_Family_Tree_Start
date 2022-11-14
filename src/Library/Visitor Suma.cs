using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;


namespace Library
{
    public class Visitor_Suma : IVisitante<Persona>
    {
        

        

        public int Visitar(Component<Persona> n){
            Node<Persona> i =n as Node<Persona>;
            int x = 0;
            ReadOnlyCollection<Node<Persona>> lista= i.Children;

            if ((lista == null) || (lista.Count < 1))
            {
                x=x+i.Generic.Age;
            } else {
                x=x+i.Generic.Age;
                //Console.WriteLine(x);
                foreach (Node<Persona> y in lista){
                    x=x+this.Visitar(y);
                }   
            }
            return x;
        }
        


    }
}

