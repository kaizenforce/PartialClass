using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Facturador facturas = new Facturador();

            Console.WriteLine("Demo de una clase parcial");
            Console.WriteLine("--------------------------");
            Console.WriteLine("El IGV es : " + facturas.CalcularIGV(100.50d).ToString());
            Console.WriteLine("--------------------------");
            Console.WriteLine("Cliente natural" + facturas.ObtenerClienteNatural("12345678"));
            Console.WriteLine("--------------------------");
            Console.WriteLine("El numero redondeado es : " + facturas.RedondearMonto(100.50d).ToString());
            Console.WriteLine("--------------------------");
            Console.WriteLine("Cliente juridico" + facturas.ObtenerClienteJuridico("12345678901"));
            Console.WriteLine("--------------------------");
            Console.ReadLine();
        }
    }
}
