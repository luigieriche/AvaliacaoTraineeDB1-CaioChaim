using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Rh.Presentation.Web.UI.ViewModels
{
    public class CandidatoViewModel
    {
        [Key]
        public int CandidatoId { get; set; }

        [Required(ErrorMessage = "Preencha o campo com seu nome")]
        [MaxLength(150, ErrorMessage="Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Máximo {0} caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Preencha o campo com a idade")]
        [MaxLength(2, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Máximo {0} caracteres")]
        public int Idade { get; set; }

        [Required(ErrorMessage = "Preencha o campo com seu estado")]
        [MaxLength(50, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Máximo {0} caracteres")]
        public string Estado { get; set; }

        [Required(ErrorMessage = "Preencha o campo com sua cidade")]
        [MaxLength(50, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(3, ErrorMessage = "Máximo {0} caracteres")]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "Preencha o campo com seu email")]
        [MaxLength(100, ErrorMessage = "Máximo {0} caracteres")]
        [EmailAddress(ErrorMessage = "Preencha um email válido")]
        [Display(Name="E-mail")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Preencha o campo com seu RG")]
        [MaxLength(9, ErrorMessage = "Máximo {0} caracteres")]
        [Display(Name = "RG")]
        public string Rg { get; set; }

        [Required(ErrorMessage = "Preencha o campo com seu CPF")]
        [MaxLength(11, ErrorMessage = "Máximo {0} caracteres")]
        [Display(Name="CPF")]
        public string Cpf { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }

        [Required(ErrorMessage = "Preencha o campo com a vaga desejada")]
        public string Vaga { get; set; }

        public IEnumerable<TecnologiaViewModel> Tecnologias { get; set; }
    }
}