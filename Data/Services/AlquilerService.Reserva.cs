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
            List<bool> results = new();
            await Context.Reservas.AddAsync(reserva);
            results.Add(await Context.SaveChangesAsync() > 0);
            Factura factura = new()
            {
                ReservaID = reserva.ID
            };
            results.Add(await CreateFactura(factura));
            reserva.FacturaID = factura.ID;
            results.Add(await Context.SaveChangesAsync() > 0);
            return results.All(r => r == true);
        }

        public async Task<Reserva?> FindReserva(int ID)
        {
            return await Context.Reservas.FindAsync(ID);
        }

        public Task<List<Reserva>> GetAllReservas()
        {
            return Context.Reservas.Include(r => r.Vehiculo)
                                   .Include(r => r.Cliente)
                                   .ToListAsync();
        }
    }
}
