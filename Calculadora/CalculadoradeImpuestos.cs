using System;

namespace Calculadora
{
    public class CalculadoradeImpuestos
    {
        public decimal ObtenerIVA(decimal montoReserva)
        {
            const decimal porcentaje = 0.19m;
            return porcentaje * montoReserva;
        }

        public decimal ObtenerISH(decimal montoReserva, decimal porcentaje)
        {
            return montoReserva * porcentaje;
        }

        public decimal ObtenerMontoTotal(decimal montoReserva, int tiempo)
        {
            const decimal capital = 2000;
            return capital * montoReserva * tiempo;
        }
    }
}
