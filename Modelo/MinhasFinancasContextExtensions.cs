using MinhasFinancas.Modelo.Enums;
using System.Linq;

namespace MinhasFinancas.Modelo {
    public static class MinhasFinancasContextExtensions {
        public static IQueryable<Conta> Despesas(this IQueryable<Conta> query) {
            return query.Where(c => c.Tipo == TipoConta.Pagar);
        }

        public static IQueryable<Conta> Receitas(this IQueryable<Conta> query) {
            return query.Where(c => c.Tipo == TipoConta.Receber);
        }
    }
}
