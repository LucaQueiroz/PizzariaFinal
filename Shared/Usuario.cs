using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;


namespace Segundatentativa.Shared
{
    public class Usuario
    {
        public int Usuario_Id { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public string Sobrenome { get; set; }

        [Required]
        public string CPF { get; set; }

        [Required]
        public DateTime DataDeNascimento { get; set; }

        [Required]
        public string Endereço { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [MinLength(6, ErrorMessage = "Mínimo de 6 caracteres")]
        public string Senha { get; set; }

        [Required]
        [CompareProperty("Senha", ErrorMessage = "a senha deve ser a mesma")]
        public string ConfirmarSenha { get; set; }

        [Required]
        [Range(typeof(bool), "true", "true", ErrorMessage = "Aceitar os termos é obrigatório")]
        public bool AcceptTerms { get; set; }

        public List<Pedido> Pedidos { get; set; }


    }
}