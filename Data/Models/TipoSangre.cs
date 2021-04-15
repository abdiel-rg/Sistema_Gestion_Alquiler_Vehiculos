using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_Gestion_Alquiler_Vehiculos.Data.Models
{
    public class TipoSangre
    {
        public int ID { get; set; }

        public string Nombre { get; set; }

        public List<Cliente> Clientes { get; set; }
    }
}
