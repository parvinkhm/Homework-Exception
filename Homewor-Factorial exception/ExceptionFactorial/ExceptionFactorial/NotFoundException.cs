using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionFactorial
{
    class NotFoundException : Exception
    {
        public NotFoundException(string msj) : base(msj) 
        { 

        }
    }
}
