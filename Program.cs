using ProjetoAula08.Entities;
using ProjetoAula08.Enums;
using ProjetoAula08.Interfaces;
using ProjetoAula08.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAula08
{
     public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nEXPORTADOR DE DADOS PEDIDO\n");
            try
            {
                //Instanciando a classe pedido...
                var pedido = new Pedido();
                pedido.Cliente = new Cliente();
                pedido.Produtos = new List<Produto>();

                //Entrada de dados do pedido
                pedido.Id = Guid.NewGuid();
                pedido.Cliente.Id = Guid.NewGuid();

                Console.Write("\nData do Pedido........: ");
                pedido.Data = DateTime.Parse(Console.ReadLine());

                Console.Write("\nValor do Pedido........: ");
                pedido.Valor = decimal.Parse(Console.ReadLine());

                Console.Write("\nStatus do Pedido.......: ");
                pedido.Status = (StatusPedido) int.Parse(Console.ReadLine());

                Console.Write("Nome do Cliente..........: ");
                pedido.Cliente.Nome = Console.ReadLine();

                Console.Write("CPF do Cliente...........: ");
                pedido.Cliente.Cpf = Console.ReadLine();

                Console.Write("Email do Cliente..........: ");
                pedido.Cliente.Email = Console.ReadLine();

                //Entrada de dados de produtos
                Console.Write("Número de Produtos......:  ");
                var qtd = int.Parse(Console.ReadLine());

                for (int i = 0; i < qtd; i++)
                {
                    var produto = new Produto();
                    produto.Id = Guid.NewGuid();

                    Console.Write("Nome do Produto........: ");
                    produto.Nome = Console.ReadLine();

                    Console.Write("Preço do Produto.......: ");
                    produto.Preco = decimal.Parse(Console.ReadLine());

                    Console.Write("Quantidade do Produto...:");
                    produto.Quantidade = int.Parse(Console.ReadLine());

                    //Adicionar produto no pedido
                    pedido.Produtos.Add(produto);
                }
                //Verificar se o usuário deseja exportat um XML o JSON
                Console.Write("Informe (1)XML ou (2)JSON.: ");
                var opcao = int.Parse(Console.ReadLine());

                //Null-> sem espaço de memória(sem referência),  vazio
                IPedidoRepository repository = null;

                switch(opcao)
                {
                    case 1:
                        repository = new PedidoRepositoryXML();
                        break;
                    case 2:
                        repository = new PedidoRepositoryJSON();
                        break;
                }

                //Exportar os dados do pedido
                repository.Exportar(pedido);

                Console.WriteLine("\nDados gravados com sucesso!");
            }
            catch(Exception e)
            {
                Console.WriteLine("\nErro: " + e.Message);
            }
            Console.ReadKey();
        }
    }
}
