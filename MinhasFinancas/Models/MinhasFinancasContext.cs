using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace MinhasFinancas.Models {
    public class MinhasFinancasContext : DbContext {

        public MinhasFinancasContext(DbContextOptions<MinhasFinancasContext> options) : base(options) { }

        public override int SaveChanges() {
            PreSaveChanges();

            var quantidadeSalva = base.SaveChanges();

            return quantidadeSalva;
        }

        private void PreSaveChanges() {
            preencherDataCadastro();

            void preencherDataCadastro() {
                var entidadesDataCadastro = ChangeTracker
                    .Entries<EntidadeBase>()
                    .Where(c => c.State == EntityState.Added && c.Entity.DataCadastro == DateTime.MinValue)
                    .ToArray();

                var dataCadastro = DateTime.Now;

                foreach (var entry in entidadesDataCadastro) {
                    entry.Entity.DataCadastro = dataCadastro;
                }
            }
        }

        public virtual DbSet<Conta> Contas { get; set; }
    }
}
