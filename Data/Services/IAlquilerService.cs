using Sistema_Gestion_Alquiler_Vehiculos.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_Gestion_Alquiler_Vehiculos.Data.Services
{
    interface IAlquilerService
    {
        Task<bool> AddVehiculo(Vehiculo vehiculo);

        Task<bool> UpdateVehiculo(Vehiculo vehiculo);

        Task<bool> SetEstatusVehiculo(Vehiculo vehiculo, bool disponible);

        Task<List<Vehiculo>> GetAllAvailableVehiculos();

        Task<bool> SaveVehiculo(Vehiculo vehiculo);


        Task<List<TipoVehiculo>> GetTiposVehiculo();

        Task<List<TipoSangre>> GetTiposSangre();


        Task<bool> AddCliente(Cliente cliente);

        Task<bool> UpdateCliente(Cliente cliente);

        Task<bool> SetEstatusCliente(Cliente cliente, bool estatus);

        Task<bool> SaveCliente(Cliente cliente);

        Task<List<Cliente>> GetAllAvailableClientes();


        Task<bool> CreateReserva(Reserva reserva);

        Task<List<Reserva>> GetAllReservas();

        Task<List<Vehiculo>> GetReservasFromDates(DateTime FechaI, DateTime FechaF); 


        Task<bool> CreateFactura(Factura factura);

        Task<bool> PayFactura(Factura factura, decimal cant);
    }
}
