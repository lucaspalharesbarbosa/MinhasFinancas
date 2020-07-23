using System.Diagnostics;
using System.Security.Cryptography;
using Microsoft.AspNetCore.Mvc;
using MinhasFinancas.Comum.Extensions;
using MinhasFinancas.Models;

namespace MinhasFinancas.Controllers {
    public class ContaController : Controller {
        private readonly MinhasFinancasContext _db;
        private readonly IContaService _service;

        public ContaController(MinhasFinancasContext db, IContaService service) {
            _db = db;
            _service = service;
        }

        public IActionResult Index(string descricao) {
            var contas = _service.ObterContas(descricao);

            return View(contas);
        }

        [HttpPost]
        public ActionResult Salvar(Conta conta) {
            if (!ModelState.IsValid) {
                RedirectToAction("Index");
            }

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
