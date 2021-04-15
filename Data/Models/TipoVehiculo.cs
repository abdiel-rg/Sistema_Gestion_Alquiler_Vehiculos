using System.Collections.Generic;

namespace Sistema_Gestion_Alquiler_Vehiculos.Data.Models
{
    public class TipoVehiculo
    {
        public int ID { get; set; }

        public string Nombre { get; set; }

        public List<Vehiculo> Vehiculos { get; set; }
    }
}