using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_RPP_LabII
{
    public class DirectorTecnico : Persona
    {
        #region Constructores
        public DirectorTecnico(string nombre, string apellido)
            : base(nombre, apellido)
        {

        }

        #endregion

        protected override string FichaTecnica()
        {
            return this.NombreCompleto();
        }

        public override string ToString()
        {
            return this.FichaTecnica();
        }


    }
}
