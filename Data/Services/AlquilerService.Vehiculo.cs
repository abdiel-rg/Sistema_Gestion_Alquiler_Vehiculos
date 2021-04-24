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
        public async Task<Vehiculo?> FindVehiculo(int ID)
        {
            return await Context.Vehiculos.FindAsync(ID);
        }

        public async Task<bool> SetEstatusVehiculo(int id)
        {
            Vehiculo vehiculo = (await FindVehiculo(id))!;
            vehiculo.Habilitado = !vehiculo.Habilitado;
            return await SaveVehiculo(vehiculo);
        }

        public async Task<bool> SetEstatusVehiculo(int id, bool estado)
        {
            Vehiculo vehiculo = (await FindVehiculo(id))!;
            vehiculo.Habilitado = estado;
            return await SaveVehiculo(vehiculo);
        }

        public Task<List<Vehiculo>> GetAllVehiculos()
        {
            return Context.Vehiculos.Include(v => v.Tipo)
                                    .ToListAsync();
        }

        public Task<List<Vehiculo>> GetAllAvailableVehiculos()
        {
            var vehiculos = Context.Vehiculos.ToListAsync();
            return vehiculos.ContinueWith(t => t.Result.Where(v => v.Disponible() || v.Habilitado)
                                                       .ToList());
        }

        public Task<List<Vehiculo>> GetAllAvailableVehiculos(DateTime FechaI, DateTime FechaF)
        {
            Task<List<Vehiculo>> vehiculosSinReservas = Context.Vehiculos.Include(v => v.Reservas)
                                                                         .Where(v => v.Reservas.Count == 0 || v.Disponible(FechaF))
                                                                         .ToListAsync();

            Task<List<Vehiculo>> vehiculosDisponibles = Context.Reservas.Include(r => r.Vehiculo)
                                                                        .Where(r => r.FechaInicio < FechaI || r.FechaFin >= FechaF)
                                                                        .Select(r => r.Vehiculo)
                                                                        .ToListAsync();

            return Task.WhenAll(vehiculosSinReservas, vehiculosDisponibles)
                       .ContinueWith(t => t.Result[0].Concat(t.Result[1])
                                                     .ToList());
        }

        public async Task<bool> SaveVehiculo(Vehiculo vehiculo)
        {
            if (await Context.FindAsync<Vehiculo?>(vehiculo.ID) is null)
            {
                return await AddVehiculo(vehiculo);
            }
            return await UpdateVehiculo(vehiculo);
        }
    }
}
