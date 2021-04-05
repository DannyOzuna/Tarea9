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

        public async Task<List<Vacunados>> Get(){
            return await context.vacunados.ToListAsync();
        }

        public async Task<List<Provincias>> GetProvincias(){
            return await context.provincias.ToListAsync();
        }
        public async Task<List<tipoDeSangre>> GetTipoDeSangres(){
            return await context.tipoDeSangre.ToListAsync();
        }

        public async Task<Vacunados> Add(Vacunados oVacunados){
            if(oVacunados != null){
                //Validamos si existe un registro de vacuna
                var rs = await context.vacunados.FirstOrDefaultAsync(v => v.cedula == oVacunados.cedula);
                
                if(rs == null){
                    await context.AddAsync(oVacunados);
                    await context.SaveChangesAsync();
                    return oVacunados;
                }else{
                    return null;
                }
                

            }else{
                return new Vacunados();
            }
        }
    }
}