using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Service.Exceptions
{
    public class ClientSideException : Exception
    {
        // message'i alır Exceptionın constructoruna gönderir
        public ClientSideException(string message) : base(message)
        {
            
        }
    }
}
