using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej17
{
    class Ejercicio17
    {
        static void Main(string[] args)
        {
            Cuenta cta = new Cuenta();
            Cuenta cta1 = new Cuenta();

            cta.setNombre("Pepe");
            cta.setNroCuenta(0);
            cta.setSaldo(1000);
            cta.setTipoInteres(Cuenta.ETipoInteres.TIR);

            
            cta1.setNombre("Juan");
            cta1.setNroCuenta(12345);
            cta1.setSaldo(21000);
            cta1.setTipoInteres(Cuenta.ETipoInteres.TIR);

            Console.WriteLine("Cuenta 1");
            Console.WriteLine("Nombre: {0}", cta.getNombre());
            Console.WriteLine("Nro Cta: {0}", cta.getNroCuenta());
            Console.WriteLine("Saldo: {0}", cta.getSaldo());
            Console.WriteLine("Tipo Int: {0}", cta.getTipoInteres());
            Console.WriteLine();
            Console.WriteLine("Cuenta 2");
            Console.WriteLine("Nombre: {0}", cta1.getNombre());
            Console.WriteLine("Nro Cta: {0}", cta1.getNroCuenta());
            Console.WriteLine("Saldo: {0}", cta1.getSaldo());
            Console.WriteLine("Tipo Int: {0}", cta1.getTipoInteres());

            Console.ReadKey();
        }
    }
}
