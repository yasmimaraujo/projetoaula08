using ProjetoAula08.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAula08.Interfaces
{
    public interface IPedidoRepository
    {
        //Uma interface só pode conter métodos abstratos
        // Ou seja métodos que não possuem corpo, apenas assinatura
        //Esses métodos deverão ser implementados(programados)
        //nas classes que herdam esta interface

        void Exportar(Pedido pedido);
    }
}
