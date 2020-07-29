using MinhasFinancas.Comum;
using MinhasFinancas.Modelo.Enums;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MinhasFinancas.Modelo {
    [Table("Contas")]
    public class Conta : EntidadeBase {
        [Required]
        [StringLength(100)]
        public string Codigo { get; set; }

        //[Required]
        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        //public DateTime DataEmissao { get; set; }

        [Required]
        [StringLength(200)]
        public string Descricao { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(10, 2)")]
        public decimal Valor { get; set; }

        [Required]
        public TipoConta Tipo { get; set; }

        [Required]
        [StringLength(100)]
        public string Categoria { get; set; }
    }
}
