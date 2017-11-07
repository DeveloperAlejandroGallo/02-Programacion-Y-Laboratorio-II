using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej58_Entidades
{
    public interface IGuardar<T>
    {
       string RutaDeArchivo
       {
            get;
            set;
       }

        bool Guardar();

        T Leer();

    }
}
