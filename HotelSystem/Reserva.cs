using System;
using System.Collections.Generic;
using System.Text;

namespace HotelSystem
{
    internal sealed class Reserva
    {
        private DateOnly fechaEntrada;
        private int numeroNoches;
        private Habitacion habitacion;
        private Cliente cliente;
    }
}
