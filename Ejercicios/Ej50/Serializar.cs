using System;
using System.Collections.Generic;
using System.Text;

namespace Ej50
{
    public class Serializar<S,V>
    {
        public bool Guardar(S obj)
        {
            return true;
        }

        public V Leer()
        {
            return (V)Convert.ChangeType("Texto leído", typeof(V));
        }
    }
}
