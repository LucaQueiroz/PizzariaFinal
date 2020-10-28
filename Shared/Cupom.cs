using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;


namespace Segundatentativa.Shared
{
    public class Cupom
    {
        public int Cupom_Id { get; set; }

        public int Desconto { get; set; }
        
        public int Pedido_Id { get; set; }

        public Pedido Pedido { get; set; }
    }
}