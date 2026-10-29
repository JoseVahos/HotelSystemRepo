using System;
using System.Collections.Generic;
using System.Text;

namespace HotelSystem
{
    internal static class Recepcionista
    {
        public static void ConsultarPrecios()
        {
            Console.WriteLine("Habitación simple: $" + Hotel.Simple.Precio);
            Console.WriteLine("Habitación doble: $" + Hotel.Doble.Precio);
            Console.WriteLine("Habitación matrimonial: $" + Hotel.Doble.Precio);
        }
        public static void RealizarReserva(string numeroHabitacion)
        {
            Console.WriteLine("Ingrese la identificación del cliente");
        }
        public static void CancelarReserva()
        {

        }
        public static decimal CalcularCosto()
        {
            return 0.0m;
        }
    }
}
