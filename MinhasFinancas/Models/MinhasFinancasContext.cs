using Microsoft.EntityFrameworkCore;

namespace MinhasFinancas.Models {
    public class MinhasFinancasContext : DbContext {

        public MinhasFinancasContext(DbContextOptions<MinhasFinancasContext> options) : base(options) { }

        public virtual DbSet<Conta> Contas { get; set; }
    }
}
