using Microsoft.EntityFrameworkCore;
using Sistema_Gestion_Alquiler_Vehiculos.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_Gestion_Alquiler_Vehiculos.Data.Services
{
#nullable enable

    public partial class AlquilerService
    {
        public async Task<bool> AddCliente(Cliente cliente)
        {
            await Context.Clientes.AddAsync(cliente);
            return await Context.SaveChangesAsync() > 0;
        }

        public async Task<bool> UpdateCliente(Cliente cliente)
        {
            Context.Clientes.Update(cliente);
            return await Context.SaveChangesAsync() > 0;
        }

        public async ValueTask<Cliente?> FindCliente(string cedula)
        {
            return await Context.Clientes.FindAsync(cedula);
        }

        public async Task<bool> SetEstatusCliente(string cedula)
        {
            Cliente cliente = (await FindCliente(cedula))!;
            cliente.Disponible = !cliente.Disponible;
            return await SaveCliente(cliente);
        }
        
        public async Task<bool> SetEstatusCliente(string cedula, bool estatus)
        {
            Cliente cliente = (await FindCliente(cedula))!;
            cliente.Disponible = estatus;
            return await SaveCliente(cliente);
        }

#nullable enable

        public async Task<bool> SaveCliente(Cliente cliente)
        {
            if (await Context.FindAsync<Cliente?>(cliente.Cedula) is null)
            {
                return await AddCliente(cliente);
            }
            return await UpdateCliente(cliente);
        }

        public Task<List<Cliente>> GetAllClientes()
        {
            return Context.Clientes.Include(c => c.TipoSangre)
                                  .ToListAsync();
        }

        public Task<List<Cliente>> GetAllAvailableClientes()
        {
            return Context.Clientes.Where(c => c.Disponible).ToListAsync();
        }

        public async Task<List<(Cliente cliente, decimal montoPendiente)>> GetClientesWhoOweMoney()
        {
            List<Factura> facturas = await Context.Facturas.Include(f => f.Reserva.Vehiculo)
                                                           .Include(f => f.Reserva)
                                                           .ThenInclude(r => r.Cliente)
                                                           .ToListAsync();

            IEnumerable<(Cliente Cliente, decimal montoPendiente)> query2 = from f in facturas
                                                                            where !f.Pagada
                                                                            let montoPendiente = f.MontoAPagar - f.MontoPagado
                                                                            select (f.Reserva.Cliente, montoPendiente) into cm
                                                                            group cm by cm.Cliente into g
                                                                            select (
                                                                                Cliente: g.Key,
                                                                                MontoPendiente: g.Sum(cm => cm.montoPendiente)
                                                                            );

            return query2.ToList();
        }
    }
}
