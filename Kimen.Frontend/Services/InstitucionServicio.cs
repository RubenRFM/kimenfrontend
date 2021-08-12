using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Kimen.Frontend.Models;

namespace Kimen.Frontend.Services
{
    public class InstitucionServicio : IInstitucionesServicio
    {
        private readonly HttpClient _httpClient;

        public InstitucionServicio(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Institucion>> GetAll()
        {
            List<Institucion> lstInstitucion = new List<Institucion>();
            var result = await _httpClient.GetStringAsync("http://localhost:5002/api/Institucion/listarTiposJson");
            if (result != null)
            {
                foreach (var item in result)
                {
                    lstInstitucion.Add(new Institucion(item.ToString()));
                }
            }

            return lstInstitucion;
        }
    }
}
