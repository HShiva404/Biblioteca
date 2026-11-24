using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class ClsAutenticacion
    {
        public string usuario = "Shiva";
        public string clave = "123456789";
        public bool Auntenticacion(string Usuario,string Clave)
        {
            if (Usuario == usuario && Clave == clave)
            {
                return true;
            }
            else
            {
                return false; 
            }
        }
    }
}
