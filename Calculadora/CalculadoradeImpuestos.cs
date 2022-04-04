using System;

namespace Calculadora
{
    public class CalculadoradeImpuestos
    {
        //Metodo Obtener el IVA a partir del monto de una reserva. 19%
        public decimal ObtenerIVA(decimal montoReserva)
        {
            const decimal porcentaje = 0.19m;
            //return 0;
            //decimal ivaReserva = porcentaje * montoReserva;
            //return ivaReserva;
            return porcentaje * montoReserva;
        }

        //Metodo Obtener el impuesto estatal sobre hospedaje a partir del monto de una reserva
        public decimal ObtenerISH(decimal montoReserva, decimal porcentaje)
        {
            //decimal ishReserva = montoReserva * porcentaje;
            //return 0;
            //decimal ivaReserva = porcentaje * montoReserva;
            //return ivaReserva;
            //return ishReserva;
            return montoReserva * porcentaje;
        }
    }
}
