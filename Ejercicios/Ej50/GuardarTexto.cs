using System;
using System.Collections.Generic;
using System.Text;

namespace Ej50
{
    public class GuardarTexto<T,V> : IGuardar<T,V>
    {
        public bool Guardar(T obj)
        {
            return true;
        }

        public V Leer()
        {
            return (V)Convert.ChangeType("Texto leído",typeof(V));
        }

        
    }
}
