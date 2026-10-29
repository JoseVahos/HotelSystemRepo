using System.Security.Cryptography.X509Certificates;

namespace HotelSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hotel.Setup();
            Menu.Primero();
        }
    }
}
