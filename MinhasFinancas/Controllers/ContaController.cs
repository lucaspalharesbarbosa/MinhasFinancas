using Microsoft.AspNetCore.Mvc;
using MinhasFinancas.Modelo;
using MinhasFinancas.Modelo.Enums;
using MinhasFinancas.Models;
using System;
using System.Linq;

namespace MinhasFinancas.Controllers {
    public class ContaController : Controller {
        private readonly MinhasFinancasContext _db;
        private readonly IContaService _service;

        public ContaController(MinhasFinancasContext db, IContaService service) {
            _db = db;
            _service = service;
        }

        public IActionResult Index(string descricao) {
            return View(new ContaViewModel { 
                DataEmissao = DateTime.Now,
                Contas = _service.ObterContas(descricao)
                    .Select(conta => new GridContaViewModel {
                        Id = conta.Id,
                        Descricao = conta.Descricao,
                        DataEmissao = conta.DataCadastro,
                        Tipo = conta.Tipo,
                        Categoria = conta.Categoria,
                        Valor = conta.Valor
                    }).ToArray()
            });
        }

        [HttpPost]
        public ActionResult Salvar(ContaViewModel model) {
            if (!ModelState.IsValid) {
                RedirectToAction("Index");
            }

            var conta = new Conta {
                Codigo = model.Codigo,
                Descricao = model.Descricao,
                Categoria = model.Categoria,
                Tipo = TipoConta.Pagar,
                Valor = model.Valor
            };

            _service.Salvar(conta);

            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Excluir(int id) {
            _service.Excluir(id);

            return RedirectToAction("Index");
        }

        public ActionResult ResumoContas() {
            return PartialView("ContaReport");
        }

        public JsonResult ObterDespesas() {
            var despesas = _service.ObterCalculoDespesasPorPeriodo(1);

            return new JsonResult(despesas);
        }
    }
}
