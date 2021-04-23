using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sistema_Gestion_Alquiler_Vehiculos.Data.Models
{
    public class Vehiculo
    {
        [Key]
        public int ID { get; set; }

        public string Matricula { get; set; }

        public string Marca { get; set; }

        public string Modelo { get; set; }

        public int Anio { get; set; }

        public string Color { get; set; }

        [Column(TypeName = "NUMERIC")]
        public decimal PrecioPorDia { get; set; }

        [ForeignKey("TipoVehiculo")]
        public int TipoID { get; set; }
        public TipoVehiculo Tipo { get; set; }

        [Column(TypeName = "NUMERIC")]
        public decimal CapacidadCarga { get; set; }

        public int Pasajeros { get; set; }

        public string NumeroSeguro { get; set; }

        public string Foto { get; set; }

        public double Latitud { get; set; }

        public double Longitud { get; set; }

        public bool Disponible() => DateTime.Compare(DateTime.Today, Reservas.Max(r => r.FechaFin)) >= 0;

        public bool Disponible(DateTime fecha) => DateTime.Compare(fecha, Reservas.Max(r => r.FechaFin)) >= 0;

        public List<Reserva> Reservas { get; set; } = new();
    }
}
