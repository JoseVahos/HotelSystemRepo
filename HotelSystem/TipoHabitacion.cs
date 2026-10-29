using System;
using System.Collections.Generic;
using System.Text;

namespace HotelSystem
{
    internal sealed class TipoHabitacion
    {
        private string nombre;
        private decimal precio;
        public decimal Precio
        {
            get {  return precio; }
            set { precio = value; }
        }
        public TipoHabitacion(string nombre, decimal precio)
        {
            this.nombre = nombre;
            this.precio = precio;
        }
    }
}
