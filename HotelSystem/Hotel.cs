using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace HotelSystem
{
    internal static class Hotel
    {
        private static readonly string nombre = "Hotel las Palmas";
        private static readonly string direccion = "Carrera 8 # 8 - 8";
        private static TipoHabitacion simple = new TipoHabitacion("simple", 80000m);
        private static TipoHabitacion doble = new TipoHabitacion("doble", 120000m);
        private static TipoHabitacion matrimonial = new TipoHabitacion("matrimonial", 150000m);
        private static List<Habitacion> habitaciones = new List<Habitacion>();
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
        public static void Setup()
        {
            for (int i = 1; i <= 4; i++)
            {
                habitaciones.Add(new Habitacion(i.ToString(), simple));
            }
            for (int i = 5; i <= 8; i++)
            {
                habitaciones.Add(new Habitacion(i.ToString(), doble));
            }
            for (int i = 9; i <= 10; i++)
            {
                habitaciones.Add(new Habitacion(i.ToString(), matrimonial));
            }
        }
        public static bool HayHabitacionesDisponibles()
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
        public static void MostrarDisponibilidad()
        {
            Console.WriteLine("#  Disponibilidad");
            foreach (Habitacion habitacion in habitaciones)
            {
                Console.WriteLine(habitacion.Numero + "  " + (habitacion.EstaReservada ? "Reservada" : "Disponible"));
            }
        }
        public static bool EsNumeroHabitacionValido(string? numeroHabitacion)
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
    }
}
