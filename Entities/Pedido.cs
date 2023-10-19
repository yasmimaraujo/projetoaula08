using ProjetoAula08.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAula08.Entities
{
    public class Pedido
    {
        public Guid Id { get; set; }
        public DateTime Data { get; set; }
        public decimal Valor { get; set; }
        public StatusPedido Status { get; set; }

        // Relacionamentos de associação
        //Pedido TEM 1 cliente
        public Cliente Cliente { get; set; }

        //Relacionamento de associação
        //Pedido TEM MUITOS Produtos
        public List<Produto> Produtos { get; set; }
    }
}
