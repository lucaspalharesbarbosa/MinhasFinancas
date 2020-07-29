using MinhasFinancas.Modelo.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace MinhasFinancas.Models {
    public class ContaViewModel {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Código")]
        public string Codigo { get; set; }

        [Display(Name = "Emissão")]
        [DataType(DataType.Date)]
        public DateTime DataEmissao { get; set; }

        [Required]
        [StringLength(200)]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        [Required]
        [Display(Name = "Valor")]
        public decimal Valor { get; set; }

        [Required]
        [Display(Name = "Tipo da conta")]
        public TipoConta Tipo { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Categoria")]
        public string Categoria { get; set; }

        public GridContaViewModel[] Contas { get; set; }
    }
}