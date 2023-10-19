using Newtonsoft.Json;
using ProjetoAula08.Entities;
using ProjetoAula08.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAula08.Repositories
{
    public class PedidoRepositoryJSON : IPedidoRepository
    { 
        public void Exportar(Pedido pedido)
        { 
            //Criando o nome do arquivo
        var path = $"c:\\temp\\pedido_{pedido.Id}.json";
            //Serializar(transformar) os dados do objeto Pedido
            //para um formato JSON
            var json = JsonConvert.SerializeObject(pedido, Formatting.Indented);
            //gravar os dados em arquivo..
            using (var streamWriter = new StreamWriter(path))
            {
                streamWriter.WriteLine(json);
            }
        }
    }
}
