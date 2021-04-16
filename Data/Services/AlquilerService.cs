using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_Gestion_Alquiler_Vehiculos.Data.Services
{
    public partial class AlquilerService : IAlquilerService
    {
        private SGAVContext Context { get; set; }

        public AlquilerService(SGAVContext context)
        {
            Context = context;
        }
    }
}
