using System;
using System.Collections.Generic;
using System.Text;

namespace HotelSystem
{
    internal static class Recepcionista
    {
        // Métodos
        public static void ConsultarPrecios() // Imprime los precios de cada #TipoHabitacion
        {
            Console.WriteLine("Habitación simple: $" + Hotel.Simple.Precio);
            Console.WriteLine("Habitación doble: $" + Hotel.Doble.Precio);
            Console.WriteLine("Habitación matrimonial: $" + Hotel.Doble.Precio);
        }
        public static void RealizarReserva(string numeroHabitacion) // Por resolver. Construye una nueva instancia de #Cliente si no existe y una nueva instancia de #Reserva según la entrada del usuario
        {
            Console.WriteLine("Ingrese la identificación del cliente");
        }
        public static void CancelarReserva() // Por resolver. Elimina una instancia de #Reserva
        {

        }
        public static decimal CalcularCosto() // Por resolver
        {
            return 0.0m;
        }
    }
}
