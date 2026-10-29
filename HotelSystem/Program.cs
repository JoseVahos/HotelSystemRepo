using System.Security.Cryptography.X509Certificates;

namespace HotelSystem
{
    internal class Program
    {
        // Atributos
        private static List<Cliente> clientes = new List<Cliente>();
        private static List<Reserva> reservas = new List<Reserva>();
        // Propiedades
        public static List<Cliente> Clientes
        {
            get { return clientes; }
            set { clientes = value; }
        }
        public static List<Reserva> Reservas
        {
            get{ return reservas; }
            set { reservas = value; }
        }
        // Métodos
        public static Cliente? GetCliente(string? identificacion) // Devuelve un #Cliente según su identificacion
        {
            foreach (Cliente cliente in clientes)
            {
                if (cliente.Identificacion == identificacion)
                {
                    return cliente;
                }
            }
            return null;
        }
        static void Main(string[] args)
        {
            Hotel.Setup();
            Menu.Primero();
        }
    }
}
