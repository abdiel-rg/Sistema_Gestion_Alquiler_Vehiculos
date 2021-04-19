using Sistema_Gestion_Alquiler_Vehiculos.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

#nullable enable

namespace Sistema_Gestion_Alquiler_Vehiculos.Data.Services
{
    public partial class AlquilerService
    {
        public async Task<bool> CreateReserva(Reserva reserva)
        {
            await Context.Reservas.AddAsync(reserva);
            await CreateFactura(new()
            {
                MontoPagado = 0,
                ReservaID = reserva.ID
            });
            return await Context.SaveChangesAsync() > 0;
        }

        public Task<List<Reserva>> GetAllReservas()
        {
            return Context.Reservas.Include(r => r.Vehiculo)
                                   .ToListAsync();
        }

        public Task<List<Vehiculo>> GetReservasFromDates(DateTime FechaI, DateTime FechaF)
        {
            return Context.Reservas.Include(r => r.Vehiculo)
                                   .Where(r => r.FechaInicio == FechaI &&
                                               r.FechaFin == FechaF)
                                   .Select(r => r.Vehiculo)
                                   .ToListAsync();
        }
    }
}
