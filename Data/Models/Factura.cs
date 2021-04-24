using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_Gestion_Alquiler_Vehiculos.Data.Models
{
    public class Factura
    {
        public int ID { get; set; }

        public decimal MontoAPagar => Reserva.Vehiculo.PrecioPorDia *
                                      (Reserva.FechaFin - Reserva.FechaInicio).Days;

        [Column(TypeName = "NUMERIC")]
        public decimal MontoPagado { get; set; } = 0;

        public bool Pagada => MontoPagado.Equals(MontoAPagar);

        [ForeignKey("Reserva")]
        public int ReservaID { get; set; }
        public Reserva Reserva { get; set; }
    }
}
