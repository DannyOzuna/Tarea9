using System;
using Microsoft.EntityFrameworkCore;
using Tarea9.Models;

namespace Tarea9.Data{
    public class AppDbContext : DbContext{
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){

        }

        public DbSet<Vacunados> vacunados {get; set;}
        public DbSet<Provincias> provincias {get; set;}
        public DbSet<tipoDeSangre> tipoDeSangre {get; set;}
    }
}