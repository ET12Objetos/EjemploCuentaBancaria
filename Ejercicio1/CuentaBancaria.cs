using System;

namespace Ejercicio1
{
    class CuentaBancaria
    {
        public int nroCuenta;
        public int nroCliente;
        public string moneda;
        public double saldo;

        public void depositarCantidad(double dinero)
        {
            validarDinero(dinero);            
            saldo = saldo + dinero;
        }

        private void validarDinero(double dinero)
        {
            if (dinero < 0)
                throw new Exception("Error, monto dinero incorrecto");
        }

        public void informarEstado()
        {
            Console.WriteLine("*****************************************");
            Console.WriteLine($"Nro Cuenta: {nroCuenta} Nro Cliente: {nroCliente} Moneda: {moneda} Saldo: {saldo}");
            Console.WriteLine("*****************************************");
        }

        public void retirarCantidad(double dinero)
        {
            validarDinero(dinero);
            double saldoOperacion = saldo - dinero;
            if (saldoOperacion < 0)
                throw new Exception("Fondos insuficientes");
            saldo = saldoOperacion;
        }
    }
}