﻿using Sistema_Gestion_Alquiler_Vehiculos.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

        public async Task<bool> PayFactura(Factura factura, decimal cant)
        {
            factura.MontoPagado += cant;
            return await UpdateFactura(factura);
        }
    }
}
