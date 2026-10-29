using System;
using System.Collections.Generic;
using System.Text;

namespace HotelSystem
{
    internal class Cliente
    {
        // Atributos
        private string identificacion;
        private string nombre;
        // Propiedades
        public string Identificacion
        {
            get { return identificacion; }
        }
        public string Nombre
        {
            get { return nombre; }
            set
            {
                if (value == null) throw new ArgumentException("El nombre no puede ser nulo");
                nombre = value;
            }
        }
        // Constructores
        public Cliente(string identificacion, string nombre)
        {
            this.identificacion = identificacion;
            this.nombre = nombre;
        }
    }
}
