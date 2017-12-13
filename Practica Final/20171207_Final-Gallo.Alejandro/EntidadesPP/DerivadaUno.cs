using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesPP
{
    public sealed class DerivadaUno : Base
    {

        int revision;

        static DerivadaUno()
        {
            
        }

        public DerivadaUno(int version, int subversion, int revision)
            :base(version,subversion)
        {
            this.revision = revision;
        }


        public override string VersionFull
        {
            get
            {
                return base.MostrarVersion();
            }
        }

        public override string MostrarVersion()
        {
            return string.Format("{0}.{1}",base.MostrarVersion(),this.revision);
        }

    }
}
