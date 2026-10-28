using System;
using System.Collections.Generic;
using System.Text;

namespace HotelSystem
{
    internal abstract class Habitacion
    {
        private string numero;
        private float precio;
        private bool estaReservada;

        public string GetHabitacionDetails()
        {
            return $@"
Número: {numero}
Precio: {precio}
{(estaReservada ? "Esta habitación está reservada" : "Esta habitación está disponible")}
";
        }
    }
}
