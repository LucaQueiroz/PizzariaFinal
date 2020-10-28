using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;


namespace Segundatentativa.Shared
{
    public class Pedido
    {
        public int Pedido_Id { get; set; }

        public int Usuario_Id { get; set; }

        public Usuario Usuario { get; set;}

        public List<PedidoProduto> PedidoProduto { get; set; }

        public int Cupom_Id { get; set; }

        public Cupom Cupom { get; set; }

        public int Total { get; set; }


    }

}