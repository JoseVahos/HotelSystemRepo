using System.Security.Cryptography.X509Certificates;

namespace HotelSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" * - HOTEL LAS PALMAS - * ");
            Console.WriteLine("¿En qué trabajas?");
            Console.WriteLine("[1] Administración");
            Console.WriteLine("[2] Recepción");
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.NumPad1:
                    MenuAdmin();
                    break;
                case ConsoleKey.NumPad2:
                    MenuRecepcion();
                default:
                    break;
            }

            void MenuAdmin()
            {
                Console.WriteLine(" * - HOTEL LAS PALMAS - * ");
                Console.WriteLine("¿Qué quieres hacer?");
                Console.WriteLine("[1] Administración");
                Console.WriteLine("[2] Recepción");
            }
        }
    }
}
