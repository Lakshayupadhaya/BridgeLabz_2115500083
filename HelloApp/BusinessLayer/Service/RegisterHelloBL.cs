using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepositoryLayer;

namespace BusinessLayer.Service
{
    
    public class RegisterHelloBL // BL refers this class to business layer
    {
        RegisterHelloRL _registerHelloRL;
        public RegisterHelloBL(RegisterHelloRL registerHelloRL)
        {
            _registerHelloRL = registerHelloRL;
        }

        public string Registration(string name)
        {
            return _registerHelloRL.GetHello(name) + " This is business layer data = ->";
        }
    }
}