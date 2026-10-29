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
        public static void RealizarReserva() // Por resolver. Construye una nueva instancia de #Cliente si no existe y una nueva instancia de #Reserva según la entrada del usuario
        {
            // Variables locales
            DateOnly fechaEntrada;
            int numeroNoches;

            Habitacion habitacionReservar;
            string? numeroHabitacion;

            Cliente clienteReservar;
            string? identificaion;
            string? nombree;

            // Ejecución
            if (Hotel.HayHabitacionesDisponibles()) // Verifica hay si hay habitaciones disponibles
            {
                Hotel.MostrarDisponibilidad(); // Muestra disponibilidad
                Console.WriteLine("¿Qué número de habitación va a reservar?"); 
                numeroHabitacion = Console.ReadLine(); // Ingresa de numeroHabitación
                if (Hotel.EsNumeroHabitacionValido(numeroHabitacion)) // Verifica si es un número de habitación válido
                {
                    habitacionReservar = Hotel.GetHabitacion(numeroHabitacion);
                    if (!habitacionReservar.EstaReservada) // Verifica si la habitación seleccionada está disponible
                    {
                        Console.WriteLine("Ingrese la identificación del cliente");
                    }
                }
                else
                {
                    Console.WriteLine("El número de habitación que ingreso no es válido, intente de nuevo");
                    Console.ReadKey();

                }
            }
            else
            {
                Console.WriteLine("No hay habitaciones disponibles en este momento");
                Console.ReadKey();
            }
            Menu.Recepcion();
            
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
