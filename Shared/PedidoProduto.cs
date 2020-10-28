using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;


namespace Segundatentativa.Shared
{
    public class PedidoProduto
    {
        public int PedidoProduto_Id { get; set; }

        public int Pedido_Id { get; set; }

        public Pedido Pedido { get; set; }

        public int Produto_Id { get; set; }

        public Produto Produto { get; set; }

    }
}