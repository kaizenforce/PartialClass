using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassDemo
{
    partial class Facturador
    {

        public string ObtenerClienteNatural(string DNI) {

            return "Se retorna el cliente con dni : " + DNI;

        }

        public string ObtenerClienteJuridico(string ruc) {
            return "Se retorna el cliente con ruc : " + ruc;
        }

    }
}
