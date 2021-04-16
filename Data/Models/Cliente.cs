using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_Gestion_Alquiler_Vehiculos.Data.Models
{
    public class Cliente
    {
        [Key]
        public string Cedula { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Correo { get; set; }

        public bool Disponible { get; set; }

        public string Licencia { get; set; }
        public string FotoLicencia { get; set; }

        public string Nacionalidad { get; set; }

        [ForeignKey("TipoSangre")]
        public int TipoSangreID { get; set; }
        public TipoSangre TipoSangre { get; set; }

        public string Foto { get; set; }

        public List<Reserva> Reservas { get; set; }
    }
}
