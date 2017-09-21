using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej39
{
    public class SobreSobreescrito : Sobreescrito
    {

        public override string MiAtributo
        {
            get
            {
                return this.miAtributo;
            }
        }

        public override string MiMetodo()
        {
            return "Mi Metodo en SobreSobreescrito";
        }
    }
}
