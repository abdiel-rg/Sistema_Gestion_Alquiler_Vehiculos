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
        [Required]
        public int ID { get; set; }

        [Required]
        public string Matricula { get; set; }

        [Required]
        public string Marca { get; set; }

        [Required]
        public string Modelo { get; set; }

        [Required]
        public int Anio { get; set; }

        [Required]
        public string Color { get; set; }

        [Required]
        [Column(TypeName = "NUMERIC")]
        [Range(double.Epsilon, double.MaxValue)]
        public decimal PrecioPorDia { get; set; }

        [Required]
        [ForeignKey("TipoVehiculo")]
        public int TipoID { get; set; }
        public TipoVehiculo Tipo { get; set; }

        [Required]
        [Column(TypeName = "NUMERIC")]
        [Range(double.Epsilon, double.MaxValue)]
        public decimal CapacidadCarga { get; set; }

        [Required]
        [Range(1, int.MaxValue)]
        public int Pasajeros { get; set; }

        [Required]
        public string NumeroSeguro { get; set; }

        [Required]
        public string Foto { get; set; }

        [Required]
        [Range(-90, 90)]
        public double Latitud { get; set; }

        [Required]
        [Range(-180, 180)]
        public double Longitud { get; set; }

        public bool Habilitado { get; set; } = true;

        public bool Disponible()
        {
            if (Reservas.Count == 0) return true;
            return DateTime.Compare(DateTime.Today, Reservas.Max(r => r.FechaFin)) >= 0;
        }

        public bool Disponible(DateTime fecha)
        {
            if (Reservas.Count == 0) return true;
            return DateTime.Compare(fecha, Reservas.Max(r => r.FechaFin)) >= 0;
        }

        public List<Reserva> Reservas { get; set; } = new();
    }
}
