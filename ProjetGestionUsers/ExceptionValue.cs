using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetGestionUsers
{
    class ExceptionValue : Exception
    {
        public ExceptionValue(string message) : base(message)
        {

        }
    }
}
