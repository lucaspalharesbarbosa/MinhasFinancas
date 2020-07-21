using System.Collections.Generic;

namespace MinhasFinancas.Models {
    public interface IContaService {
        Conta[] ObterContas(string descricao);
        void Salvar(Conta conta);
        void Excluir(int id);
        Dictionary<string, decimal> CalcularDespesasPorPeriodo(int periodo);
        Dictionary<string, decimal> CalcularDespesasPorSemana(int periodo);
    }
}
