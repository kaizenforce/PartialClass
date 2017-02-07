using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassDemo
{
    partial class Facturador
    {

        public double CalcularIGV(double Monto) {

            return Monto * 0.18d;
        }

        public int RedondearMonto(double Monto) {
            return (int) Math.Round(Monto);
        }

    }
}
