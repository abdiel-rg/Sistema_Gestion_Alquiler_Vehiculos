using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Sistema_Gestion_Alquiler_Vehiculos.Data.Models;
using Microsoft.AspNetCore.Identity;

namespace Sistema_Gestion_Alquiler_Vehiculos.Data
{
    public class SGAVContext : IdentityDbContext<IdentityUser>
    {
        public SGAVContext(DbContextOptions<SGAVContext> options)
            : base(options)
        {
        }

        public DbSet<Vehiculo> Vehiculos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Reserva> Reservas { get; set; }
        public DbSet<Factura> Facturas { get; set; }
        public DbSet<TipoVehiculo> TiposVehiculo { get; set; }
        public DbSet<TipoSangre> TiposSangre { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);

            builder.Entity<TipoSangre>().HasData(
                new TipoSangre() { ID = 1, Nombre = "O-" },
                new TipoSangre() { ID = 2, Nombre = "O+" },
                new TipoSangre() { ID = 3, Nombre = "A-" },
                new TipoSangre() { ID = 4, Nombre = "A+" },
                new TipoSangre() { ID = 5, Nombre = "B-" },
                new TipoSangre() { ID = 6, Nombre = "B+" },
                new TipoSangre() { ID = 7, Nombre = "AB-" },
                new TipoSangre() { ID = 8, Nombre = "AB+" }
            );

            builder.Entity<TipoVehiculo>().HasData(
                new TipoVehiculo[]
                {
                    new() { ID = 1, Nombre = "Carro" },
                    new() { ID = 2, Nombre = "Camioneta" },
                    new() { ID = 3, Nombre = "Camión" },
                    new() { ID = 4, Nombre = "Bicicleta" },
                    new() { ID = 5, Nombre = "Motocicleta" },
                    new() { ID = 6, Nombre = "Barco" },
                    new() { ID = 7, Nombre = "Avión" },
                    new() { ID = 8, Nombre = "Cohete" }
                }
            );
        }

    }
}
