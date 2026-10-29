using System;
using System.Collections.Generic;
using System.Text;

namespace HotelSystem
{
    internal sealed class TipoHabitacion
    {
        // Atributos
        private string nombre;
        private decimal precio;
        // Propiedades
        public string Nombre
        {
            get { return nombre; }
        }
        public decimal Precio
        {
            get { return precio; }
            set { precio = value; }
        }
        // Constructores
        public TipoHabitacion(string nombre, decimal precio)
        {
            this.nombre = nombre;
            this.precio = precio;
        }
    }
}
