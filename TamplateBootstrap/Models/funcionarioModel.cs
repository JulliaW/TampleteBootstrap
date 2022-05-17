using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TamplateBootstrap.Models
{
    public class funcionarioModel
    {
        [Key]
        [Display(Name ="ID:")]
        public int Id { get; set; }

        [Required(ErrorMessage ="Informe o nome")]
        [Display(Name ="Nome:")]
        public string Nome { get; set; }

        [Display(Name = "Endereço:")]
        public string Endereco { get; set; }

        [Required(ErrorMessage = "Email inválido")]
        [Display(Name = "Email:")]
        public string Email { get; set; }
    }
}