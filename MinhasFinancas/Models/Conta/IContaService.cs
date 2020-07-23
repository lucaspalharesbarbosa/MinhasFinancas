using System.Collections.Generic;

namespace MinhasFinancas.Models {
    public interface IContaService {
        Conta[] ObterContas(string descricao);
        void Salvar(Conta conta);
        void Excluir(int id);
        Dictionary<string, decimal> ObterCalculoDespesasPorPeriodo(int periodo);
        Dictionary<string, decimal> ObterCalculoDespesasPorSemana(int periodo);
    }
}
