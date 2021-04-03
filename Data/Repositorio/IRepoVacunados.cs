
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Tarea9.Models;

namespace Tarea9.Data.Repositorio{
    public interface IRepoVacunados{
        public Task<List<Vacunados>> Get();

        public Task<List<Provincias>> GetProvincias();
        public Task<List<tipoDeSangre>> GetTipoDeSangres();
        public Task<Vacunados> Add(Vacunados oVacunados);
    }
}