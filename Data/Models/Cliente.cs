using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DevelopersDo.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_Gestion_Alquiler_Vehiculos.Data.Models
{
    public class Cliente
    {
        [Key]
        [Required]
        [Cedula]
        public string Cedula { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public string Apellido { get; set; }

        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        [Required]
        public string Correo { get; set; }

        public bool Disponible { get; set; } = true;

        [Required]
        public string Licencia { get; set; }
        
        [Required]
        public string FotoLicencia { get; set; }

        [Required]
        public string Nacionalidad { get; set; }

        [ForeignKey("TipoSangre")]
        public int TipoSangreID { get; set; }
        public TipoSangre TipoSangre { get; set; }

        [Required]
        public string Foto { get; set; }


        public List<Reserva> Reservas { get; set; }
    }
}
