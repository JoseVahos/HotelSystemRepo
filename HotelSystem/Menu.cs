using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;

namespace HotelSystem
{
    internal static class Menu
    {
        // Métodos
        public static void Primero() // El menú llamado en Main() que da paso a la ejecución del resto del programa. Opciones para escoger el actor.
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
        public static void Recepcion() // Opciones de recepcionista
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
        public static void Reserva() // Por resolver. Ejecuta la secuencia para realizar una #Reserva.
        {
            
        }
        public static void CancelarReserva() // Por resolver. Ejecuta la secuencia para cancelar una #Reserva.
        {

        }
        public static void Administrador() // Opciones de administrador
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
        public static void ModificarPrecios() // Por resolver. Ejecuta la secuencia para modificar los precios de #TipoHabitacion.
        {
            
        }
        public static void Encabezado() // Limpia la pantalla y muestra un texto. Se llama al principio de cada menú.
        {
            Console.Clear();
            Console.WriteLine(" * - HOTEL LAS PALMAS - * ");
        }
    }
}
