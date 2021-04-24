using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_Gestion_Alquiler_Vehiculos.Data.Models
{
    public class Reserva
    {
        public int ID { get; set; }

        [Required]
        [Range(1, int.MaxValue)]
        [ForeignKey("Vehiculo")]
        public int VehiculoID { get; set; }
        public Vehiculo Vehiculo { get; set; }

        [Required]
        [ForeignKey("Cliente")]
        public string CedulaCliente { get; set; }
        public Cliente Cliente { get; set; }

        [Required]
        public DateTime FechaInicio { get; set; }
        
        [Required]
        public DateTime FechaFin { get; set; }

        [ForeignKey("Factura")]
        public int? FacturaID { get; set; }
        public Factura Factura { get; set; }
    }
}
