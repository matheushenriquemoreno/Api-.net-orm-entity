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


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<EquipamentoCliente>()
                .HasOne(CE => CE.Equipamento)
                .WithMany(E => E.Clientes);

            modelBuilder.Entity<EquipamentoCliente>()
              .HasOne(EC => EC.Cliente)
              .WithMany(Cliente => Cliente.Equipamentos);

            modelBuilder.Entity<EquipamentoCliente>()
              .HasMany(E => E.OrdensServicos)
              .WithOne(OS => OS.EquipamentoCliente);

            modelBuilder.Entity<OrdemServico>()
                .HasOne(OS => OS.Tecnico)
                .WithMany(T => T.OrdensServicos);

            modelBuilder.Entity<OrdemServico>()
                .HasOne(OS => OS.StatusDaOrdem)
                .WithOne(SOS => SOS.Ordem)
                .HasForeignKey<OrdemServico>("IdStatusOrdemServico");
               

        }



        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Equipamento> Equipamentos { get; set; }
        public DbSet<EquipamentoCliente> EquipamentosClientes { get; set; }
        

        public DbSet<OrdemServico> OrdemServicos { get; set;  }
        public DbSet<StatusOrdemServico> StatusOrdems { get; set; }

        
        public DbSet<Tecnico> Tecnicos { get; set; }
        public DbSet<Especialidades> Especialidades { get; set; }




    }
}
