using Microsoft.EntityFrameworkCore;
using sistemaGerenciamentoAssistenciaTecnica.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistemaGerenciamentoAssistenciaTecnica.InfraEntity
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> opcoes) : base(opcoes) { }

       // public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Tecnico> Tecnicos { get; set; }
        public DbSet<Especialidades> Especialidades { get; set; }
    }
}
