using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Kimen.Frontend.Models;

namespace Kimen.Frontend.Services
{
    public interface IInstitucionesServicio
    {
        Task<List<Institucion>> GetAll();
    }
}
