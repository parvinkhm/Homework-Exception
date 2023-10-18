using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class NotFountException : Exception
    {
        public string ErrorCode = "";
        public NotFountException() : this ("Data not Found",404)
        {
            
        }
        public NotFountException(string msj,int code) : base(msj)
        {
            this.ErrorCode = code.ToString();
        }
    }
}
