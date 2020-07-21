using MinhasFinancas.Comum.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MinhasFinancas.Models {
    public class ContaService : IContaService {
        private MinhasFinancasContext _db { get; }

        public ContaService(MinhasFinancasContext db) {
            _db = db;
        }

        public void Salvar(Conta conta) {
            if (conta.Id.IsEmpty()) {
                _db.Add(conta);
            } else {
                _db.Update(conta);
            }
        }

        public void Excluir(int id) {
            var conta = _db.Contas.FindById(id);

            if (conta != null) {
                _db.Remove(conta);

                _db.SaveChanges();
            }
        }

        public Conta[] ObterContas(string descricao) {
            var contas = _db.Contas.ToArray();

            if (!string.IsNullOrEmpty(descricao)) {
                contas = contas.Where(c => c.Descricao.Contains(descricao)).ToArray();
            }

            return contas;
        }

        public Dictionary<string, decimal> CalcularDespesasPorPeriodo(int periodo) {
            var somasDespesasPeriodo = new Dictionary<string, decimal>();

            var valorTotalAlimentacao = _db.Contas
                .Where(c => c.Categoria == "Alimentação")
                .Sum(c => c.Valor);
            var valorTotalCompras = _db.Contas
                .Where(c => c.Categoria == "Compras")
                .Sum(c => c.Valor);
            var valorTotalTransporte = _db.Contas
                .Where(c => c.Categoria == "Transporte")
                .Sum(c => c.Valor);
            var valorTotal = _db.Contas
                .Where(c => c.Categoria == "Saúde")
                .Sum(c => c.Valor);
            var valorTotalMoradia = _db.Contas
                .Where(c => c.Categoria == "Moradia")
                .Sum(c => c.Valor);

            somasDespesasPeriodo.Add("Alimentação", valorTotalAlimentacao);
            somasDespesasPeriodo.Add("Compras", valorTotalCompras);
            somasDespesasPeriodo.Add("Transporte", valorTotalTransporte);
            somasDespesasPeriodo.Add("Saúde", valorTotal);
            somasDespesasPeriodo.Add("Moradia", valorTotalMoradia);

            return somasDespesasPeriodo;
        }

        public Dictionary<string, decimal> CalcularDespesasPorSemana(int periodo) {
            throw new NotImplementedException();
        }
    }
}
