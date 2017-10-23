using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase17
{
    public class MiLista<T> : IEnumerable<T>
    {
        T[] miLista;

        public MiLista()
        {
             this.miLista = new T[0];
        }

        public void Add(T item)
        {
            int indice = this.miLista.Length;
            Array.Resize<T>(ref this.miLista, indice + 1);
            this.miLista[indice] = item;
        }

        public void Remove(T item)
        {
            T[] arrAux = new T[this.miLista.Length-1];
            int index = Array.IndexOf<T>(this.miLista, item);
            Array.Copy(this.miLista, arrAux, index - 1);
            Array.Copy(this.miLista, index+1, arrAux, arrAux.Length, this.miLista.Length - index);
        }


        public int Count
        {
            get
            {
                return this.miLista.Count<T>();
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
