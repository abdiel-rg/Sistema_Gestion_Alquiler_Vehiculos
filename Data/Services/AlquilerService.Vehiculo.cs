using Microsoft.EntityFrameworkCore;
using Sistema_Gestion_Alquiler_Vehiculos.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

#nullable enable

namespace Sistema_Gestion_Alquiler_Vehiculos.Data.Services
{
    public partial class AlquilerService
    {
        public async Task<bool> AddVehiculo(Vehiculo vehiculo)
        {
            await Context.Vehiculos.AddAsync(vehiculo);
            return await Context.SaveChangesAsync() > 0;
        }

        public async Task<bool> UpdateVehiculo(Vehiculo vehiculo)
        {
            Context.Vehiculos.Update(vehiculo);
            return await Context.SaveChangesAsync() > 0;
        }

        public async Task<bool> SetEstatusVehiculo(Vehiculo vehiculo, bool disponible)
        {
            vehiculo.Disponible = disponible;
            return await Context.SaveChangesAsync() > 0;
        }

        public Task<List<Vehiculo>> GetAllAvailableVehiculos()
        {
            return Context.Vehiculos.Where(v => v.Disponible).ToListAsync();
        }

        public async Task<bool> SaveVehiculo(Vehiculo vehiculo)
        {
            if (await Context.FindAsync<Reserva?>(vehiculo.ID) is null)
            {
                return await AddVehiculo(vehiculo);
            }
            return await UpdateVehiculo(vehiculo);
        }
    }
}
