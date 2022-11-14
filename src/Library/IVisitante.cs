using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public interface IVisitante<T>
    {
        
        public abstract int Visitar(Component<T> arbol);

        
    }
}