using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace HotelSystem
{
    internal static class Hotel
    {
        // Atributos
        private static readonly string nombre = "Hotel las Palmas";
        private static readonly string direccion = "Carrera 8 # 8 - 8";
        private static TipoHabitacion simple = new TipoHabitacion("simple", 80000m);
        private static TipoHabitacion doble = new TipoHabitacion("doble", 120000m);
        private static TipoHabitacion matrimonial = new TipoHabitacion("matrimonial", 150000m);
        private static List<Habitacion> habitaciones = new List<Habitacion>();
        // Propiedades
        public static TipoHabitacion Simple
        {
            get {  return simple; }
        }
        public static TipoHabitacion Doble
        {
            get { return doble;  }
        }
        public static TipoHabitacion Matrimonial
        {
            get { return matrimonial; }
        }
        // Métodos
        public static void Setup() // Es lo primero que se llama en Main(). Inicializa la cantidad de #Habitacion de cada tipo
        {
            for (int i = 1; i <= 4; i++) // 1 a 4 simples
            {
                habitaciones.Add(new Habitacion(i.ToString(), simple));
            }
            for (int i = 5; i <= 8; i++) // 5 a 8 dobles
            {
                habitaciones.Add(new Habitacion(i.ToString(), doble));
            }
            for (int i = 9; i <= 10; i++) // 9 a 10 matrimoniales
            {
                habitaciones.Add(new Habitacion(i.ToString(), matrimonial));
            }
        }
        public static bool HayHabitacionesDisponibles() // Verifica si hay al menos una #Habitacion sin reservar
        {
            foreach (Habitacion habitacion in habitaciones)
            {
                if (!habitacion.EstaReservada)
                {
                    return true;
                }
            }
            return false;
        }
        public static void MostrarDisponibilidad() // Muestra una tabla con el número y disponibilidad de cada #Habitacion
        {
            Console.WriteLine("#  Disponibilidad");
            foreach (Habitacion habitacion in habitaciones)
            {
                Console.WriteLine(habitacion.Numero + "  " + (habitacion.EstaReservada ? "Reservada" : "Disponible"));
            }
        }
        public static bool EsNumeroHabitacionValido(string? numeroHabitacion) // Verifica si un texto corresponde al número de una #Habitacion existente
        {
            foreach (Habitacion habitacion in habitaciones)
            {
                if (habitacion.Numero == numeroHabitacion)
                {
                    return true;
                }
            }
            return false;
        }
        public static Habitacion GetHabitacion(string? numeroHabitacion) // Devuelve una #habitacion según su numero
        {
            foreach (Habitacion habitacion in habitaciones)
            {
                if (habitacion.Numero == numeroHabitacion)
                {
                    return habitacion;
                }
            }
            throw new ArgumentException("El número ingresado no es válido");
        }
    }
}
