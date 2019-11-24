using System;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            CuentaBancaria unaCuenta = new CuentaBancaria();
            Console.WriteLine("Ingrese Nro Cuenta Bancaria:");
            unaCuenta.nroCuenta = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese Nro Cliente:");
            unaCuenta.nroCliente = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese Moneda:");
            unaCuenta.moneda = Console.ReadLine();
            Console.WriteLine("Ingrese Saldo:");
            double unSaldo = Convert.ToDouble(Console.ReadLine());
            if (unSaldo < 0)
            {
                Console.WriteLine("Saldo cuenta incorrecto");
                return;
            }
            unaCuenta.saldo = unSaldo;
            Console.WriteLine("Ingrese cantidad dinero a depositar:");
            double dinero = Convert.ToDouble(Console.ReadLine());
            unaCuenta.depositarCantidad(dinero);
            unaCuenta.informarEstado();
            Console.WriteLine("Ingrese cantidad dinero a retirar:");
            dinero = Convert.ToDouble(Console.ReadLine());
            unaCuenta.retirarCantidad(dinero);
            unaCuenta.informarEstado();
        }
    }
}
