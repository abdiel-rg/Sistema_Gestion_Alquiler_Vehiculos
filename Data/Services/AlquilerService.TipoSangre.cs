using Microsoft.EntityFrameworkCore;
using Sistema_Gestion_Alquiler_Vehiculos.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_Gestion_Alquiler_Vehiculos.Data.Services
{
    public partial class AlquilerService
    {
        public async Task<List<TipoSangre>> GetTiposSangre()
        {
            return await Context.TiposSangre.ToListAsync();
        }
    }
}
