using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace Rh.Presentation.Web.UI.ViewModels
{
    public class TecnologiaViewModel
    {
        [Key]
        public int TecnologiaId { get; set; }

        [Required(ErrorMessage = "Preencha o campo com o nome do produto")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Máximo {0} caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Preencha o campo com a categoria")]
        public string Categoria { get; set; }

        public int CandidatoId { get; set; }

        public virtual CandidatoViewModel Candidato { get; set; }
    }
}