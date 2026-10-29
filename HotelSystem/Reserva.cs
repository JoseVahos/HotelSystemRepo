using System;
using System.Collections.Generic;
using System.Text;

namespace HotelSystem
{
    internal sealed class Reserva
    {
        // Atributos
        private DateOnly fechaEntrada;
        private int numeroNoches;
        private Habitacion habitacion;
        private Cliente cliente;
        // Propiedades
        public DateOnly FechaEntrada
        {
            get { return fechaEntrada; }
        }
        public int NumeroNoches
        {
            get { return numeroNoches; }
        }
        public Habitacion Habitacion
        {
            get { return habitacion; }
        }
        public Cliente Cliente
        {
            get { return cliente; }
        }
        // Constructores
        public Reserva(DateOnly fechaEntrada, int numeroNoches, Habitacion habitacion, Cliente cliente)
        {
            this.fechaEntrada = fechaEntrada;
            this.numeroNoches = numeroNoches;
            this.habitacion = habitacion;
            this.cliente = cliente;
        }
    }
}
