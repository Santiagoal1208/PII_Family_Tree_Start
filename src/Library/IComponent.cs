using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public interface Component<T>
    {
        public abstract int Aceptar(IVisitante<T> visitante);
        
    }
}