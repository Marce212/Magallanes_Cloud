using System;
using System.ComponentModel.DataAnnotations;

namespace GestionCanchaFutbol.Models
{
    public class Reserva
    {
        public int Id { get; set; }

        public string Cancha { get; set; }

        public string PagoParcial { get; set; }

        public string Cliente { get; set; }

        public string Contacto { get; set; }

        public decimal Total { get; set; }

        [DataType(DataType.Date)]
        public DateTime DiaReserva { get; set; }

    }
}
