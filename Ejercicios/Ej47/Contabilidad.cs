using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej47
{
    public class Contabilidad<T,U>
        where T: Documento
        where U: Documento, new()
    {
        public List<T> egresos = new List<T>();
        public List<U> ingresos = new List<U>();


        public static Contabilidad<T, U> operator +(Contabilidad<T, U> c, T egreso)
        {

            c.egresos.Add(egreso);

            return c;
        }

        public static Contabilidad<T, U> operator +(Contabilidad<T, U> c, U ingreso)
        {

            c.ingresos.Add(ingreso);


            return c;
        }

    }
}
