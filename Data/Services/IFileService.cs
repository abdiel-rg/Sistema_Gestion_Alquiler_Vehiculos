using Microsoft.AspNetCore.Components.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_Gestion_Alquiler_Vehiculos.Data.Services
{
    interface IFileService
    {
        Task<string> ToBase64StringAsync(IBrowserFile file);
    }
}
