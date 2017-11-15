using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaException
{
    public class CocoException :  Exception
    {
        public CocoException(string msg, Exception e)
            : base(msg, e)
        { }
    }
}
