using System;
using System.Collections.Generic;
using System.Text;

namespace Ej50
{
    public interface IGuardar<T,V>
    {
        bool Guardar(T obj);
        V Leer();
    }
}
