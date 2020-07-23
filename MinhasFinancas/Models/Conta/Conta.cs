using MinhasFinancas.Models.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MinhasFinancas.Models {
    [Table("Contas")]
    public class Conta : EntidadeBase {
        [Required]
        [StringLength(100)]
        public string Codigo { get; set; }

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
