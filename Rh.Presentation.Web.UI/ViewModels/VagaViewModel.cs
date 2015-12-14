using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Rh.Presentation.Web.UI.ViewModels
{
    public class VagaViewModel
    {
        [Key]
        public int VagaId { get; set; }

        [Required(ErrorMessage = "Preencha o campo com seu email")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Máximo {0} caracteres")]
        public string Nome { get; set; }

        public int CandidatoId { get; set; }
        public virtual CandidatoViewModel Candidato { get; set; }
    }
}