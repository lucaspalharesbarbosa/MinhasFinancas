using System;
using System.ComponentModel.DataAnnotations;

namespace MinhasFinancas.Models {
    public class EntidadeBase {
        [Key]
        public int Id { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DataCadastro { get; set; }
    }
}
