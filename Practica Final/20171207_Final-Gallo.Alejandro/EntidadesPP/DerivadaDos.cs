using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesPP
{
    public class DerivadaDos : Base
    {
        public override string VersionFull
        {
            get
            {
                return base.MostrarVersion();
            }
        }

        public DerivadaDos()
            : base(1, 0)
        {}

        public override string MostrarVersion()
        {
            return  base.MostrarVersion();
        }
    }
}
