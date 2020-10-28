using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;


namespace Segundatentativa.Shared
{
    public class Produto
    {
        [Required]
        public int Produto_Id { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public string Descricao { get; set; }
        
        [Required]
        public int Preco { get; set; }

        public List<PedidoProduto> PedidoProduto { get; set; }
         
    }
}