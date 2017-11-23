using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class NoSeGuardoException : Exception
    {
        public NoSeGuardoException()
            :base("No se guardo!")
        { }
    }
}
