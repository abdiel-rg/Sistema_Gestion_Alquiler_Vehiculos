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
        public async Task<bool> CreateFactura(Factura factura)
        {
            await Context.Facturas.AddAsync(factura);
            return await Context.SaveChangesAsync() > 0;
        }

        public async Task<bool> UpdateFactura(Factura factura)
        {
            Context.Facturas.Update(factura);
            return await Context.SaveChangesAsync() > 0;
        }

        public async Task<Factura?> FindFactura(int ID)
        {
            List<Factura> facturas = await Context.Facturas.Include(f => f.Reserva)
                                         .ThenInclude(r => r.Vehiculo)
                                         .ToListAsync();
            return facturas.Find(f => f.ID == ID);
        }

        public async Task<bool> PayFactura(Factura factura, decimal cant)
        {
            factura.MontoPagado += cant;
            return await UpdateFactura(factura);
        }

        public Task<List<Factura>> GetAllFacturas()
        {
            return Context.Facturas.Include(f => f.Reserva)
                                   .ThenInclude(r => r.Vehiculo)
                                   .ToListAsync();
        }
    }
}
