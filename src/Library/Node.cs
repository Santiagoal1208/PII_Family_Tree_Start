using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class Node<T> : Component<T>
    {
        private T generic;

        private List<Node<T>> children = new List<Node<T>>();

        public T Generic {
            get
            {
                return this.generic;
            }
        }

        public ReadOnlyCollection<Node<T>> Children { 
            get
            {
                return this.children.AsReadOnly();
            }
        }

        public Node()
        {
            
        }
        public void Agregar(T t)
        {
            this.generic = t;
        }
        public void AddChildren(Node<T> n)
        {
            this.children.Add(n);
        }
        public int Aceptar(IVisitante<T> visitante)
        {
            int y=visitante.Visitar(this);
            return y;
        }
        
    }
}
