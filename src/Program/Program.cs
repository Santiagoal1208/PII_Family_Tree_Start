using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona p1= new Persona(16,"Juan");
            Persona p2= new Persona(6,"Pedro");
            Persona p3= new Persona(85,"Ana");
            Persona p4= new Persona(52,"Raul");
            Persona p5= new Persona(47,"Alvaro");
            Persona p6= new Persona(29,"Lucifer");
            Persona p7= new Persona(22,"Lucia");
            Persona p8= new Persona(14,"Luciano");
            Node<Persona> n1 = new Node<Persona>();
            Node<Persona> n2 = new Node<Persona>();
            Node<Persona> n3 = new Node<Persona>();
            Node<Persona> n4 = new Node<Persona>();
            Node<Persona> n5 = new Node<Persona>();
            Node<Persona> n6 = new Node<Persona>();
            Node<Persona> n7 = new Node<Persona>();
            Node<Persona> n8 = new Node<Persona>();
            Visitor_Suma v = new Visitor_Suma();
            Visitor_Viejo v2 = new Visitor_Viejo();
            Visitor_Largo v3 = new Visitor_Largo();

            n1.Agregar(p1);
            n2.Agregar(p2);
            n3.Agregar(p3);
            n4.Agregar(p4);
            n5.Agregar(p5);
            n6.Agregar(p6);
            n7.Agregar(p7);
            n8.Agregar(p8);
            

            n3.AddChildren(n4);
            n3.AddChildren(n5);

            n4.AddChildren(n6);
            n4.AddChildren(n7);

            n5.AddChildren(n8);
            n5.AddChildren(n1);

            n6.AddChildren(n2);

            int w=n3.Aceptar(v);
            Console.WriteLine(w);
            n3.Aceptar(v2);
            v2.Isummonthi();
            n3.Aceptar(v3);
            v3.Isummonthi();
            // visitar el árbol aquí
        }
    }
}
