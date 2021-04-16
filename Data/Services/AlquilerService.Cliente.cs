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

        public async Task<bool> SetEstatusCliente(Cliente cliente, bool estatus)
        {
            cliente.Disponible = estatus;
            return await Context.SaveChangesAsync() > 0;
        }

#nullable enable

        public async Task<bool> SaveCliente(Cliente cliente)
        {
            if (await Context.FindAsync<Reserva?>(cliente.Cedula) is null)
            {
                return await AddCliente(cliente);
            }
            return await UpdateCliente(cliente);
        }

        public Task<List<Cliente>> GetAllAvailableClientes()
        {
            return Context.Clientes.Where(c => c.Disponible).ToListAsync();
        }
    }
}
