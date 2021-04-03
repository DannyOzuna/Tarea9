using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Tarea9.Models;
using Microsoft.EntityFrameworkCore;

namespace Tarea9.Data.Repositorio{
    public class RepoVacunados : IRepoVacunados{
        public readonly AppDbContext context;

        public RepoVacunados(AppDbContext context){
            this.context = context;
        }

        public async Task<List<Vacunados>> get(){
            return await context.vacunados.ToListAsync();
        }
    }
}