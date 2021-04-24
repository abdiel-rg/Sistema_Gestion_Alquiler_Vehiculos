using Sistema_Gestion_Alquiler_Vehiculos.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_Gestion_Alquiler_Vehiculos.Data.Services
{
#nullable enable

    interface IAlquilerService
    {
        Task<bool> AddVehiculo(Vehiculo vehiculo);

        Task<bool> UpdateVehiculo(Vehiculo vehiculo);
        
        Task<Vehiculo?> FindVehiculo(int ID);

        Task<bool> SetEstatusVehiculo(int id);

        Task<bool> SetEstatusVehiculo(int id, bool estado);

        Task<List<Vehiculo>> GetAllVehiculos();

        Task<List<Vehiculo>> GetAllAvailableVehiculos();

        Task<List<Vehiculo>> GetAllAvailableVehiculos(DateTime FechaI, DateTime FechaF);

        Task<bool> SaveVehiculo(Vehiculo vehiculo);


        Task<bool> AddTipoVehiculo(TipoVehiculo tipo);

        Task<List<TipoVehiculo>> GetTiposVehiculo();


        Task<List<TipoSangre>> GetTiposSangre();


        Task<bool> AddCliente(Cliente cliente);

        Task<bool> UpdateCliente(Cliente cliente);

        ValueTask<Cliente?> FindCliente(string cedula);

        Task<bool> SetEstatusCliente(string cedula);

        Task<bool> SetEstatusCliente(string cedula, bool estatus);

        Task<bool> SaveCliente(Cliente cliente);

        Task<List<Cliente>> GetAllClientes();

        Task<List<Cliente>> GetAllAvailableClientes();


        Task<bool> CreateReserva(Reserva reserva);

        Task<Reserva?> FindReserva(int ID);

        Task<List<Reserva>> GetAllReservas();

        
        Task<bool> UpdateFactura(Factura factura);

        Task<bool> PayFactura(Factura factura, decimal cant);
    }
}
