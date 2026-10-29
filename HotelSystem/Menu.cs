using System;
using System.Collections.Generic;
using System.Text;

namespace HotelSystem
{
    internal static class Menu
    {
        public static void Primero()
        {
            Encabezado();
            Console.WriteLine("MENÚ PRINCIPAL");
            Console.WriteLine("[1] Recepción");
            Console.WriteLine("[2] Administración");
            Console.WriteLine("[X] Salir del programa");
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.NumPad1 or ConsoleKey.D1:
                    Recepcion();
                    break;
                case ConsoleKey.NumPad2 or ConsoleKey.D2:
                    Administrador();
                    break;
                case ConsoleKey.X:
                    return;
                default:
                    Primero();
                    break;
            }
        }
        public static void Recepcion()
        {
            Console.WriteLine("RECEPCIÓN");
            Console.WriteLine("[1] Consultar los precios de las habitaciones");
            Console.WriteLine("[2] Realizar una reserva");
            Console.WriteLine("[3] Cancelar una reserva");
            Console.WriteLine("[X] Regresar");
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.NumPad1 or ConsoleKey.D1:
                    Recepcionista.ConsultarPrecios();
                    break;
                case ConsoleKey.NumPad2 or ConsoleKey.D2:
                    Reserva();
                    break;
                case ConsoleKey.NumPad3 or ConsoleKey.D3:
                    CancelarReserva();
                    break;
                case ConsoleKey.X:
                    Primero();
                    break;
                default:
                    Recepcion();
                    break;
            }
        }
        public static void Reserva()
        {
            if (Hotel.HayHabitacionesDisponibles())
            {
                Hotel.MostrarDisponibilidad();
                Console.WriteLine("¿Qué número de habitación va a reservar?");
                string? numeroHabitacionReservar = Console.ReadLine();
                if (Hotel.EsNumeroHabitacionValido(numeroHabitacionReservar))
                {
                    Recepcionista.RealizarReserva(numeroHabitacionReservar);
                }
                else
                {
                    Console.WriteLine("El número de habitación que ingreso no es válido, intente de nuevo");
                    Console.ReadKey();
                    Reserva();
                }
            }
            else
            {
                Console.WriteLine("No hay habitaciones disponibles en este momento");
            }
        }
        public static void CancelarReserva()
        {

        }
        public static void Administrador()
        {
            Encabezado();
            Console.WriteLine("ADMINISTRACIÓN");
            Console.WriteLine("[1] Calcular los ingresos proyectados de este mes");
            Console.WriteLine("[2] Modificar los precios de las habitaciones");
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.NumPad1 or ConsoleKey.D1:
                    Admin.CalcularIngresosProyectados();
                    break;
                case ConsoleKey.NumPad2 or ConsoleKey.D2:
                    ModificarPrecios();
                    break;
                case ConsoleKey.X:
                    Primero();
                    break;
                default:
                    Administrador();
                    break;
            }
        }
        public static void ModificarPrecios()
        {
            
        }
        public static void Encabezado()
        {
            Console.Clear();
            Console.WriteLine(" * - HOTEL LAS PALMAS - * ");
        }
    }
}
