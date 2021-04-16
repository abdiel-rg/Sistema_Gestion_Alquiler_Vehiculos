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
    }
}
