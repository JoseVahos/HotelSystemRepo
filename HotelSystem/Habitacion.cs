using System;
using System.Collections.Generic;
using System.Text;

namespace HotelSystem
{
    internal sealed class Habitacion
    {
        // Atributos
        private string numero;
        private bool estaReservada;
        private TipoHabitacion tipo;
        // Propiedades
        public string Numero
        {
            get { return numero; }
        }
        public bool EstaReservada
        {
            get { return estaReservada; }
            set { estaReservada = value; }
        }
        public TipoHabitacion Tipo
        {
            get { return tipo; }
        }
        // Constructores
        public Habitacion(string numero, TipoHabitacion tipo)
        {
            this.numero = numero;
            this.estaReservada = false;
            this.tipo = tipo;
        }
    }
}
